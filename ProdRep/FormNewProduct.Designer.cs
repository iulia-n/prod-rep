namespace ProdRep
{
    partial class FormNewProduct
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.groupBoxRecipe = new System.Windows.Forms.GroupBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.radioButtonRecipe2 = new System.Windows.Forms.RadioButton();
            this.radioButtonRecipe1 = new System.Windows.Forms.RadioButton();
            this.dataGridViewRecipe = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UoMCantitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUoM = new System.Windows.Forms.Label();
            this.textBoxUoM = new System.Windows.Forms.TextBox();
            this.groupBoxRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(26, 30);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 13);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(152, 27);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(163, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // groupBoxRecipe
            // 
            this.groupBoxRecipe.Controls.Add(this.comboBoxProducts);
            this.groupBoxRecipe.Controls.Add(this.labelProduct);
            this.groupBoxRecipe.Controls.Add(this.radioButtonRecipe2);
            this.groupBoxRecipe.Controls.Add(this.radioButtonRecipe1);
            this.groupBoxRecipe.Controls.Add(this.dataGridViewRecipe);
            this.groupBoxRecipe.Location = new System.Drawing.Point(29, 104);
            this.groupBoxRecipe.Name = "groupBoxRecipe";
            this.groupBoxRecipe.Size = new System.Drawing.Size(383, 268);
            this.groupBoxRecipe.TabIndex = 2;
            this.groupBoxRecipe.TabStop = false;
            this.groupBoxRecipe.Text = "Retetar";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(123, 63);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.TabIndex = 4;
            this.comboBoxProducts.Visible = false;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(62, 66);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(50, 13);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "Product: ";
            this.labelProduct.Visible = false;
            // 
            // radioButtonRecipe2
            // 
            this.radioButtonRecipe2.AutoSize = true;
            this.radioButtonRecipe2.Location = new System.Drawing.Point(24, 42);
            this.radioButtonRecipe2.Name = "radioButtonRecipe2";
            this.radioButtonRecipe2.Size = new System.Drawing.Size(166, 17);
            this.radioButtonRecipe2.TabIndex = 2;
            this.radioButtonRecipe2.Text = "Load another product\'s recipe";
            this.radioButtonRecipe2.UseVisualStyleBackColor = true;
            this.radioButtonRecipe2.CheckedChanged += new System.EventHandler(this.radioButtonRecipe2_CheckedChanged);
            // 
            // radioButtonRecipe1
            // 
            this.radioButtonRecipe1.AutoSize = true;
            this.radioButtonRecipe1.Checked = true;
            this.radioButtonRecipe1.Location = new System.Drawing.Point(24, 19);
            this.radioButtonRecipe1.Name = "radioButtonRecipe1";
            this.radioButtonRecipe1.Size = new System.Drawing.Size(84, 17);
            this.radioButtonRecipe1.TabIndex = 1;
            this.radioButtonRecipe1.TabStop = true;
            this.radioButtonRecipe1.Text = "New Recipe";
            this.radioButtonRecipe1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecipe
            // 
            this.dataGridViewRecipe.AllowUserToAddRows = false;
            this.dataGridViewRecipe.AllowUserToDeleteRows = false;
            this.dataGridViewRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IngredientColumn,
            this.QuantityColumn,
            this.UoMCantitateColumn});
            this.dataGridViewRecipe.Location = new System.Drawing.Point(6, 94);
            this.dataGridViewRecipe.Name = "dataGridViewRecipe";
            this.dataGridViewRecipe.Size = new System.Drawing.Size(344, 168);
            this.dataGridViewRecipe.TabIndex = 0;
            this.dataGridViewRecipe.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewRecipe_CellBeginEdit);
            this.dataGridViewRecipe.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipe_CellEndEdit);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IngredientColumn
            // 
            this.IngredientColumn.HeaderText = "Ingredient";
            this.IngredientColumn.Name = "IngredientColumn";
            this.IngredientColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // UoMCantitateColumn
            // 
            this.UoMCantitateColumn.HeaderText = "UoM";
            this.UoMCantitateColumn.Name = "UoMCantitateColumn";
            this.UoMCantitateColumn.ReadOnly = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(317, 378);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(410, 378);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUoM
            // 
            this.labelUoM.AutoSize = true;
            this.labelUoM.Location = new System.Drawing.Point(29, 62);
            this.labelUoM.Name = "labelUoM";
            this.labelUoM.Size = new System.Drawing.Size(108, 13);
            this.labelUoM.TabIndex = 5;
            this.labelUoM.Text = "Unit of Measurement:";
            // 
            // textBoxUoM
            // 
            this.textBoxUoM.Location = new System.Drawing.Point(152, 54);
            this.textBoxUoM.Name = "textBoxUoM";
            this.textBoxUoM.Size = new System.Drawing.Size(163, 20);
            this.textBoxUoM.TabIndex = 6;
            // 
            // FormNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(497, 421);
            this.Controls.Add(this.textBoxUoM);
            this.Controls.Add(this.labelUoM);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxRecipe);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Name = "FormNewProduct";
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.FormNewProduct_Load);
            this.groupBoxRecipe.ResumeLayout(false);
            this.groupBoxRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.GroupBox groupBoxRecipe;
        private System.Windows.Forms.DataGridView dataGridViewRecipe;
        private System.Windows.Forms.RadioButton radioButtonRecipe2;
        private System.Windows.Forms.RadioButton radioButtonRecipe1;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUoM;
        private System.Windows.Forms.TextBox textBoxUoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UoMCantitateColumn;
    }
}