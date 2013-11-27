namespace ProdRep
{
    partial class FormIngredientDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIngredients = new System.Windows.Forms.ComboBox();
            this.groupBoxIngredientDetails = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxIngredientUoM = new System.Windows.Forms.TextBox();
            this.textBoxIngredientName = new System.Windows.Forms.TextBox();
            this.labelIngredientUoM = new System.Windows.Forms.Label();
            this.labelIngredientName = new System.Windows.Forms.Label();
            this.groupBoxIngredientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient:";
            // 
            // comboBoxIngredients
            // 
            this.comboBoxIngredients.DropDownHeight = 60;
            this.comboBoxIngredients.FormattingEnabled = true;
            this.comboBoxIngredients.IntegralHeight = false;
            this.comboBoxIngredients.Location = new System.Drawing.Point(94, 31);
            this.comboBoxIngredients.MaxDropDownItems = 3;
            this.comboBoxIngredients.Name = "comboBoxIngredients";
            this.comboBoxIngredients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIngredients.TabIndex = 1;
            this.comboBoxIngredients.SelectionChangeCommitted += new System.EventHandler(this.comboBoxIngredients_SelectionChangeCommitted);
            // 
            // groupBoxIngredientDetails
            // 
            this.groupBoxIngredientDetails.Controls.Add(this.buttonCancel);
            this.groupBoxIngredientDetails.Controls.Add(this.buttonSave);
            this.groupBoxIngredientDetails.Controls.Add(this.buttonEdit);
            this.groupBoxIngredientDetails.Controls.Add(this.textBoxIngredientUoM);
            this.groupBoxIngredientDetails.Controls.Add(this.textBoxIngredientName);
            this.groupBoxIngredientDetails.Controls.Add(this.labelIngredientUoM);
            this.groupBoxIngredientDetails.Controls.Add(this.labelIngredientName);
            this.groupBoxIngredientDetails.Location = new System.Drawing.Point(32, 86);
            this.groupBoxIngredientDetails.Name = "groupBoxIngredientDetails";
            this.groupBoxIngredientDetails.Size = new System.Drawing.Size(325, 138);
            this.groupBoxIngredientDetails.TabIndex = 2;
            this.groupBoxIngredientDetails.TabStop = false;
            this.groupBoxIngredientDetails.Text = "Details";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(222, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(116, 101);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(222, 100);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxIngredientUoM
            // 
            this.textBoxIngredientUoM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxIngredientUoM.Location = new System.Drawing.Point(91, 66);
            this.textBoxIngredientUoM.Name = "textBoxIngredientUoM";
            this.textBoxIngredientUoM.ReadOnly = true;
            this.textBoxIngredientUoM.Size = new System.Drawing.Size(100, 20);
            this.textBoxIngredientUoM.TabIndex = 10;
            // 
            // textBoxIngredientName
            // 
            this.textBoxIngredientName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxIngredientName.Location = new System.Drawing.Point(91, 35);
            this.textBoxIngredientName.Name = "textBoxIngredientName";
            this.textBoxIngredientName.ReadOnly = true;
            this.textBoxIngredientName.Size = new System.Drawing.Size(100, 20);
            this.textBoxIngredientName.TabIndex = 9;
            // 
            // labelIngredientUoM
            // 
            this.labelIngredientUoM.AutoSize = true;
            this.labelIngredientUoM.Location = new System.Drawing.Point(25, 69);
            this.labelIngredientUoM.Name = "labelIngredientUoM";
            this.labelIngredientUoM.Size = new System.Drawing.Size(33, 13);
            this.labelIngredientUoM.TabIndex = 7;
            this.labelIngredientUoM.Text = "UoM:";
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Location = new System.Drawing.Point(25, 38);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(38, 13);
            this.labelIngredientName.TabIndex = 6;
            this.labelIngredientName.Text = "Name:";
            // 
            // FormIngredientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 238);
            this.Controls.Add(this.groupBoxIngredientDetails);
            this.Controls.Add(this.comboBoxIngredients);
            this.Controls.Add(this.label1);
            this.Name = "FormIngredientDetails";
            this.Text = "Ingredients Details";
            this.Load += new System.EventHandler(this.FormIngredientDetails_Load);
            this.groupBoxIngredientDetails.ResumeLayout(false);
            this.groupBoxIngredientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIngredients;
        private System.Windows.Forms.GroupBox groupBoxIngredientDetails;
        private System.Windows.Forms.TextBox textBoxIngredientUoM;
        private System.Windows.Forms.TextBox textBoxIngredientName;
        private System.Windows.Forms.Label labelIngredientUoM;
        private System.Windows.Forms.Label labelIngredientName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
    }
}