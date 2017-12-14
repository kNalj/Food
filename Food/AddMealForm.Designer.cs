namespace Food
{
    partial class AddMealForm
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
            this.LabelForNewMeal = new System.Windows.Forms.Label();
            this.textBoxMealName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.listBoxCurrentIngredients = new System.Windows.Forms.ListBox();
            this.listBoxExistingIngredients = new System.Windows.Forms.ListBox();
            this.buttonForAddingIngredients = new System.Windows.Forms.Button();
            this.buttonForRemovingIngredients = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxForExistingMeals = new System.Windows.Forms.ComboBox();
            this.LabelForExistingMeals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelForNewMeal
            // 
            this.LabelForNewMeal.AutoSize = true;
            this.LabelForNewMeal.Location = new System.Drawing.Point(36, 67);
            this.LabelForNewMeal.Name = "LabelForNewMeal";
            this.LabelForNewMeal.Size = new System.Drawing.Size(61, 13);
            this.LabelForNewMeal.TabIndex = 0;
            this.LabelForNewMeal.Text = "Meal Name";
            // 
            // textBoxMealName
            // 
            this.textBoxMealName.Location = new System.Drawing.Point(40, 83);
            this.textBoxMealName.Name = "textBoxMealName";
            this.textBoxMealName.Size = new System.Drawing.Size(122, 20);
            this.textBoxMealName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 94);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(285, 239);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(152, 23);
            this.AddIngredientButton.TabIndex = 5;
            this.AddIngredientButton.Text = "Add Ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // listBoxCurrentIngredients
            // 
            this.listBoxCurrentIngredients.FormattingEnabled = true;
            this.listBoxCurrentIngredients.Location = new System.Drawing.Point(179, 16);
            this.listBoxCurrentIngredients.Name = "listBoxCurrentIngredients";
            this.listBoxCurrentIngredients.Size = new System.Drawing.Size(120, 199);
            this.listBoxCurrentIngredients.TabIndex = 6;
            this.listBoxCurrentIngredients.SelectedIndexChanged += new System.EventHandler(this.listBoxCurrentIngredients_SelectedIndexChanged);
            // 
            // listBoxExistingIngredients
            // 
            this.listBoxExistingIngredients.FormattingEnabled = true;
            this.listBoxExistingIngredients.Location = new System.Drawing.Point(349, 16);
            this.listBoxExistingIngredients.Name = "listBoxExistingIngredients";
            this.listBoxExistingIngredients.Size = new System.Drawing.Size(116, 199);
            this.listBoxExistingIngredients.TabIndex = 7;
            this.listBoxExistingIngredients.SelectedIndexChanged += new System.EventHandler(this.listBoxExistingIngredients_SelectedIndexChanged);
            // 
            // buttonForAddingIngredients
            // 
            this.buttonForAddingIngredients.Location = new System.Drawing.Point(305, 83);
            this.buttonForAddingIngredients.Name = "buttonForAddingIngredients";
            this.buttonForAddingIngredients.Size = new System.Drawing.Size(38, 23);
            this.buttonForAddingIngredients.TabIndex = 8;
            this.buttonForAddingIngredients.Text = "<";
            this.buttonForAddingIngredients.UseVisualStyleBackColor = true;
            this.buttonForAddingIngredients.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonForRemovingIngredients
            // 
            this.buttonForRemovingIngredients.Location = new System.Drawing.Point(305, 129);
            this.buttonForRemovingIngredients.Name = "buttonForRemovingIngredients";
            this.buttonForRemovingIngredients.Size = new System.Drawing.Size(38, 23);
            this.buttonForRemovingIngredients.TabIndex = 9;
            this.buttonForRemovingIngredients.Text = ">";
            this.buttonForRemovingIngredients.UseVisualStyleBackColor = true;
            this.buttonForRemovingIngredients.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxForExistingMeals
            // 
            this.comboBoxForExistingMeals.FormattingEnabled = true;
            this.comboBoxForExistingMeals.Location = new System.Drawing.Point(39, 31);
            this.comboBoxForExistingMeals.Name = "comboBoxForExistingMeals";
            this.comboBoxForExistingMeals.Size = new System.Drawing.Size(122, 21);
            this.comboBoxForExistingMeals.TabIndex = 11;
            this.comboBoxForExistingMeals.SelectedIndexChanged += new System.EventHandler(this.comboBoxForExistingMeals_SelectedIndexChanged);
            // 
            // LabelForExistingMeals
            // 
            this.LabelForExistingMeals.AutoSize = true;
            this.LabelForExistingMeals.Location = new System.Drawing.Point(37, 16);
            this.LabelForExistingMeals.Name = "LabelForExistingMeals";
            this.LabelForExistingMeals.Size = new System.Drawing.Size(62, 13);
            this.LabelForExistingMeals.TabIndex = 12;
            this.LabelForExistingMeals.Text = "Select meal";
            // 
            // AddMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 319);
            this.Controls.Add(this.LabelForExistingMeals);
            this.Controls.Add(this.comboBoxForExistingMeals);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonForRemovingIngredients);
            this.Controls.Add(this.buttonForAddingIngredients);
            this.Controls.Add(this.listBoxExistingIngredients);
            this.Controls.Add(this.listBoxCurrentIngredients);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMealName);
            this.Controls.Add(this.LabelForNewMeal);
            this.Name = "AddMealForm";
            this.Text = "Add Meal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelForNewMeal;
        private System.Windows.Forms.TextBox textBoxMealName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.ListBox listBoxCurrentIngredients;
        private System.Windows.Forms.ListBox listBoxExistingIngredients;
        private System.Windows.Forms.Button buttonForAddingIngredients;
        private System.Windows.Forms.Button buttonForRemovingIngredients;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxForExistingMeals;
        private System.Windows.Forms.Label LabelForExistingMeals;
    }
}