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
    public partial class FormNewSupplier : Form
    {

        public FormNewSupplier()
        {
            InitializeComponent();
        }

        /* Add a new supplier in the database with the details on the form
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
                ProdRepDBDataSetTableAdapters.SuppliersTableAdapter tableAdapterSuppliers = new ProdRepDBDataSetTableAdapters.SuppliersTableAdapter();
                tableAdapterSuppliers.Insert(textBoxSupplierName.Text, textBoxSupplierAddress.Text, textBoxContact.Text, textPhone.Text);
                this.Close();
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
