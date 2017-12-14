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
    public partial class AddNewIngredientForm : Form
    {

        /// <summary>
        /// MEMBER VARIABLES
        /// </summary>
        private Database1Entities dbde = new Database1Entities();
        public AddMealForm MyParent { get; set; }

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public AddNewIngredientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EVENTS
        /// </summary>
        private void buttonSaveIngredient_Click(object sender, EventArgs e)
        {
            Ingredients i = new Ingredients();

            i.Name = textBoxForIngredientName.Text;
            dbde.Ingredients.Add(i);
            dbde.SaveChanges();
            MessageBox.Show("Saved");

            this.MyParent.UpdateForm();
            //this.MyParent.MyParent = MyParent.MyParent;
            this.Close();
        }
    }
}
