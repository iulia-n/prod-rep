using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;
using System.Configuration;
using System.Data.SqlServerCe;

namespace ProdRep
{
    public partial class FormNewProduct : Form
    {
        private double initialCellValue;
        public FormNewProduct()
        {
            InitializeComponent();
        }

        /* Display all the ingredients for the recipe, with quantity set to 0 in a datagridview.
         * The user can choose to load another product's recipe - the user can choose the product from a combobox.
         * Set the datasource to the combobox.
         */
        private void FormNewProduct_Load(object sender, EventArgs e)
        {
            ProdRepDBDataSetTableAdapters.ProductsTableAdapter tableAdapterProducts = new ProdRepDBDataSetTableAdapters.ProductsTableAdapter();
            ProdRepDBDataSet.ProductsDataTable dataTableProducts = new ProdRepDBDataSet.ProductsDataTable();
            tableAdapterProducts.Fill(dataTableProducts);
            comboBoxProducts.DataSource = dataTableProducts;
            comboBoxProducts.DisplayMember = "name";
            comboBoxProducts.ValueMember = "id";
            comboBoxProducts.SelectedIndex = -1;
            comboBoxProducts.Text = "";

            ProdRepDBDataSetTableAdapters.IngredientsTableAdapter tableAdapterIngredients = new ProdRepDBDataSetTableAdapters.IngredientsTableAdapter();
            ProdRepDBDataSet.IngredientsDataTable dataTableIngredients = new ProdRepDBDataSet.IngredientsDataTable();
            tableAdapterIngredients.Fill(dataTableIngredients);
            for (int i = 0; i < dataTableIngredients.Rows.Count; i++)
            {
                dataGridViewRecipe.Rows.Add();
                dataGridViewRecipe.Rows[i].Cells[0].Value = dataTableIngredients[i].id.ToString();
                dataGridViewRecipe.Rows[i].Cells[1].Value = dataTableIngredients[i].name;
                dataGridViewRecipe.Rows[i].Cells[2].Value = "0";
                dataGridViewRecipe.Rows[i].Cells[3].Value = dataTableIngredients[i].UoM;
            }

        }

        private void dataGridViewRecipe_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            initialCellValue = double.Parse(dataGridViewRecipe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        /* Checks that the value entered in the datagridview's cell is a double
         */
        private void dataGridViewRecipe_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    double x = double.Parse(dataGridViewRecipe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("The quantity is not valid.");
                    dataGridViewRecipe.CancelEdit();
                    dataGridViewRecipe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = initialCellValue.ToString();
                }
            }
        }

        /* Enable or disable the option to load another product's recipe
         */
        private void radioButtonRecipe2_CheckedChanged(object sender, EventArgs e)
        {
            if (labelProduct.Visible == false)
            {
                labelProduct.Visible = true;
                comboBoxProducts.Visible = true;
                comboBoxProducts.SelectedIndex = -1;
                comboBoxProducts.Text = "";
            }
            else
            {
                labelProduct.Visible = false;
                comboBoxProducts.Visible = false;
                for (int i = 0; i < dataGridViewRecipe.Rows.Count; i++)
                {
                    dataGridViewRecipe.Rows[i].Cells[2].Value = "0";
                }
            }
        }

        /* Load the selected product's recipe - product selected in comboBoxProducts
         */
        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > -1)
            {
                int id_product;
                bool res = int.TryParse(((ComboBox)sender).SelectedValue.ToString(), out id_product);
                if (res)
                {
                    DBMethods dbMethods = new DBMethods();
                    DataTable dataTableRecipesIngredients = dbMethods.getRecipeIngredientsForProduct(id_product);

                    for (int i = 0; i < dataGridViewRecipe.Rows.Count; i++)
                    {
                        dataGridViewRecipe.Rows[i].Cells[2].Value = "0";
                        for (int j = 0; j < dataTableRecipesIngredients.Rows.Count; j++)
                        {
                            if (int.Parse(dataGridViewRecipe.Rows[i].Cells[0].Value.ToString()) == int.Parse(dataTableRecipesIngredients.Rows[j]["id_ingredient"].ToString()))//"id_ingredient"].ToString()))
                            {
                                dataGridViewRecipe.Rows[i].Cells[2].Value = dataTableRecipesIngredients.Rows[j]["quantity"].ToString();
                                j = dataTableRecipesIngredients.Rows.Count;
                            }
                        }
                    }
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Add the new product in the database with the recipe on the form
         */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!textBoxProductName.Text.Equals(""))
            {
                DBMethods dbMethods = new DBMethods();
                HelperMethods helperMethods = new HelperMethods();
                Dictionary<int, double> ingredients_quantity = helperMethods.getDictionaryFromDataGridViewColumns(dataGridViewRecipe, 0,2);
                bool inserted = dbMethods.insertProduct(textBoxProductName.Text, textBoxUoM.Text, ingredients_quantity);

                if (inserted)
                {
                    MessageBox.Show("New product was added successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The product could not be added");
                }
            }
        }
    }
}
