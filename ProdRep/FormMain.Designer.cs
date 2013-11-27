namespace ProdRep
{
    partial class FormMain
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
            this.groupBoxIngredients = new System.Windows.Forms.GroupBox();
            this.buttonNewSupplier = new System.Windows.Forms.Button();
            this.buttonSuppliersDetails = new System.Windows.Forms.Button();
            this.buttonIngredientDetails = new System.Windows.Forms.Button();
            this.buttonNewIngredient = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCompanyPhone = new System.Windows.Forms.TextBox();
            this.labelCompanyPhone = new System.Windows.Forms.Label();
            this.textBoxCompanyAddress = new System.Windows.Forms.TextBox();
            this.labelCompanyAddress = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxCompanyCentre = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelCompanyCentre = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.groupBoxIngredients.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngredients
            // 
            this.groupBoxIngredients.Controls.Add(this.buttonNewSupplier);
            this.groupBoxIngredients.Controls.Add(this.buttonSuppliersDetails);
            this.groupBoxIngredients.Controls.Add(this.buttonIngredientDetails);
            this.groupBoxIngredients.Controls.Add(this.buttonNewIngredient);
            this.groupBoxIngredients.Location = new System.Drawing.Point(27, 218);
            this.groupBoxIngredients.Name = "groupBoxIngredients";
            this.groupBoxIngredients.Size = new System.Drawing.Size(478, 118);
            this.groupBoxIngredients.TabIndex = 2;
            this.groupBoxIngredients.TabStop = false;
            this.groupBoxIngredients.Text = "Ingredients";
            // 
            // buttonNewSupplier
            // 
            this.buttonNewSupplier.Location = new System.Drawing.Point(124, 28);
            this.buttonNewSupplier.Name = "buttonNewSupplier";
            this.buttonNewSupplier.Size = new System.Drawing.Size(75, 39);
            this.buttonNewSupplier.TabIndex = 3;
            this.buttonNewSupplier.Text = "New Supplier";
            this.buttonNewSupplier.UseVisualStyleBackColor = true;
            this.buttonNewSupplier.Click += new System.EventHandler(this.buttonNewSupplier_Click);
            // 
            // buttonSuppliersDetails
            // 
            this.buttonSuppliersDetails.Location = new System.Drawing.Point(124, 73);
            this.buttonSuppliersDetails.Name = "buttonSuppliersDetails";
            this.buttonSuppliersDetails.Size = new System.Drawing.Size(75, 39);
            this.buttonSuppliersDetails.TabIndex = 2;
            this.buttonSuppliersDetails.Text = "Suppliers Details";
            this.buttonSuppliersDetails.UseVisualStyleBackColor = true;
            this.buttonSuppliersDetails.Click += new System.EventHandler(this.buttonSuppliersDetails_Click);
            // 
            // buttonIngredientDetails
            // 
            this.buttonIngredientDetails.Location = new System.Drawing.Point(25, 73);
            this.buttonIngredientDetails.Name = "buttonIngredientDetails";
            this.buttonIngredientDetails.Size = new System.Drawing.Size(75, 39);
            this.buttonIngredientDetails.TabIndex = 1;
            this.buttonIngredientDetails.Text = "Ingredients details";
            this.buttonIngredientDetails.UseVisualStyleBackColor = true;
            this.buttonIngredientDetails.Click += new System.EventHandler(this.buttonIngredientDetails_Click);
            // 
            // buttonNewIngredient
            // 
            this.buttonNewIngredient.Location = new System.Drawing.Point(25, 28);
            this.buttonNewIngredient.Name = "buttonNewIngredient";
            this.buttonNewIngredient.Size = new System.Drawing.Size(75, 39);
            this.buttonNewIngredient.TabIndex = 0;
            this.buttonNewIngredient.Text = "New ingredient";
            this.buttonNewIngredient.UseVisualStyleBackColor = true;
            this.buttonNewIngredient.Click += new System.EventHandler(this.buttonNewIngredient_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.buttonNewProduct);
            this.groupBoxProducts.Location = new System.Drawing.Point(27, 358);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(478, 114);
            this.groupBoxProducts.TabIndex = 3;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Products";
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(25, 29);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(75, 35);
            this.buttonNewProduct.TabIndex = 0;
            this.buttonNewProduct.Text = "New Product";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCancel);
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.textBoxCompanyPhone);
            this.groupBox3.Controls.Add(this.labelCompanyPhone);
            this.groupBox3.Controls.Add(this.textBoxCompanyAddress);
            this.groupBox3.Controls.Add(this.labelCompanyAddress);
            this.groupBox3.Controls.Add(this.buttonEdit);
            this.groupBox3.Controls.Add(this.textBoxCompanyCentre);
            this.groupBox3.Controls.Add(this.textBoxCompanyName);
            this.groupBox3.Controls.Add(this.labelCompanyCentre);
            this.groupBox3.Controls.Add(this.labelCompanyName);
            this.groupBox3.Location = new System.Drawing.Point(27, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 179);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company Details";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(397, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(277, 134);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCompanyPhone
            // 
            this.textBoxCompanyPhone.Location = new System.Drawing.Point(124, 71);
            this.textBoxCompanyPhone.Name = "textBoxCompanyPhone";
            this.textBoxCompanyPhone.Size = new System.Drawing.Size(282, 20);
            this.textBoxCompanyPhone.TabIndex = 12;
            this.textBoxCompanyPhone.TabStop = false;
            // 
            // labelCompanyPhone
            // 
            this.labelCompanyPhone.AutoSize = true;
            this.labelCompanyPhone.Location = new System.Drawing.Point(17, 75);
            this.labelCompanyPhone.Name = "labelCompanyPhone";
            this.labelCompanyPhone.Size = new System.Drawing.Size(76, 13);
            this.labelCompanyPhone.TabIndex = 11;
            this.labelCompanyPhone.Text = "Phone number";
            // 
            // textBoxCompanyAddress
            // 
            this.textBoxCompanyAddress.Location = new System.Drawing.Point(124, 45);
            this.textBoxCompanyAddress.Multiline = true;
            this.textBoxCompanyAddress.Name = "textBoxCompanyAddress";
            this.textBoxCompanyAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCompanyAddress.Size = new System.Drawing.Size(282, 20);
            this.textBoxCompanyAddress.TabIndex = 8;
            this.textBoxCompanyAddress.TabStop = false;
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.AutoSize = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(17, 49);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(39, 13);
            this.labelCompanyAddress.TabIndex = 7;
            this.labelCompanyAddress.Text = "Adress";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(397, 134);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxCompanyCentre
            // 
            this.textBoxCompanyCentre.Location = new System.Drawing.Point(124, 97);
            this.textBoxCompanyCentre.Name = "textBoxCompanyCentre";
            this.textBoxCompanyCentre.Size = new System.Drawing.Size(282, 20);
            this.textBoxCompanyCentre.TabIndex = 4;
            this.textBoxCompanyCentre.TabStop = false;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(124, 17);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(282, 20);
            this.textBoxCompanyName.TabIndex = 3;
            this.textBoxCompanyName.TabStop = false;
            // 
            // labelCompanyCentre
            // 
            this.labelCompanyCentre.AutoSize = true;
            this.labelCompanyCentre.Location = new System.Drawing.Point(17, 102);
            this.labelCompanyCentre.Name = "labelCompanyCentre";
            this.labelCompanyCentre.Size = new System.Drawing.Size(38, 13);
            this.labelCompanyCentre.TabIndex = 1;
            this.labelCompanyCentre.Text = "Centre";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(17, 21);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Company Name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxIngredients);
            this.Name = "FormMain";
            this.Text = "Main ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxIngredients.ResumeLayout(false);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngredients;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCompanyCentre;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyCentre;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonNewSupplier;
        private System.Windows.Forms.Button buttonSuppliersDetails;
        private System.Windows.Forms.Button buttonIngredientDetails;
        private System.Windows.Forms.Button buttonNewIngredient;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.TextBox textBoxCompanyPhone;
        private System.Windows.Forms.Label labelCompanyPhone;
        private System.Windows.Forms.TextBox textBoxCompanyAddress;
        private System.Windows.Forms.Label labelCompanyAddress;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}