using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DylanDeSouzaWk9ExA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int int_number_repayments = int.Parse(txtNumberRepayments.Text), int_payment_interval = int.Parse(txtPaymentInterval.Text);
            List<DateTime> dte_repayment_dates = new List<DateTime>();
            {
                for (int i = 0; i < int_number_repayments; i++)
                {
                    dte_repayment_dates.Insert(0, DateTime.Now);
                    dte_repayment_dates.Insert(i, dte_repayment_dates[i].AddDays(int_payment_interval));
                    lstRepaymentDates.Items.Add(dte_repayment_dates[i]);
                }
                
            }
        }
    }
}
