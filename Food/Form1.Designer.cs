namespace Food
{
    partial class MainForm
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
            this.AddNewMeal = new System.Windows.Forms.Button();
            this.dataGridViewForMeals = new System.Windows.Forms.DataGridView();
            this.listBoxForIngredients = new System.Windows.Forms.ListBox();
            this.listBoxForDates = new System.Windows.Forms.ListBox();
            this.buttonForRefresh = new System.Windows.Forms.Button();
            this.buttonForNewSymptom = new System.Windows.Forms.Button();
            this.listBoxForSymptoms = new System.Windows.Forms.ListBox();
            this.labelForIngredients = new System.Windows.Forms.Label();
            this.labelForDates = new System.Windows.Forms.Label();
            this.labelForSymptoms = new System.Windows.Forms.Label();
            this.dataGridViewForSymptoms = new System.Windows.Forms.DataGridView();
            this.listBoxCountMeals = new System.Windows.Forms.ListBox();
            this.listBoxCountIngredients = new System.Windows.Forms.ListBox();
            this.labelForCounts = new System.Windows.Forms.Label();
            this.labelForMealGrid = new System.Windows.Forms.Label();
            this.labelForIngredientGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForSymptoms)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewMeal
            // 
            this.AddNewMeal.Location = new System.Drawing.Point(589, 389);
            this.AddNewMeal.Name = "AddNewMeal";
            this.AddNewMeal.Size = new System.Drawing.Size(130, 27);
            this.AddNewMeal.TabIndex = 0;
            this.AddNewMeal.Text = "Add meal";
            this.AddNewMeal.UseVisualStyleBackColor = true;
            this.AddNewMeal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewForMeals
            // 
            this.dataGridViewForMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForMeals.Location = new System.Drawing.Point(13, 32);
            this.dataGridViewForMeals.Name = "dataGridViewForMeals";
            this.dataGridViewForMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForMeals.Size = new System.Drawing.Size(549, 221);
            this.dataGridViewForMeals.TabIndex = 4;
            this.dataGridViewForMeals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForMeals_CellClick);
            // 
            // listBoxForIngredients
            // 
            this.listBoxForIngredients.FormattingEnabled = true;
            this.listBoxForIngredients.Location = new System.Drawing.Point(12, 275);
            this.listBoxForIngredients.Name = "listBoxForIngredients";
            this.listBoxForIngredients.Size = new System.Drawing.Size(172, 173);
            this.listBoxForIngredients.TabIndex = 5;
            // 
            // listBoxForDates
            // 
            this.listBoxForDates.FormattingEnabled = true;
            this.listBoxForDates.Location = new System.Drawing.Point(190, 275);
            this.listBoxForDates.Name = "listBoxForDates";
            this.listBoxForDates.Size = new System.Drawing.Size(179, 173);
            this.listBoxForDates.TabIndex = 6;
            // 
            // buttonForRefresh
            // 
            this.buttonForRefresh.Location = new System.Drawing.Point(725, 389);
            this.buttonForRefresh.Name = "buttonForRefresh";
            this.buttonForRefresh.Size = new System.Drawing.Size(86, 59);
            this.buttonForRefresh.TabIndex = 7;
            this.buttonForRefresh.Text = "Refresh";
            this.buttonForRefresh.UseVisualStyleBackColor = true;
            this.buttonForRefresh.Click += new System.EventHandler(this.buttonForRefresh_Click);
            // 
            // buttonForNewSymptom
            // 
            this.buttonForNewSymptom.Location = new System.Drawing.Point(589, 422);
            this.buttonForNewSymptom.Name = "buttonForNewSymptom";
            this.buttonForNewSymptom.Size = new System.Drawing.Size(130, 26);
            this.buttonForNewSymptom.TabIndex = 9;
            this.buttonForNewSymptom.Text = "Add symptom";
            this.buttonForNewSymptom.UseVisualStyleBackColor = true;
            this.buttonForNewSymptom.Click += new System.EventHandler(this.buttonForNewSymptom_Click);
            // 
            // listBoxForSymptoms
            // 
            this.listBoxForSymptoms.FormattingEnabled = true;
            this.listBoxForSymptoms.Location = new System.Drawing.Point(375, 275);
            this.listBoxForSymptoms.Name = "listBoxForSymptoms";
            this.listBoxForSymptoms.Size = new System.Drawing.Size(186, 173);
            this.listBoxForSymptoms.TabIndex = 10;
            // 
            // labelForIngredients
            // 
            this.labelForIngredients.AutoSize = true;
            this.labelForIngredients.Location = new System.Drawing.Point(13, 256);
            this.labelForIngredients.Name = "labelForIngredients";
            this.labelForIngredients.Size = new System.Drawing.Size(59, 13);
            this.labelForIngredients.TabIndex = 11;
            this.labelForIngredients.Text = "Ingredients";
            // 
            // labelForDates
            // 
            this.labelForDates.AutoSize = true;
            this.labelForDates.Location = new System.Drawing.Point(191, 256);
            this.labelForDates.Name = "labelForDates";
            this.labelForDates.Size = new System.Drawing.Size(35, 13);
            this.labelForDates.TabIndex = 12;
            this.labelForDates.Text = "Dates";
            // 
            // labelForSymptoms
            // 
            this.labelForSymptoms.AutoSize = true;
            this.labelForSymptoms.Location = new System.Drawing.Point(375, 256);
            this.labelForSymptoms.Name = "labelForSymptoms";
            this.labelForSymptoms.Size = new System.Drawing.Size(55, 13);
            this.labelForSymptoms.TabIndex = 13;
            this.labelForSymptoms.Text = "Symptoms";
            // 
            // dataGridViewForSymptoms
            // 
            this.dataGridViewForSymptoms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForSymptoms.Location = new System.Drawing.Point(568, 32);
            this.dataGridViewForSymptoms.Name = "dataGridViewForSymptoms";
            this.dataGridViewForSymptoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForSymptoms.Size = new System.Drawing.Size(240, 162);
            this.dataGridViewForSymptoms.TabIndex = 14;
            this.dataGridViewForSymptoms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForSymptoms_CellClick);
            // 
            // listBoxCountMeals
            // 
            this.listBoxCountMeals.FormattingEnabled = true;
            this.listBoxCountMeals.Location = new System.Drawing.Point(571, 213);
            this.listBoxCountMeals.Name = "listBoxCountMeals";
            this.listBoxCountMeals.Size = new System.Drawing.Size(240, 82);
            this.listBoxCountMeals.TabIndex = 15;
            // 
            // listBoxCountIngredients
            // 
            this.listBoxCountIngredients.FormattingEnabled = true;
            this.listBoxCountIngredients.Location = new System.Drawing.Point(571, 301);
            this.listBoxCountIngredients.Name = "listBoxCountIngredients";
            this.listBoxCountIngredients.Size = new System.Drawing.Size(240, 82);
            this.listBoxCountIngredients.TabIndex = 17;
            // 
            // labelForCounts
            // 
            this.labelForCounts.AutoSize = true;
            this.labelForCounts.Location = new System.Drawing.Point(568, 197);
            this.labelForCounts.Name = "labelForCounts";
            this.labelForCounts.Size = new System.Drawing.Size(179, 13);
            this.labelForCounts.TabIndex = 18;
            this.labelForCounts.Text = "Symptom appeard after [Item, Count]";
            // 
            // labelForMealGrid
            // 
            this.labelForMealGrid.AutoSize = true;
            this.labelForMealGrid.Location = new System.Drawing.Point(13, 9);
            this.labelForMealGrid.Name = "labelForMealGrid";
            this.labelForMealGrid.Size = new System.Drawing.Size(45, 13);
            this.labelForMealGrid.TabIndex = 19;
            this.labelForMealGrid.Text = "Meal list";
            // 
            // labelForIngredientGrid
            // 
            this.labelForIngredientGrid.AutoSize = true;
            this.labelForIngredientGrid.Location = new System.Drawing.Point(571, 13);
            this.labelForIngredientGrid.Name = "labelForIngredientGrid";
            this.labelForIngredientGrid.Size = new System.Drawing.Size(69, 13);
            this.labelForIngredientGrid.TabIndex = 20;
            this.labelForIngredientGrid.Text = "Ingredient list";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.labelForIngredientGrid);
            this.Controls.Add(this.labelForMealGrid);
            this.Controls.Add(this.labelForCounts);
            this.Controls.Add(this.listBoxCountIngredients);
            this.Controls.Add(this.listBoxCountMeals);
            this.Controls.Add(this.dataGridViewForSymptoms);
            this.Controls.Add(this.labelForSymptoms);
            this.Controls.Add(this.labelForDates);
            this.Controls.Add(this.labelForIngredients);
            this.Controls.Add(this.listBoxForSymptoms);
            this.Controls.Add(this.buttonForNewSymptom);
            this.Controls.Add(this.buttonForRefresh);
            this.Controls.Add(this.listBoxForDates);
            this.Controls.Add(this.listBoxForIngredients);
            this.Controls.Add(this.dataGridViewForMeals);
            this.Controls.Add(this.AddNewMeal);
            this.Name = "MainForm";
            this.Text = "Sraosm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForSymptoms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMeal;
        private System.Windows.Forms.DataGridView dataGridViewForMeals;
        private System.Windows.Forms.ListBox listBoxForIngredients;
        private System.Windows.Forms.ListBox listBoxForDates;
        private System.Windows.Forms.Button buttonForRefresh;
        private System.Windows.Forms.Button buttonForNewSymptom;
        private System.Windows.Forms.ListBox listBoxForSymptoms;
        private System.Windows.Forms.Label labelForIngredients;
        private System.Windows.Forms.Label labelForDates;
        private System.Windows.Forms.Label labelForSymptoms;
        private System.Windows.Forms.DataGridView dataGridViewForSymptoms;
        private System.Windows.Forms.ListBox listBoxCountMeals;
        private System.Windows.Forms.ListBox listBoxCountIngredients;
        private System.Windows.Forms.Label labelForCounts;
        private System.Windows.Forms.Label labelForMealGrid;
        private System.Windows.Forms.Label labelForIngredientGrid;
    }
}

