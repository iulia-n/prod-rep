/*Shows the suppliers' details and allows editing*/


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
    public partial class FormSuppliersDetails : Form
    {
        private ProdRepDBDataSet.SuppliersDataTable dataTableSuppliers = new ProdRepDBDataSet.SuppliersDataTable();
        public FormSuppliersDetails()
        {
            InitializeComponent();
        }

        /* On load, display the suppliers' names in a combobox and display the details for the supplier selected
         */
        private void FormSuppliersDetails_Load(object sender, EventArgs e)
        {
            ProdRepDBDataSetTableAdapters.SuppliersTableAdapter tableAdapterSuppliers = new ProdRepDBDataSetTableAdapters.SuppliersTableAdapter();
            tableAdapterSuppliers.Fill(dataTableSuppliers);
            comboBoxSuppliers.DataSource = dataTableSuppliers;
            comboBoxSuppliers.DisplayMember = dataTableSuppliers.nameColumn.ColumnName;
            comboBoxSuppliers.ValueMember = dataTableSuppliers.idColumn.ColumnName;
            fillInDetails();
            defaultSettings();
        }

        private void defaultSettings()
        {
            textBoxSupplierAddress.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxContact.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxSupplierName.BackColor = AppSettings.Instance.getDisabledTextBoxColor();
            textBoxSupplierPhone.BackColor = AppSettings.Instance.getDisabledTextBoxColor();

            textBoxSupplierAddress.ReadOnly = true;
            textBoxContact.ReadOnly = true;
            textBoxSupplierName.ReadOnly = true;
            textBoxSupplierPhone.ReadOnly = true;

            buttonEdit.Visible = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }

        /* Display the details for the supplier selected when the user changes the selection in the suppliers combobox
         */
        private void comboBoxFurnizori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillInDetails();
        }

        /* Display the details for a particular supplier
         */
        private void fillInDetails()
        {
            int id_supplier = int.Parse(comboBoxSuppliers.SelectedValue.ToString());
            ProdRepDBDataSet.SuppliersRow rowSuppliers = dataTableSuppliers.FindByid(id_supplier);
            textBoxSupplierAddress.Text = rowSuppliers.address;
            textBoxContact.Text = rowSuppliers.contact;
            textBoxSupplierName.Text = rowSuppliers.name;
            textBoxSupplierPhone.Text = rowSuppliers.phone;
        }

        /* Save the changes to the supplier displayed in the database
         */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxSupplierName.Text.Equals(""))
            {
                textBoxSupplierName.BackColor = AppSettings.Instance.getBlankTextColor();
                MessageBox.Show("The supplier must have a name.");
            }
            else
            {
                int id_supplier = int.Parse(comboBoxSuppliers.SelectedValue.ToString());
                ProdRepDBDataSetTableAdapters.SuppliersTableAdapter tableAdapterSupplier = new ProdRepDBDataSetTableAdapters.SuppliersTableAdapter();
                tableAdapterSupplier.Update(textBoxSupplierName.Text, textBoxSupplierAddress.Text, textBoxContact.Text, textBoxSupplierPhone.Text, id_supplier);
                defaultSettings();

                //refresh the comboBox source for the displayed ingredients so the new details are shown
                tableAdapterSupplier.Fill(dataTableSuppliers);
                comboBoxSuppliers.SelectedValue = id_supplier;
            }
        }

        /* Cancel editing the ingredients details and display the initial values
         */
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            defaultSettings();
            fillInDetails();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editSettings();

        }

        private void editSettings()
        {
            textBoxSupplierAddress.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxContact.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxSupplierName.BackColor = AppSettings.Instance.getEnabledTextBoxColor();
            textBoxSupplierPhone.BackColor = AppSettings.Instance.getEnabledTextBoxColor();

            textBoxSupplierAddress.ReadOnly = false;
            textBoxContact.ReadOnly = false;
            textBoxSupplierName.ReadOnly = false;
            textBoxSupplierPhone.ReadOnly = false;

            buttonEdit.Visible = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
        }

    }
}
