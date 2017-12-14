namespace Food
{
    partial class AddNewSymptom
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
            this.buttonForSavingSymptom = new System.Windows.Forms.Button();
            this.comboBoxForSymptoms = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerSymptom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonForSavingSymptom
            // 
            this.buttonForSavingSymptom.Location = new System.Drawing.Point(88, 135);
            this.buttonForSavingSymptom.Name = "buttonForSavingSymptom";
            this.buttonForSavingSymptom.Size = new System.Drawing.Size(99, 54);
            this.buttonForSavingSymptom.TabIndex = 1;
            this.buttonForSavingSymptom.Text = "Save";
            this.buttonForSavingSymptom.UseVisualStyleBackColor = true;
            this.buttonForSavingSymptom.Click += new System.EventHandler(this.buttonForSavingSymptom_Click);
            // 
            // comboBoxForSymptoms
            // 
            this.comboBoxForSymptoms.FormattingEnabled = true;
            this.comboBoxForSymptoms.Location = new System.Drawing.Point(41, 28);
            this.comboBoxForSymptoms.Name = "comboBoxForSymptoms";
            this.comboBoxForSymptoms.Size = new System.Drawing.Size(202, 21);
            this.comboBoxForSymptoms.TabIndex = 2;
            this.comboBoxForSymptoms.SelectedIndexChanged += new System.EventHandler(this.comboBoxForSymptoms_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePickerSymptom
            // 
            this.dateTimePickerSymptom.Location = new System.Drawing.Point(43, 81);
            this.dateTimePickerSymptom.Name = "dateTimePickerSymptom";
            this.dateTimePickerSymptom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSymptom.TabIndex = 5;
            // 
            // AddNewSymptom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.dateTimePickerSymptom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxForSymptoms);
            this.Controls.Add(this.buttonForSavingSymptom);
            this.Name = "AddNewSymptom";
            this.Text = "AddNewSymptom";
            this.Load += new System.EventHandler(this.AddNewSymptom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForSavingSymptom;
        private System.Windows.Forms.ComboBox comboBoxForSymptoms;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSymptom;
    }
}