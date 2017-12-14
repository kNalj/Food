namespace Food
{
    partial class AddNewIngredientForm
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
            this.buttonSaveIngredient = new System.Windows.Forms.Button();
            this.LabelForIngrediantNameTextBox = new System.Windows.Forms.Label();
            this.textBoxForIngredientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveIngredient
            // 
            this.buttonSaveIngredient.Location = new System.Drawing.Point(97, 71);
            this.buttonSaveIngredient.Name = "buttonSaveIngredient";
            this.buttonSaveIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveIngredient.TabIndex = 0;
            this.buttonSaveIngredient.Text = "Save";
            this.buttonSaveIngredient.UseVisualStyleBackColor = true;
            this.buttonSaveIngredient.Click += new System.EventHandler(this.buttonSaveIngredient_Click);
            // 
            // LabelForIngrediantNameTextBox
            // 
            this.LabelForIngrediantNameTextBox.AutoSize = true;
            this.LabelForIngrediantNameTextBox.Location = new System.Drawing.Point(12, 9);
            this.LabelForIngrediantNameTextBox.Name = "LabelForIngrediantNameTextBox";
            this.LabelForIngrediantNameTextBox.Size = new System.Drawing.Size(35, 13);
            this.LabelForIngrediantNameTextBox.TabIndex = 1;
            this.LabelForIngrediantNameTextBox.Text = "Name";
            // 
            // textBoxForIngredientName
            // 
            this.textBoxForIngredientName.Location = new System.Drawing.Point(12, 25);
            this.textBoxForIngredientName.Name = "textBoxForIngredientName";
            this.textBoxForIngredientName.Size = new System.Drawing.Size(248, 20);
            this.textBoxForIngredientName.TabIndex = 2;
            // 
            // AddNewIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.textBoxForIngredientName);
            this.Controls.Add(this.LabelForIngrediantNameTextBox);
            this.Controls.Add(this.buttonSaveIngredient);
            this.Name = "AddNewIngredientForm";
            this.Text = "AddNewIngredientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveIngredient;
        private System.Windows.Forms.Label LabelForIngrediantNameTextBox;
        private System.Windows.Forms.TextBox textBoxForIngredientName;
    }
}