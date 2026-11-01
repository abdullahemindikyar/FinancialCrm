namespace FinancalCrm
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.isPanel = new System.Windows.Forms.Panel();
            this.isBalanceLabel = new System.Windows.Forms.Label();
            this.isNameLabel = new System.Windows.Forms.Label();
            this.vakifPanel = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.ziraatPanel = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.totalBankBalance = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.banksButton = new System.Windows.Forms.Button();
            this.invoicesButton = new System.Windows.Forms.Button();
            this.expensesButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bankChartLabel = new System.Windows.Forms.Label();
            this.billChartLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.isPanel.SuspendLayout();
            this.vakifPanel.SuspendLayout();
            this.ziraatPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // isPanel
            // 
            this.isPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(91)))), ((int)(((byte)(184)))));
            this.isPanel.Controls.Add(this.isBalanceLabel);
            this.isPanel.Controls.Add(this.isNameLabel);
            this.isPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isPanel.Location = new System.Drawing.Point(678, 94);
            this.isPanel.Name = "isPanel";
            this.isPanel.Size = new System.Drawing.Size(214, 126);
            this.isPanel.TabIndex = 18;
            // 
            // isBalanceLabel
            // 
            this.isBalanceLabel.AutoSize = true;
            this.isBalanceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isBalanceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.isBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.isBalanceLabel.Location = new System.Drawing.Point(24, 54);
            this.isBalanceLabel.Name = "isBalanceLabel";
            this.isBalanceLabel.Size = new System.Drawing.Size(119, 48);
            this.isBalanceLabel.TabIndex = 1;
            this.isBalanceLabel.Text = "0.00 ₺";
            // 
            // isNameLabel
            // 
            this.isNameLabel.AutoSize = true;
            this.isNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.isNameLabel.ForeColor = System.Drawing.Color.White;
            this.isNameLabel.Location = new System.Drawing.Point(15, 13);
            this.isNameLabel.Name = "isNameLabel";
            this.isNameLabel.Size = new System.Drawing.Size(85, 21);
            this.isNameLabel.TabIndex = 0;
            this.isNameLabel.Text = "Son Yapılan 3 İşlem";
            // 
            // vakifPanel
            // 
            this.vakifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(214)))));
            this.vakifPanel.Controls.Add(this.lblBillAmount);
            this.vakifPanel.Controls.Add(this.lblBillTitle);
            this.vakifPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vakifPanel.Location = new System.Drawing.Point(458, 94);
            this.vakifPanel.Name = "vakifPanel";
            this.vakifPanel.Size = new System.Drawing.Size(214, 126);
            this.vakifPanel.TabIndex = 17;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.lblBillAmount.ForeColor = System.Drawing.Color.White;
            this.lblBillAmount.Location = new System.Drawing.Point(24, 54);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(119, 48);
            this.lblBillAmount.TabIndex = 1;
            this.lblBillAmount.Text = "0.00 ₺";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBillTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillTitle.ForeColor = System.Drawing.Color.White;
            this.lblBillTitle.Location = new System.Drawing.Point(15, 13);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(90, 17);
            this.lblBillTitle.TabIndex = 0;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // ziraatPanel
            // 
            this.ziraatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.ziraatPanel.Controls.Add(this.lblTotalBalance);
            this.ziraatPanel.Controls.Add(this.totalBankBalance);
            this.ziraatPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ziraatPanel.Location = new System.Drawing.Point(236, 94);
            this.ziraatPanel.Name = "ziraatPanel";
            this.ziraatPanel.Size = new System.Drawing.Size(214, 126);
            this.ziraatPanel.TabIndex = 16;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(24, 54);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(119, 48);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "0.00 ₺";
            // 
            // totalBankBalance
            // 
            this.totalBankBalance.AutoSize = true;
            this.totalBankBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalBankBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalBankBalance.ForeColor = System.Drawing.Color.White;
            this.totalBankBalance.Location = new System.Drawing.Point(12, 17);
            this.totalBankBalance.Name = "totalBankBalance";
            this.totalBankBalance.Size = new System.Drawing.Size(137, 21);
            this.totalBankBalance.TabIndex = 0;
            this.totalBankBalance.Text = "Toplam Bakiyem";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.leftPanel.Controls.Add(this.categoriesButton);
            this.leftPanel.Controls.Add(this.banksButton);
            this.leftPanel.Controls.Add(this.invoicesButton);
            this.leftPanel.Controls.Add(this.expensesButton);
            this.leftPanel.Controls.Add(this.transactionsButton);
            this.leftPanel.Controls.Add(this.dashboardButton);
            this.leftPanel.Controls.Add(this.settingsButton);
            this.leftPanel.Controls.Add(this.logoutButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 71);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(219, 446);
            this.leftPanel.TabIndex = 15;
            // 
            // categoriesButton
            // 
            this.categoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.categoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoriesButton.ForeColor = System.Drawing.Color.White;
            this.categoriesButton.Location = new System.Drawing.Point(17, 19);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.categoriesButton.Size = new System.Drawing.Size(184, 37);
            this.categoriesButton.TabIndex = 0;
            this.categoriesButton.Text = "Kategoriler";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesButton.UseVisualStyleBackColor = false;
            // 
            // banksButton
            // 
            this.banksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.banksButton.FlatAppearance.BorderSize = 0;
            this.banksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banksButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.banksButton.ForeColor = System.Drawing.Color.White;
            this.banksButton.Location = new System.Drawing.Point(17, 68);
            this.banksButton.Name = "banksButton";
            this.banksButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.banksButton.Size = new System.Drawing.Size(184, 37);
            this.banksButton.TabIndex = 1;
            this.banksButton.Text = "Bankalar";
            this.banksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.banksButton.UseVisualStyleBackColor = false;
            // 
            // invoicesButton
            // 
            this.invoicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.invoicesButton.FlatAppearance.BorderSize = 0;
            this.invoicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoicesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.invoicesButton.ForeColor = System.Drawing.Color.White;
            this.invoicesButton.Location = new System.Drawing.Point(17, 116);
            this.invoicesButton.Name = "invoicesButton";
            this.invoicesButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.invoicesButton.Size = new System.Drawing.Size(184, 37);
            this.invoicesButton.TabIndex = 2;
            this.invoicesButton.Text = "Faturalar";
            this.invoicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesButton.UseVisualStyleBackColor = false;
            // 
            // expensesButton
            // 
            this.expensesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.expensesButton.FlatAppearance.BorderSize = 0;
            this.expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expensesButton.ForeColor = System.Drawing.Color.White;
            this.expensesButton.Location = new System.Drawing.Point(17, 165);
            this.expensesButton.Name = "expensesButton";
            this.expensesButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.expensesButton.Size = new System.Drawing.Size(184, 37);
            this.expensesButton.TabIndex = 3;
            this.expensesButton.Text = "Giderler";
            this.expensesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesButton.UseVisualStyleBackColor = false;
            // 
            // transactionsButton
            // 
            this.transactionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.transactionsButton.FlatAppearance.BorderSize = 0;
            this.transactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transactionsButton.ForeColor = System.Drawing.Color.White;
            this.transactionsButton.Location = new System.Drawing.Point(17, 213);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.transactionsButton.Size = new System.Drawing.Size(184, 37);
            this.transactionsButton.TabIndex = 4;
            this.transactionsButton.Text = "Banka Hareketleri";
            this.transactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionsButton.UseVisualStyleBackColor = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(17, 262);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(184, 37);
            this.dashboardButton.TabIndex = 5;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(17, 310);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(184, 37);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Ayarlar";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(17, 359);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(184, 37);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Çıkış Yap";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(908, 71);
            this.topPanel.TabIndex = 14;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.titleLabel.Location = new System.Drawing.Point(26, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(237, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dashboard Formu";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            this.bankChartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.bankChartLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bankChartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bankChartLabel.Location = new System.Drawing.Point(236, 236);
            this.bankChartLabel.Name = "bankChartLabel";
            this.bankChartLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.bankChartLabel.Size = new System.Drawing.Size(313, 38);
            this.bankChartLabel.TabIndex = 19;
            this.bankChartLabel.Text = "Banka hesaplarındaki para miktarları";
            this.bankChartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(236, 274);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(313, 239);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.billChartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.billChartLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.billChartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.billChartLabel.Location = new System.Drawing.Point(579, 236);
            this.billChartLabel.Name = "billChartLabel";
            this.billChartLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.billChartLabel.Size = new System.Drawing.Size(313, 38);
            this.billChartLabel.TabIndex = 21;
            this.billChartLabel.Text = "Fatura tutarları";
            this.billChartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(579, 274);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(313, 239);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
//            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.billChartLabel);
            this.Controls.Add(this.bankChartLabel);
            this.Controls.Add(this.isPanel);
            this.Controls.Add(this.vakifPanel);
            this.Controls.Add(this.ziraatPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.isPanel.ResumeLayout(false);
            this.isPanel.PerformLayout();
            this.vakifPanel.ResumeLayout(false);
            this.vakifPanel.PerformLayout();
            this.ziraatPanel.ResumeLayout(false);
            this.ziraatPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel isPanel;
        private System.Windows.Forms.Label isBalanceLabel;
        private System.Windows.Forms.Label isNameLabel;
        private System.Windows.Forms.Panel vakifPanel;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel ziraatPanel;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label totalBankBalance;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Button banksButton;
        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.Button expensesButton;
        private System.Windows.Forms.Button transactionsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label bankChartLabel;
        private System.Windows.Forms.Label billChartLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}