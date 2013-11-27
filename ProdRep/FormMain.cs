/* Main form - the form that gets loaded when the application starts
 * It contains the company details and actions for managing the ingredients and the final products
 */


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
    public partial class FormMain : Form
    {

        
        public FormMain()
        {
            InitializeComponent();
        }
       
        /* On load, display the company details 
         */
        private void FormMain_Load(object sender, EventArgs e)
        {
            defaultSettings();
            fillInDetailsCompany();
        }

        private void defaultSettings()
        {
            textBoxCompanyAddress.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxCompanyName.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxCompanyPhone.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxCompanyCentre.BackColor = AppSettings.Instance.getDisabledTextBoxColor();

            textBoxCompanyAddress.ReadOnly = true;
            textBoxCompanyName.ReadOnly = true;
            textBoxCompanyPhone.ReadOnly = true;
            textBoxCompanyCentre.ReadOnly = true;

            buttonEdit.Visible = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }

        /* Display the company details in textboxes on the form
         */
        private void fillInDetailsCompany()
        {
            ProdRepDBDataSetTableAdapters.CompanyTableAdapter tableAdapterCompany = new ProdRepDBDataSetTableAdapters.CompanyTableAdapter();
            ProdRepDBDataSet.CompanyDataTable dataTableCompany = new ProdRepDBDataSet.CompanyDataTable();
            tableAdapterCompany.Fill(dataTableCompany);
            try
            {
                int id = tableAdapterCompany.QueryMaxValue().Value;
                ProdRepDBDataSet.CompanyRow dataRowCompany = dataTableCompany.FindByid(tableAdapterCompany.QueryMaxValue().Value);
                textBoxCompanyName.Text = dataRowCompany.name;
                textBoxCompanyAddress.Text = dataRowCompany.address;
                textBoxCompanyPhone.Text = dataRowCompany.phone;
                textBoxCompanyCentre.Text = dataRowCompany.centre;
            }
            catch
            {
                //there are no company details in the database - leave the textboxes blank
            }
        }


        /* Enable the user to edit the company details 
         * after clicking the Edit button
         */
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editSettings();
        }

        private void editSettings()
        {
            textBoxCompanyAddress.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxCompanyName.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxCompanyPhone.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxCompanyCentre.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            
            textBoxCompanyAddress.ReadOnly = false;
            textBoxCompanyName.ReadOnly = false;
            textBoxCompanyPhone.ReadOnly = false;
            textBoxCompanyCentre.ReadOnly = false;
           
            textBoxCompanyAddress.Enabled = true;
            textBoxCompanyName.Enabled = true;
            textBoxCompanyPhone.Enabled = true;
            textBoxCompanyCentre.Enabled = true;

            buttonEdit.Visible = false;
            buttonCancel.Visible = true;
            buttonSave.Visible = true;
        }

        /* Cancel the changes to the compay details 
         * and display the initial details when the Cancel button is clicked
         */
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            defaultSettings();
            fillInDetailsCompany();
        }


        /* Save the changes to the company details in the database when the Save button is clicked
         */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ProdRepDBDataSetTableAdapters.CompanyTableAdapter tableAdapterCompany = new ProdRepDBDataSetTableAdapters.CompanyTableAdapter();
            try
            {
                int id = (int)tableAdapterCompany.QueryMaxValue();
                tableAdapterCompany.Update(textBoxCompanyName.Text, textBoxCompanyAddress.Text, textBoxCompanyPhone.Text, textBoxCompanyCentre.Text, id);
            }
            catch
            {
                //no company details in the database table - insert a new line in the database table with the details on the form
                tableAdapterCompany.Insert(textBoxCompanyName.Text, textBoxCompanyAddress.Text, textBoxCompanyPhone.Text, textBoxCompanyCentre.Text); 
            }
            defaultSettings();
        }

        /* Load the form displaying the suppliers details
         */
        private void buttonSuppliersDetails_Click(object sender, EventArgs e)
        {
            FormSuppliersDetails f = new FormSuppliersDetails();
            f.Show();
        }

        /* Load the form to add a new supplier
         */
        private void buttonNewSupplier_Click(object sender, EventArgs e)
        {
            FormNewSupplier f = new FormNewSupplier();
            f.Show();
        }


        /* Load the form to add a new ingredient
         */
        private void buttonNewIngredient_Click(object sender, EventArgs e)
        {
            FormNewIngredient formNewIngredient = new FormNewIngredient();
            formNewIngredient.Show();
        }

        /* Load the form to add a new product
         */
        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            FormNewProduct f = new FormNewProduct();
            f.Show();
        }


        /* Load the form displaying the ingredients details
         */
        private void buttonIngredientDetails_Click(object sender, EventArgs e)
        {
            FormIngredientDetails f = new FormIngredientDetails();
            f.Show();
        }
        
    }
}
