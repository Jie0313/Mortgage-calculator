namespace 房貸試算器
{
    partial class frmCalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cmbFund = new System.Windows.Forms.ComboBox();
            this.txtFund = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblLoan = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblLoanTotalPrice = new System.Windows.Forms.Label();
            this.lblMonthlyAmount = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblLTP = new System.Windows.Forms.Label();
            this.lblMA = new System.Windows.Forms.Label();
            this.lblFI = new System.Windows.Forms.Label();
            this.lblFP = new System.Windows.Forms.Label();
            this.lblTI = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(39, 63);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(67, 15);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "房屋總價";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(164, 52);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 25);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // cmbFund
            // 
            this.cmbFund.FormattingEnabled = true;
            this.cmbFund.Items.AddRange(new object[] {
            "自備款比例(%)",
            "自備款金額(NTD)"});
            this.cmbFund.Location = new System.Drawing.Point(42, 118);
            this.cmbFund.Name = "cmbFund";
            this.cmbFund.Size = new System.Drawing.Size(121, 23);
            this.cmbFund.TabIndex = 2;
            this.cmbFund.SelectedIndexChanged += new System.EventHandler(this.cmbFund_SelectedIndexChanged);
            // 
            // txtFund
            // 
            this.txtFund.Location = new System.Drawing.Point(220, 118);
            this.txtFund.Name = "txtFund";
            this.txtFund.Size = new System.Drawing.Size(100, 25);
            this.txtFund.TabIndex = 3;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(42, 193);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(67, 15);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "貸款利率";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(164, 190);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 25);
            this.txtRate.TabIndex = 5;
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(42, 259);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(67, 15);
            this.lblLoan.TabIndex = 6;
            this.lblLoan.Text = "貸款年限";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(182, 256);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 25);
            this.txtLoan.TabIndex = 7;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(42, 315);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(52, 15);
            this.lblPeriod.TabIndex = 8;
            this.lblPeriod.Text = "寬限期";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(182, 312);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(100, 25);
            this.txtPeriod.TabIndex = 9;
            // 
            // lblLoanTotalPrice
            // 
            this.lblLoanTotalPrice.AutoSize = true;
            this.lblLoanTotalPrice.Location = new System.Drawing.Point(397, 55);
            this.lblLoanTotalPrice.Name = "lblLoanTotalPrice";
            this.lblLoanTotalPrice.Size = new System.Drawing.Size(82, 15);
            this.lblLoanTotalPrice.TabIndex = 10;
            this.lblLoanTotalPrice.Text = "貸款總金額";
            // 
            // lblMonthlyAmount
            // 
            this.lblMonthlyAmount.AutoSize = true;
            this.lblMonthlyAmount.Location = new System.Drawing.Point(397, 107);
            this.lblMonthlyAmount.Name = "lblMonthlyAmount";
            this.lblMonthlyAmount.Size = new System.Drawing.Size(97, 15);
            this.lblMonthlyAmount.TabIndex = 11;
            this.lblMonthlyAmount.Text = "每月應繳金額";
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Location = new System.Drawing.Point(397, 155);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(67, 15);
            this.lblFirstInterest.TabIndex = 12;
            this.lblFirstInterest.Text = "首期利息";
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Location = new System.Drawing.Point(397, 200);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(67, 15);
            this.lblFirstPrincipal.TabIndex = 13;
            this.lblFirstPrincipal.Text = "首期本金";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(397, 246);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(82, 15);
            this.lblTotalInterest.TabIndex = 14;
            this.lblTotalInterest.Text = "總利息支出";
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Location = new System.Drawing.Point(397, 301);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(82, 15);
            this.lblTotalRepayment.TabIndex = 15;
            this.lblTotalRepayment.Text = "總還款金額";
            // 
            // lblLTP
            // 
            this.lblLTP.AutoSize = true;
            this.lblLTP.Location = new System.Drawing.Point(528, 55);
            this.lblLTP.Name = "lblLTP";
            this.lblLTP.Size = new System.Drawing.Size(82, 15);
            this.lblLTP.TabIndex = 16;
            this.lblLTP.Text = "貸款總金額";
            // 
            // lblMA
            // 
            this.lblMA.AutoSize = true;
            this.lblMA.Location = new System.Drawing.Point(528, 107);
            this.lblMA.Name = "lblMA";
            this.lblMA.Size = new System.Drawing.Size(82, 15);
            this.lblMA.TabIndex = 17;
            this.lblMA.Text = "貸款總金額";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Location = new System.Drawing.Point(528, 155);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(82, 15);
            this.lblFI.TabIndex = 18;
            this.lblFI.Text = "貸款總金額";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Location = new System.Drawing.Point(528, 200);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(82, 15);
            this.lblFP.TabIndex = 19;
            this.lblFP.Text = "貸款總金額";
            // 
            // lblTI
            // 
            this.lblTI.AutoSize = true;
            this.lblTI.Location = new System.Drawing.Point(528, 246);
            this.lblTI.Name = "lblTI";
            this.lblTI.Size = new System.Drawing.Size(82, 15);
            this.lblTI.TabIndex = 20;
            this.lblTI.Text = "貸款總金額";
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(528, 301);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(82, 15);
            this.lblTR.TabIndex = 21;
            this.lblTR.Text = "貸款總金額";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(164, 370);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(118, 42);
            this.btnCal.TabIndex = 22;
            this.btnCal.Text = "開始試算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(339, 127);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 15);
            this.lblUnit.TabIndex = 23;
            this.lblUnit.Text = "label1";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.lblTI);
            this.Controls.Add(this.lblFP);
            this.Controls.Add(this.lblFI);
            this.Controls.Add(this.lblMA);
            this.Controls.Add(this.lblLTP);
            this.Controls.Add(this.lblTotalRepayment);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblFirstPrincipal);
            this.Controls.Add(this.lblFirstInterest);
            this.Controls.Add(this.lblMonthlyAmount);
            this.Controls.Add(this.lblLoanTotalPrice);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtFund);
            this.Controls.Add(this.cmbFund);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Name = "frmCalculator";
            this.Text = "房貸試算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cmbFund;
        private System.Windows.Forms.TextBox txtFund;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblLoanTotalPrice;
        private System.Windows.Forms.Label lblMonthlyAmount;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblLTP;
        private System.Windows.Forms.Label lblMA;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.Label lblTI;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblUnit;
    }
}

