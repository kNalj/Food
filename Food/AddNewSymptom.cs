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
    public partial class AddNewSymptom : Form
    {

        /// <summary>
        /// MEMBER VARIABLES
        /// </summary>
        private Database1Entities dbde = new Database1Entities();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public AddNewSymptom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON LOAD
        /// </summary>
        private void AddNewSymptom_Load(object sender, EventArgs e)
        {
            comboBoxForSymptoms.DataSource = dbde.Symptoms.ToList();
            comboBoxForSymptoms.DisplayMember = "Description";

            dateTimePickerSymptom.Format = DateTimePickerFormat.Custom;
            dateTimePickerSymptom.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePickerSymptom.ShowUpDown = true;
        }

        /// <summary>
        /// EVENTS
        /// </summary>
        private void buttonForSavingSymptom_Click(object sender, EventArgs e)
        {
            Symptoms s = new Symptoms();
            s.Description = textBox1.Text;
            s.Date = DateTime.Now;

            dbde.Symptoms.Add(s);
            dbde.SaveChanges();

            MessageBox.Show("Saved");
            this.Close();
        }

        private void comboBoxForSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Symptoms s = (Symptoms)comboBoxForSymptoms.SelectedItem;

            this.textBox1.Text = s.Description;
        }
    }
}
