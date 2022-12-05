using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk9ExA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dte_entry = dateTimePicker1.Value.Date;
            DateTime dte_today = DateTime.Today.Date;
            TimeSpan tsp_interval = dte_entry.Subtract(dte_today);
            int int_years = tsp_interval.Days;
            if (dte_entry > dte_today)
            {
                MessageBox.Show("The entered date cannot be later than today's date - select the date again");
            }
            else
            {
                txtAgeYears.Text = int_years.ToString();
            }
        }
    }
}
