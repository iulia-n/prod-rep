namespace ProdRep
{
    partial class FormNewSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(442, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(322, 146);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(173, 81);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(282, 20);
            this.textPhone.TabIndex = 31;
            this.textPhone.TabStop = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(62, 89);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Phone Number";
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(173, 54);
            this.textBoxSupplierAddress.Multiline = true;
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(282, 20);
            this.textBoxSupplierAddress.TabIndex = 27;
            this.textBoxSupplierAddress.TabStop = false;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Location = new System.Drawing.Point(62, 61);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(92, 13);
            this.labelSupplierAddress.TabIndex = 26;
            this.labelSupplierAddress.Text = "Company Address";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(173, 112);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(282, 20);
            this.textBoxContact.TabIndex = 23;
            this.textBoxContact.TabStop = false;
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(173, 27);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(282, 20);
            this.textBoxSupplierName.TabIndex = 22;
            this.textBoxSupplierName.TabStop = false;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(62, 116);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(80, 13);
            this.labelContact.TabIndex = 20;
            this.labelContact.Text = "Contact Person";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(62, 30);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(82, 13);
            this.labelSupplierName.TabIndex = 19;
            this.labelSupplierName.Text = "Company Name";
            // 
            // FormAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 194);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxSupplierAddress);
            this.Controls.Add(this.labelSupplierAddress);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxSupplierName);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelSupplierName);
            this.Name = "FormAddSupplier";
            this.Text = "New Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxSupplierAddress;
        private System.Windows.Forms.Label labelSupplierAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelSupplierName;
    }
}