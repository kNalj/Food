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
    public partial class AddMealForm : Form
    {

        /// <summary>
        /// MEMBER VARIABLES
        /// </summary>
        private Database1Entities dbde = new Database1Entities();
        private List<Ingredients> ingredients = new List<Ingredients>();
        private Ingredients selectedIngredient = null;
        private Ingredients removeIngredient = null;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public AddMealForm()
        {
            InitializeComponent();

            comboBoxForExistingMeals.DataSource = dbde.Meal.ToList();
            comboBoxForExistingMeals.DisplayMember = "Name";
            comboBoxForExistingMeals.ValueMember = "Id";

            listBoxExistingIngredients.DataSource = dbde.Ingredients.ToList();
            listBoxExistingIngredients.DisplayMember = "Name";
            listBoxExistingIngredients.ValueMember = "Id";

            listBoxCurrentIngredients.DisplayMember = "Name";
            listBoxCurrentIngredients.ValueMember = "Id";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.ShowUpDown = true;

        }

        /// <summary>
        /// HELPERS
        /// </summary>
        public void UpdateForm()
        {
            this.Refresh();
            Refresh();
            this.Hide();
            AddMealForm s = new AddMealForm();
            s.Show();
        }

        /// <summary>
        ///  BUTTON EVENTS
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {

            Meal meal = new Meal();
            meal.Name = textBoxMealName.Text;
            meal.Description = richTextBox1.Text;
            meal.Date = dateTimePicker1.Value;

            dbde.Meal.Add(meal);

            foreach (Ingredients i in ingredients)
            {
                meal.Ingredients.Add(i);
                i.Meal.Add(meal);
            }

            dbde.SaveChanges();
            MessageBox.Show("Saved");

            this.Close();   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCurrentIngredients.Items.Add(this.selectedIngredient);
            ingredients.Add(this.selectedIngredient);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxCurrentIngredients.Items.Remove(removeIngredient);
            ingredients.Remove(this.removeIngredient);
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            AddNewIngredientForm anif = new AddNewIngredientForm();
            anif.MyParent = this;
            //anif.GP = MyParent;
            anif.Show();
        }

        /// <summary>
        /// EVENTS
        /// </summary>
        private void listBoxExistingIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedIngredient = (Ingredients)listBoxExistingIngredients.SelectedItem;
        }

        private void listBoxCurrentIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.removeIngredient = (Ingredients)listBoxCurrentIngredients.SelectedItem;
        }

        private void comboBoxForExistingMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            Meal m = (Meal)comboBoxForExistingMeals.SelectedItem;

            this.textBoxMealName.Text = m.Name;
            this.richTextBox1.Text = m.Description;
            listBoxCurrentIngredients.Items.Clear();

            foreach (Ingredients i in m.Ingredients)
            {
                listBoxCurrentIngredients.Items.Add(i);
            }
        }
    }
}
