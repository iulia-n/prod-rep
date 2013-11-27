/*Shows the ingredients' details and allows editting*/


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
    public partial class FormIngredientDetails : Form
    {

        private ProdRepDBDataSet.IngredientsDataTable dataTableIngredients = new ProdRepDBDataSet.IngredientsDataTable();

        public FormIngredientDetails()
        {
            InitializeComponent();
        }
        
        /* On form load, display the ingredients names in a combobox
         * and the details of the default selected ingredient
         */
        private void FormIngredientDetails_Load(object sender, EventArgs e)
        {
            ProdRepDBDataSetTableAdapters.IngredientsTableAdapter tableAdapterIngredients = new ProdRepDBDataSetTableAdapters.IngredientsTableAdapter();
            tableAdapterIngredients.Fill(dataTableIngredients);

            comboBoxIngredients.DataSource = dataTableIngredients;
            comboBoxIngredients.DisplayMember = dataTableIngredients.nameColumn.ColumnName;
            comboBoxIngredients.ValueMember = dataTableIngredients.idColumn.ColumnName;
            comboBoxIngredients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIngredients.SelectedIndex = 0;

            ProdRepDBDataSet.IngredientsRow rowIngredients = dataTableIngredients.FindByid(int.Parse(comboBoxIngredients.SelectedValue.ToString()));
            textBoxIngredientName.Text = rowIngredients.name;
            textBoxIngredientUoM.Text = rowIngredients.UoM;

            defaultSettings();
        }

       /* Display the details of the selected ingredient
        */
        private void comboBoxIngredients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillInDetails();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editSettings();
        }


        private void editSettings()
        {
            textBoxIngredientName.ReadOnly = false;
            textBoxIngredientUoM.ReadOnly = false;
            textBoxIngredientName.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxIngredientUoM.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxIngredientName.Focus();
            buttonSave.Visible = true;
            buttonEdit.Visible = false;
            buttonCancel.Visible = true;
        }

        /* Update the ingredients details in the databse when the Save button is clicked
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
                textForBlankUoM = "the unity of measurement";
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
                int id_ingredient = int.Parse(comboBoxIngredients.SelectedValue.ToString());
                tableAdapterIngredients.Update(textBoxIngredientName.Text, textBoxIngredientUoM.Text, id_ingredient);
                defaultSettings();

                //refresh the comboBox source for the displayed ingredients so the new details are shown
                tableAdapterIngredients.Fill(dataTableIngredients);
                comboBoxIngredients.SelectedValue = id_ingredient;
            }
        }

        /* Cancel editing the ingredients details and display the initial values
         */
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            fillInDetails();
            defaultSettings();
        }

        private void fillInDetails()
        {
            ProdRepDBDataSet.IngredientsRow rowIngredients = dataTableIngredients.FindByid(int.Parse(comboBoxIngredients.SelectedValue.ToString()));
            textBoxIngredientName.Text = rowIngredients.name;
            textBoxIngredientUoM.Text = rowIngredients.UoM;
        }


        private void defaultSettings()
        {
            buttonSave.Visible = false;
            buttonEdit.Visible = true;
            buttonCancel.Visible = false;
            textBoxIngredientName.ReadOnly = true;
            textBoxIngredientName.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxIngredientUoM.ReadOnly = true;
            textBoxIngredientUoM.BackColor = AppSettings.Instance.getDisabledTextBoxColor(); 
        }
    }
}
