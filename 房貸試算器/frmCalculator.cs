using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 房貸試算器
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        double CalculateMonthlyPayment(double loan, double annualRate, int years)
        {
            double r = annualRate / 100 / 12; 
            int n = years * 12;               

            double M = loan * r * Math.Pow(1 + r, n)
                     / (Math.Pow(1 + r, n) - 1);

            return M;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbFund_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFund.SelectedIndex == 0)
            {
                lblUnit.Text = "%";
            }
            else
            {
                lblUnit.Text = "元";
            }
        }
    }
}
