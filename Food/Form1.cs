using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// MEMBER VARIABLES
        /// </summary>
        private Database1Entities dbde = new Database1Entities();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// OnLoad, Do this
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //add orderby date descending
            dataGridViewForMeals.DataSource = dbde.Meal.ToList();
            dataGridViewForMeals.Columns[0].Visible = false;

            //add orderby date descending
            dataGridViewForSymptoms.DataSource = dbde.Symptoms.ToList();
            dataGridViewForSymptoms.Columns[0].Visible = false;


            listBoxForIngredients.DisplayMember = "Name";
            listBoxForDates.DisplayMember = "Date";
            listBoxForSymptoms.DisplayMember = "Description";
            listBoxCountMeals.DisplayMember = "Name";
        }

        /// <summary>
        /// HELPERS
        /// </summary>
        private void UpdateForm()
        {
            this.Refresh();
            Refresh();
            this.Hide();
            MainForm s = new MainForm();
            s.Show();
        }

        private void updateIngredients()
        {
            listBoxForIngredients.Items.Clear();

            int mealId = (int)dataGridViewForMeals.SelectedRows[0].Cells[0].Value;
            var meal = from m in dbde.Meal
                       where m.Id == mealId
                       select m;

            foreach (Meal m in meal)
            {
                var ingredientsInMeal = m.Ingredients;
                foreach (Ingredients i in ingredientsInMeal)
                {
                    listBoxForIngredients.Items.Add(i);
                }
            }
        }

        private void updateDates()
        {
            listBoxForDates.Items.Clear();

            var mealName = dataGridViewForMeals.SelectedRows[0].Cells[1].Value.ToString();
            var meals = from m in dbde.Meal
                        where m.Name == mealName
                        select m;

            foreach (Meal m in meals)
            {
                listBoxForDates.Items.Add(m);
            }
        }

        private void updateSymptoms()
        {
            listBoxForSymptoms.Items.Clear();

            var mealName = dataGridViewForMeals.SelectedRows[0].Cells[1].Value.ToString();
            var meals = from m in dbde.Meal
                        where m.Name == mealName
                        select m;

            foreach (Meal m in meals)
            {

                DateTime date = (DateTime)m.Date;

                var symptoms = from s in dbde.Symptoms
                               where (s.Date.Value.Day - date.Day < 2) && (s.Date.Value.Day - date.Day >= 0) && (s.Date.Value.Hour - date.Hour >= 0) && (s.Date.Value.Minute - date.Minute >= 0)
                               select s;

                foreach (Symptoms s in symptoms)
                {
                    listBoxForSymptoms.Items.Add(s.Date - date);
                    listBoxForSymptoms.Items.Add(s);
                }
            }
        }

        private void updateMealCounts()
        {
            listBoxCountMeals.Items.Clear();

            var dict = new Dictionary<string, int>();

            var symptomName = dataGridViewForSymptoms.SelectedRows[0].Cells[1].Value.ToString();
            var symptoms = from s in dbde.Symptoms
                           where s.Description == symptomName
                           select s;

            foreach (Symptoms s in symptoms)
            {
                DateTime date = (DateTime)s.Date;

                var meals = from m in dbde.Meal
                               where (date.Day - m.Date.Value.Day < 2) && (date.Hour - m.Date.Value.Hour >= 0) && (date.Minute - m.Date.Value.Minute >= 0)
                               select m;

                foreach (var m in meals)
                {
                    if (!dict.ContainsKey(m.Name))
                    {
                        dict.Add(m.Name, 1);
                    }
                    else
                    {
                        dict[m.Name] = dict[m.Name] + 1;
                    }
                }
            }
            foreach (var item in dict)
            {
                listBoxCountMeals.Items.Add(item);
            }
        }

        private void updateIngredientCounts()
        {
            listBoxCountIngredients.Items.Clear();

            var dict = new Dictionary<string, int>();

            var symptomName = dataGridViewForSymptoms.SelectedRows[0].Cells[1].Value.ToString();
            var symptoms = from s in dbde.Symptoms
                           where s.Description == symptomName
                           select s;

            foreach (Symptoms s in symptoms)
            {
                DateTime date = (DateTime)s.Date;

                var meals = from m in dbde.Meal
                            where (date.Day - m.Date.Value.Day < 2) && (date.Hour - m.Date.Value.Hour >= 0) && (date.Minute - m.Date.Value.Minute >= 0)
                            select m;

                foreach (Meal m in meals)
                {
                    var ingredientsInMeal = m.Ingredients;
                    foreach (Ingredients i in ingredientsInMeal)
                    {
                        if (!dict.ContainsKey(i.Name))
                        {
                            dict.Add(i.Name, 1);
                        }
                        else
                        {
                            dict[i.Name] = dict[i.Name] + 1;
                        }
                    }
                }

            }
            foreach (var item in dict)
            {
                listBoxCountIngredients.Items.Add(item);
            }
        }

        /// <summary>
        ///  EVENTS
        /// </summary>
        private void dataGridViewForMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateIngredients();
            updateDates();
            updateSymptoms();
        }

        private void dataGridViewForSymptoms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateMealCounts();
            updateIngredientCounts();
        }

        /// <summary>
        /// BUTTON EVENTS
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            AddMealForm amf = new AddMealForm();
            amf.Show();
        }

        private void buttonForRefresh_Click(object sender, EventArgs e)
        {
            this.UpdateForm();
        }

        private void buttonForNewSymptom_Click(object sender, EventArgs e)
        {
            AddNewSymptom ans = new AddNewSymptom();
            ans.Show();
        }

    }
}
