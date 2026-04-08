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
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 70);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(82, 23);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "房屋總價";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(198, 62);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(180, 31);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // cmbFund
            // 
            this.cmbFund.FormattingEnabled = true;
            this.cmbFund.Items.AddRange(new object[] {
            "自備款比例(%)",
            "自備款金額(NTD)"});
            this.cmbFund.Location = new System.Drawing.Point(20, 120);
            this.cmbFund.Name = "cmbFund";
            this.cmbFund.Size = new System.Drawing.Size(158, 31);
            this.cmbFund.TabIndex = 2;
            this.cmbFund.SelectedIndexChanged += new System.EventHandler(this.cmbFund_SelectedIndexChanged);
            // 
            // txtFund
            // 
            this.txtFund.Location = new System.Drawing.Point(198, 120);
            this.txtFund.Name = "txtFund";
            this.txtFund.Size = new System.Drawing.Size(180, 31);
            this.txtFund.TabIndex = 3;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(20, 176);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(82, 23);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "貸款利率";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(198, 173);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(180, 31);
            this.txtRate.TabIndex = 5;
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(22, 233);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(82, 23);
            this.lblLoan.TabIndex = 6;
            this.lblLoan.Text = "貸款年限";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(198, 225);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(180, 31);
            this.txtLoan.TabIndex = 7;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(22, 295);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(64, 23);
            this.lblPeriod.TabIndex = 8;
            this.lblPeriod.Text = "寬限期";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(198, 292);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(180, 31);
            this.txtPeriod.TabIndex = 9;
            // 
            // lblLoanTotalPrice
            // 
            this.lblLoanTotalPrice.AutoSize = true;
            this.lblLoanTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanTotalPrice.Location = new System.Drawing.Point(20, 70);
            this.lblLoanTotalPrice.Name = "lblLoanTotalPrice";
            this.lblLoanTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.lblLoanTotalPrice.TabIndex = 10;
            this.lblLoanTotalPrice.Text = "貸款總金額";
            // 
            // lblMonthlyAmount
            // 
            this.lblMonthlyAmount.AutoSize = true;
            this.lblMonthlyAmount.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyAmount.Location = new System.Drawing.Point(20, 123);
            this.lblMonthlyAmount.Name = "lblMonthlyAmount";
            this.lblMonthlyAmount.Size = new System.Drawing.Size(118, 23);
            this.lblMonthlyAmount.TabIndex = 11;
            this.lblMonthlyAmount.Text = "每月應繳金額";
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInterest.Location = new System.Drawing.Point(22, 176);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(82, 23);
            this.lblFirstInterest.TabIndex = 12;
            this.lblFirstInterest.Text = "首期利息";
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstPrincipal.Location = new System.Drawing.Point(20, 228);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(82, 23);
            this.lblFirstPrincipal.TabIndex = 13;
            this.lblFirstPrincipal.Text = "首期本金";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalInterest.Location = new System.Drawing.Point(20, 283);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(100, 23);
            this.lblTotalInterest.TabIndex = 14;
            this.lblTotalInterest.Text = "總利息支出";
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalRepayment.Location = new System.Drawing.Point(20, 335);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(100, 23);
            this.lblTotalRepayment.TabIndex = 15;
            this.lblTotalRepayment.Text = "總還款金額";
            // 
            // lblLTP
            // 
            this.lblLTP.AutoSize = true;
            this.lblLTP.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLTP.Location = new System.Drawing.Point(208, 70);
            this.lblLTP.Name = "lblLTP";
            this.lblLTP.Size = new System.Drawing.Size(100, 23);
            this.lblLTP.TabIndex = 16;
            this.lblLTP.Text = "貸款總金額";
            // 
            // lblMA
            // 
            this.lblMA.AutoSize = true;
            this.lblMA.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMA.Location = new System.Drawing.Point(208, 123);
            this.lblMA.Name = "lblMA";
            this.lblMA.Size = new System.Drawing.Size(100, 23);
            this.lblMA.TabIndex = 17;
            this.lblMA.Text = "貸款總金額";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFI.Location = new System.Drawing.Point(208, 176);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(100, 23);
            this.lblFI.TabIndex = 18;
            this.lblFI.Text = "貸款總金額";
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFP.Location = new System.Drawing.Point(208, 228);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(100, 23);
            this.lblFP.TabIndex = 19;
            this.lblFP.Text = "貸款總金額";
            // 
            // lblTI
            // 
            this.lblTI.AutoSize = true;
            this.lblTI.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTI.Location = new System.Drawing.Point(208, 283);
            this.lblTI.Name = "lblTI";
            this.lblTI.Size = new System.Drawing.Size(100, 23);
            this.lblTI.TabIndex = 20;
            this.lblTI.Text = "貸款總金額";
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTR.Location = new System.Drawing.Point(208, 335);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(100, 23);
            this.lblTR.TabIndex = 21;
            this.lblTR.Text = "貸款總金額";
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Navy;
            this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCal.ForeColor = System.Drawing.Color.Transparent;
            this.btnCal.Location = new System.Drawing.Point(84, 368);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(118, 42);
            this.btnCal.TabIndex = 22;
            this.btnCal.Text = "開始試算";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(393, 123);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(26, 23);
            this.lblUnit2.TabIndex = 23;
            this.lblUnit2.Text = "%";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUnit1.Location = new System.Drawing.Point(391, 70);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(28, 23);
            this.lblUnit1.TabIndex = 24;
            this.lblUnit1.Text = "元";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(384, 176);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(62, 23);
            this.lblUnit3.TabIndex = 25;
            this.lblUnit3.Text = "% / 年";
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Location = new System.Drawing.Point(391, 233);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(28, 23);
            this.lblUnit4.TabIndex = 26;
            this.lblUnit4.Text = "年";
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Location = new System.Drawing.Point(393, 296);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(28, 23);
            this.lblUnit5.TabIndex = 27;
            this.lblUnit5.Text = "年";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(236, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 42);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 50);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "個人房貸試算器";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.Color.Transparent;
            this.lblInput.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInput.ForeColor = System.Drawing.Color.Navy;
            this.lblInput.Location = new System.Drawing.Point(20, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(127, 36);
            this.lblInput.TabIndex = 30;
            this.lblInput.Text = "輸入資料";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOutput.ForeColor = System.Drawing.Color.Navy;
            this.lblOutput.Location = new System.Drawing.Point(18, 20);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(127, 36);
            this.lblOutput.TabIndex = 31;
            this.lblOutput.Text = "試算結果";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.SeaShell;
            this.pnlLeft.Controls.Add(this.lblInput);
            this.pnlLeft.Controls.Add(this.lblTotalPrice);
            this.pnlLeft.Controls.Add(this.txtTotalPrice);
            this.pnlLeft.Controls.Add(this.cmbFund);
            this.pnlLeft.Controls.Add(this.btnClear);
            this.pnlLeft.Controls.Add(this.lblUnit5);
            this.pnlLeft.Controls.Add(this.btnCal);
            this.pnlLeft.Controls.Add(this.lblUnit1);
            this.pnlLeft.Controls.Add(this.txtFund);
            this.pnlLeft.Controls.Add(this.lblUnit4);
            this.pnlLeft.Controls.Add(this.lblUnit2);
            this.pnlLeft.Controls.Add(this.lblUnit3);
            this.pnlLeft.Controls.Add(this.lblRate);
            this.pnlLeft.Controls.Add(this.txtRate);
            this.pnlLeft.Controls.Add(this.lblLoan);
            this.pnlLeft.Controls.Add(this.txtLoan);
            this.pnlLeft.Controls.Add(this.lblPeriod);
            this.pnlLeft.Controls.Add(this.txtPeriod);
            this.pnlLeft.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnlLeft.Location = new System.Drawing.Point(30, 100);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(450, 450);
            this.pnlLeft.TabIndex = 32;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.SeaShell;
            this.pnlRight.Controls.Add(this.lblLoanTotalPrice);
            this.pnlRight.Controls.Add(this.lblLTP);
            this.pnlRight.Controls.Add(this.lblOutput);
            this.pnlRight.Controls.Add(this.lblMonthlyAmount);
            this.pnlRight.Controls.Add(this.lblMA);
            this.pnlRight.Controls.Add(this.lblTotalRepayment);
            this.pnlRight.Controls.Add(this.lblTR);
            this.pnlRight.Controls.Add(this.lblTotalInterest);
            this.pnlRight.Controls.Add(this.lblFirstInterest);
            this.pnlRight.Controls.Add(this.lblTI);
            this.pnlRight.Controls.Add(this.lblFI);
            this.pnlRight.Controls.Add(this.lblFP);
            this.pnlRight.Controls.Add(this.lblFirstPrincipal);
            this.pnlRight.Location = new System.Drawing.Point(500, 100);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(450, 450);
            this.pnlRight.TabIndex = 33;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCalculator";
            this.Text = "房貸試算器";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
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
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
    }
}

