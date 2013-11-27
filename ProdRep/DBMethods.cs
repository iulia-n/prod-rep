/* Class containing methods accessing the database
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Transactions;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Data;


namespace ProdRep
{
    class DBMethods
    {
        string db_con_string = ConfigurationManager.ConnectionStrings["ProdRep.Properties.Settings.ProdRepDBConnectionString"].ConnectionString;
        SqlCeConnection db_con;

        public DBMethods()
        {
            db_con = new SqlCeConnection(db_con_string);
        }

        /* Given a product id, returns a datatable containing the product's recipe - ingredient ids and quantities
         */
        public DataTable getRecipeIngredientsForProduct(int id_product)
        {
            db_con.Open();
            
            string query = "SELECT Recipes_Ingredients.id_ingredient, CAST(Recipes_Ingredients.quantity AS FLOAT) AS quantity " +
                            "FROM Recipes_Ingredients INNER JOIN Recipes ON Recipes_Ingredients.id_recipe = Recipes.id " +
                            "WHERE Recipes.id_product = @param_id_product";

            SqlCeCommand commandProductRecipeDetails = new SqlCeCommand(query, db_con);

            SqlCeParameter param_id_product = new SqlCeParameter();
            param_id_product.ParameterName = "@param_id_product";
            param_id_product.Value = id_product;
            commandProductRecipeDetails.Parameters.Add(param_id_product);

            DataTable dataTableProductRecipeDetails = new DataTable();

            using (SqlCeDataReader dr = commandProductRecipeDetails.ExecuteReader())
            {
                dataTableProductRecipeDetails.Load(dr);
            }

            db_con.Close();

            return dataTableProductRecipeDetails;
        }

        /* Given a product's name, it's UoM and recipe - ingredients ids and quantities
         * add a new product in the database with corresponding values
         */
        public bool insertProduct(string product_name, string product_UoM, Dictionary<int, double> ingredients_quantity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    db_con.Open();
                    string queryInsertProduct = "INSERT INTO Products(name, UoM) VALUES(@param_name, @param_UoM)";
                    SqlCeCommand commandInsertProduct = new SqlCeCommand(queryInsertProduct, db_con);
                    SqlCeParameter param_product_name = new SqlCeParameter();
                    param_product_name.ParameterName = "@param_name";
                    param_product_name.Value = product_name;
                    commandInsertProduct.Parameters.Add(param_product_name);
                    
                    SqlCeParameter param_product_UoM = new SqlCeParameter();
                    param_product_UoM.ParameterName = "@param_UoM";
                    param_product_UoM.Value = product_UoM;
                    commandInsertProduct.Parameters.Add(param_product_UoM);

                    int queryResult = commandInsertProduct.ExecuteNonQuery();

                    if (queryResult > 0)
                    {
                        string queryNewProductId = "SELECT MAX(id) FROM Products";
                        SqlCeCommand commandNewProductId = new SqlCeCommand(queryNewProductId, db_con);
                        int newProductId = (int)commandNewProductId.ExecuteScalar();
                        insertRecipe(newProductId, ingredients_quantity);
                    }
                    db_con.Close();
                    scope.Complete();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        /* Given a product's id and a dictionary representing the product's recipe - ingredients ids and corresponding quantities
         * add a new recipe to the database for the product with the given id
         */
        private int insertRecipe(int id_product, Dictionary<int,double> ingredients_quantity)
        {
            string queryInsertRecipe = "INSERT INTO Recipes(id_product) VALUES(@param_id_product)";
            SqlCeCommand commandInsertRecipe = new SqlCeCommand(queryInsertRecipe, db_con);
            SqlCeParameter param_id_product = new SqlCeParameter();
            param_id_product.ParameterName = "@param_id_product";
            param_id_product.Value = id_product;
            commandInsertRecipe.Parameters.Add(param_id_product);
            int result = commandInsertRecipe.ExecuteNonQuery();
            if (result > 0)
            {
                string queryNewRecipeId = "SELECT MAX(id) FROM Recipes";
                SqlCeCommand commandNewRecipeId = new SqlCeCommand(queryNewRecipeId, db_con);
                int newRecipeId = (int)commandNewRecipeId.ExecuteScalar();
                insertRecipeIngredients(newRecipeId, ingredients_quantity);
                return newRecipeId;
            }
            return -1;
        }

        /* Given the recipe id and a dictionary representing a product's recipe - ingredients ids and corresponding quantities
         * add the recipe's details to the database in the Recipes_Ingredients table
         */
        private int insertRecipeIngredients(int id_recipe, Dictionary<int, double> ingredients_quantity)
        {
            string queryInsertRecipeIngredient = "INSERT INTO Recipes_Ingredients(id_recipe, id_ingredient, quantity) " +
                                                "VALUES(@param_id_recipe, @param_id_ingredient, @param_quantity)";

            SqlCeCommand commandInsertRecipeIngredient = new SqlCeCommand(queryInsertRecipeIngredient, db_con);

            SqlCeParameter param_id_recipe = new SqlCeParameter();
            param_id_recipe.ParameterName = "@param_id_recipe";
            param_id_recipe.Value = id_recipe;
            commandInsertRecipeIngredient.Parameters.Add(param_id_recipe);

            SqlCeParameter param_id_ingredient = new SqlCeParameter();
            param_id_ingredient.ParameterName = "@param_id_ingredient";
            commandInsertRecipeIngredient.Parameters.Add(param_id_ingredient);

            SqlCeParameter param_quantity = new SqlCeParameter();
            param_quantity.ParameterName = "@param_quantity";
            commandInsertRecipeIngredient.Parameters.Add(param_quantity);

            int rows_inserted = 0;

            foreach (KeyValuePair<int, double> pair in ingredients_quantity)
            {
                int id_ingredient = pair.Key;
                double quantity = pair.Value;
                if (quantity > 0)
                {
                    param_id_ingredient.Value = id_ingredient;
                    param_quantity.Value = quantity;
                    rows_inserted += commandInsertRecipeIngredient.ExecuteNonQuery();
                }
            }

            return rows_inserted;
        }

    }
}
