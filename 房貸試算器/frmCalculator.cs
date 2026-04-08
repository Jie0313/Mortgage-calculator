using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            double factor = Math.Pow(1 + r, n) * r / (Math.Pow(1 + r, n) - 1);

            double M = loan * factor;

            return M;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double price, fund, rate, loan;
            int years, period;

            if (this.txtTotalPrice.Text == "")
            {
                MessageBox.Show("請輸入房屋總價");
                return;
            }

            if (this.txtFund.Text == "" && cmbFund.SelectedIndex == 0)
            {
                MessageBox.Show("請輸入自備款比例");
                return;
            }

            if (this.txtFund.Text == "" && cmbFund.SelectedIndex == 1)
            {
                MessageBox.Show("請輸入自備款金額");
                return;
            }

            if (this.txtRate.Text == "")
            {
                MessageBox.Show("請輸入貸款利率");
                return;
            }

            if (this.txtLoan.Text == "")
            {
                MessageBox.Show("請輸入貸款年限");
                return;
            }

            if (this.txtPeriod.Text == "")
            {
                MessageBox.Show("請輸入寬限期");
                return;
            }

            string priceText = txtTotalPrice.Text.Replace(",", "");
            if (!double.TryParse(priceText, out price))
            {
                MessageBox.Show("房價輸入錯誤！");
                return;
            }

            string fundText = txtFund.Text.Replace(",", "");
            if (!double.TryParse(fundText, out fund))
            {
                MessageBox.Show("自備款輸入錯誤！");
                return;
            }

            if (!double.TryParse(txtRate.Text, out rate))
            {
                MessageBox.Show("利率輸入錯誤！");
                return;
            }

            if (!int.TryParse(txtLoan.Text, out years))
            {
                MessageBox.Show("貸款年限輸入錯誤！");
                return;
            }

            if (!int.TryParse(txtPeriod.Text, out period))
            {
                MessageBox.Show("寬限期輸入錯誤！");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("房價必須大於 0！");
                return;
            }

            if (years <= 0)
            {
                MessageBox.Show("貸款年限必須大於 0！");
                return;
            }

            if (rate < 0)
            {
                MessageBox.Show("利率不能小於 0！");
                return;
            }

            if (period < 0 || period > years)
            {
                MessageBox.Show("寬限期需介於 0 ~ 貸款年限之間！");
                return;
            }

            if (cmbFund.SelectedIndex == 0)
            {
                if (fund < 0 || fund >= 100)
                {
                    MessageBox.Show("比例需在 0~100 之間！");
                    return;
                }

                loan = price * (1 - fund / 100);
            }
            else
            {
                if (fund < 0 || fund >= price)
                {
                    MessageBox.Show("自備款金額需小於房價！");
                    return;
                }

                loan = price - fund;
            }

            double r = rate / 100 / 12;
            int totalMonths = years * 12;
            double monthly;

            if (rate == 0)
            {
                monthly = loan / totalMonths;
            }
            else
            {
                monthly = CalculateMonthlyPayment(loan, rate, years);
            }

            double firstInterest = loan * r;
            double firstPrincipal = monthly - firstInterest;

            double totalPayment = monthly * totalMonths;
            double totalInterest = totalPayment - loan;

            lblLTP.Text = $"{loan:N2} 元";
            lblMA.Text = $"{monthly:N2} 元/月";
            lblFI.Text = $"{firstInterest:N2} 元";
            lblFP.Text = $"{firstPrincipal:N2} 元";
            lblTI.Text = $"{totalInterest:N2} 元";
            lblTR.Text = $"{totalPayment:N2} 元";
        }

        private void cmbFund_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFund.SelectedIndex == 0)
            {
                lblUnit2.Text = "%";
            }
            else
            {
                lblUnit2.Text = "元";
            }
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            cmbFund.SelectedIndex = 0;
        }
    }
}
