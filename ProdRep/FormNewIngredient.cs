using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdRep
{
    public partial class FormNewIngredient : Form
    {

        public FormNewIngredient()
        {
            InitializeComponent();
        }

        /* Add a new ingredient in the database with the details on the form
         * when Save button is clicked
         */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string textForNullTextBox = "Fill in ";
            string textForBlankIngredientName = "";
            string textForBlankUoM = "";
            bool ok_to_save = true;
            if (textBoxIngredientName.Text.Equals(""))
            {
                textForBlankIngredientName = "the ingredient's name";
                textBoxIngredientName.BackColor = AppSettings.Instance.getBlankTextColor();
                ok_to_save = false;
            }
            else
            {
                textBoxIngredientName.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            }
            if (textBoxIngredientUoM.Text.Equals(""))
            {
                textForBlankUoM = "the unit of measurement";
                textBoxIngredientUoM.BackColor = AppSettings.Instance.getBlankTextColor();
                ok_to_save = false;
            }
            else
            {
                textBoxIngredientUoM.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            }

            if (!ok_to_save)
            {
                if (textForBlankIngredientName.Equals(""))
                {
                    textForNullTextBox += textForBlankUoM;
                }
                else
                {
                    textForNullTextBox += textForBlankIngredientName;
                    if (textForBlankUoM.Equals("") == false)
                    {
                        textForNullTextBox += " and " + textForBlankUoM;
                    }
                }
                MessageBox.Show(textForNullTextBox);
            }
            else
            {
                ProdRepDBDataSetTableAdapters.IngredientsTableAdapter tableAdapterIngredients = new ProdRepDBDataSetTableAdapters.IngredientsTableAdapter();
                tableAdapterIngredients.Insert(textBoxIngredientName.Text, textBoxIngredientUoM.Text); 
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
