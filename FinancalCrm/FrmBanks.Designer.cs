namespace FinancalCrm
{
    partial class FrmBanks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.banksButton = new System.Windows.Forms.Button();
            this.invoicesButton = new System.Windows.Forms.Button();
            this.expensesButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ziraatPanel = new System.Windows.Forms.Panel();
            this.ziraatBalanceLabel = new System.Windows.Forms.Label();
            this.ziraatNameLabel = new System.Windows.Forms.Label();
            this.vakifPanel = new System.Windows.Forms.Panel();
            this.vakifBalanceLabel = new System.Windows.Forms.Label();
            this.vakifNameLabel = new System.Windows.Forms.Label();
            this.isPanel = new System.Windows.Forms.Panel();
            this.isBalanceLabel = new System.Windows.Forms.Label();
            this.isNameLabel = new System.Windows.Forms.Label();
            this.transactionsGroupBox = new System.Windows.Forms.GroupBox();
            this.transaction1Label = new System.Windows.Forms.Label();
            this.transaction2Label = new System.Windows.Forms.Label();
            this.transaction3Label = new System.Windows.Forms.Label();
            this.transaction4Label = new System.Windows.Forms.Label();
            this.transaction5Label = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.ziraatPanel.SuspendLayout();
            this.vakifPanel.SuspendLayout();
            this.isPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1100, 82);
            this.topPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(113, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Banka Formu";
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
            this.leftPanel.Location = new System.Drawing.Point(0, 82);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(255, 538);
            this.leftPanel.TabIndex = 1;
            // 
            // categoriesButton
            // 
            this.categoriesButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.categoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoriesButton.ForeColor = System.Drawing.Color.White;
            this.categoriesButton.Location = new System.Drawing.Point(20, 22);
            this.categoriesButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.categoriesButton.Size = new System.Drawing.Size(215, 43);
            this.categoriesButton.Text = "Kategoriler";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesButton.UseVisualStyleBackColor = false;
            // 
            // banksButton
            // 
            this.banksButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.banksButton.FlatAppearance.BorderSize = 0;
            this.banksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banksButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.banksButton.ForeColor = System.Drawing.Color.White;
            this.banksButton.Location = new System.Drawing.Point(20, 78);
            this.banksButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.banksButton.Size = new System.Drawing.Size(215, 43);
            this.banksButton.Text = "Bankalar";
            this.banksButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.banksButton.UseVisualStyleBackColor = false;
            // 
            // invoicesButton
            // 
            this.invoicesButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.invoicesButton.FlatAppearance.BorderSize = 0;
            this.invoicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoicesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.invoicesButton.ForeColor = System.Drawing.Color.White;
            this.invoicesButton.Location = new System.Drawing.Point(20, 134);
            this.invoicesButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.invoicesButton.Size = new System.Drawing.Size(215, 43);
            this.invoicesButton.Text = "Faturalar";
            this.invoicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesButton.UseVisualStyleBackColor = false;
            // 
            // expensesButton
            // 
            this.expensesButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.expensesButton.FlatAppearance.BorderSize = 0;
            this.expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expensesButton.ForeColor = System.Drawing.Color.White;
            this.expensesButton.Location = new System.Drawing.Point(20, 190);
            this.expensesButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.expensesButton.Size = new System.Drawing.Size(215, 43);
            this.expensesButton.Text = "Giderler";
            this.expensesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesButton.UseVisualStyleBackColor = false;
            // 
            // transactionsButton
            // 
            this.transactionsButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.transactionsButton.FlatAppearance.BorderSize = 0;
            this.transactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transactionsButton.ForeColor = System.Drawing.Color.White;
            this.transactionsButton.Location = new System.Drawing.Point(20, 246);
            this.transactionsButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.transactionsButton.Size = new System.Drawing.Size(215, 43);
            this.transactionsButton.Text = "Banka Hareketleri";
            this.transactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionsButton.UseVisualStyleBackColor = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(20, 302);
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(215, 43);
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(20, 358);
            this.settingsButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(215, 43);
            this.settingsButton.Text = "Ayarlar";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(35, 58, 96);
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(20, 414);
            this.logoutButton.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(215, 43);
            this.logoutButton.Text = "Çıkış Yap";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // ziraatPanel
            // 
            this.ziraatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.ziraatPanel.Controls.Add(this.ziraatBalanceLabel);
            this.ziraatPanel.Controls.Add(this.ziraatNameLabel);
            this.ziraatPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ziraatPanel.Location = new System.Drawing.Point(275, 108);
            this.ziraatPanel.Name = "ziraatPanel";
            this.ziraatPanel.Size = new System.Drawing.Size(250, 145);
            this.ziraatPanel.TabIndex = 10;
            this.ziraatPanel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // ziraatBalanceLabel
            // 
            this.ziraatBalanceLabel.AutoSize = true;
            this.ziraatBalanceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ziraatBalanceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.ziraatBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.ziraatBalanceLabel.Location = new System.Drawing.Point(28, 62);
            this.ziraatBalanceLabel.Name = "ziraatBalanceLabel";
            this.ziraatBalanceLabel.Size = new System.Drawing.Size(107, 59);
            this.ziraatBalanceLabel.TabIndex = 1;
            this.ziraatBalanceLabel.Text = "0.00 ₺";
            this.ziraatBalanceLabel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // ziraatNameLabel
            // 
            this.ziraatNameLabel.AutoSize = true;
            this.ziraatNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ziraatNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ziraatNameLabel.ForeColor = System.Drawing.Color.White;
            this.ziraatNameLabel.Location = new System.Drawing.Point(18, 15);
            this.ziraatNameLabel.Name = "ziraatNameLabel";
            this.ziraatNameLabel.Size = new System.Drawing.Size(106, 21);
            this.ziraatNameLabel.TabIndex = 0;
            this.ziraatNameLabel.Text = "Ziraat Bankası";
            this.ziraatNameLabel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // vakifPanel
            // 
            this.vakifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(214)))));
            this.vakifPanel.Controls.Add(this.vakifBalanceLabel);
            this.vakifPanel.Controls.Add(this.vakifNameLabel);
            this.vakifPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vakifPanel.Location = new System.Drawing.Point(555, 108);
            this.vakifPanel.Name = "vakifPanel";
            this.vakifPanel.Size = new System.Drawing.Size(250, 145);
            this.vakifPanel.TabIndex = 11;
            this.vakifPanel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // vakifBalanceLabel
            // 
            this.vakifBalanceLabel.AutoSize = true;
            this.vakifBalanceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vakifBalanceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.vakifBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.vakifBalanceLabel.Location = new System.Drawing.Point(28, 62);
            this.vakifBalanceLabel.Name = "vakifBalanceLabel";
            this.vakifBalanceLabel.Size = new System.Drawing.Size(107, 59);
            this.vakifBalanceLabel.TabIndex = 1;
            this.vakifBalanceLabel.Text = "0.00 ₺";
            this.vakifBalanceLabel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // vakifNameLabel
            // 
            this.vakifNameLabel.AutoSize = true;
            this.vakifNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vakifNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.vakifNameLabel.ForeColor = System.Drawing.Color.White;
            this.vakifNameLabel.Location = new System.Drawing.Point(18, 15);
            this.vakifNameLabel.Name = "vakifNameLabel";
            this.vakifNameLabel.Size = new System.Drawing.Size(63, 21);
            this.vakifNameLabel.TabIndex = 0;
            this.vakifNameLabel.Text = "VakıfBank";
            this.vakifNameLabel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // isPanel
            // 
            this.isPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(91)))), ((int)(((byte)(184)))));
            this.isPanel.Controls.Add(this.isBalanceLabel);
            this.isPanel.Controls.Add(this.isNameLabel);
            this.isPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isPanel.Location = new System.Drawing.Point(835, 108);
            this.isPanel.Name = "isPanel";
            this.isPanel.Size = new System.Drawing.Size(250, 145);
            this.isPanel.TabIndex = 12;
            this.isPanel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // isBalanceLabel
            // 
            this.isBalanceLabel.AutoSize = true;
            this.isBalanceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isBalanceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.isBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.isBalanceLabel.Location = new System.Drawing.Point(28, 62);
            this.isBalanceLabel.Name = "isBalanceLabel";
            this.isBalanceLabel.Size = new System.Drawing.Size(107, 59);
            this.isBalanceLabel.TabIndex = 1;
            this.isBalanceLabel.Text = "0.00 ₺";
            this.isBalanceLabel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // isNameLabel
            // 
            this.isNameLabel.AutoSize = true;
            this.isNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.isNameLabel.ForeColor = System.Drawing.Color.White;
            this.isNameLabel.Location = new System.Drawing.Point(18, 15);
            this.isNameLabel.Name = "isNameLabel";
            this.isNameLabel.Size = new System.Drawing.Size(73, 21);
            this.isNameLabel.TabIndex = 0;
            this.isNameLabel.Text = "İş Bankası";
            this.isNameLabel.Click += new System.EventHandler(this.BankCard_Click);
            // 
            // transactionsGroupBox
            // 
            this.transactionsGroupBox.BackColor = System.Drawing.Color.White;
            this.transactionsGroupBox.Controls.Add(this.transaction5Label);
            this.transactionsGroupBox.Controls.Add(this.transaction4Label);
            this.transactionsGroupBox.Controls.Add(this.transaction3Label);
            this.transactionsGroupBox.Controls.Add(this.transaction2Label);
            this.transactionsGroupBox.Controls.Add(this.transaction1Label);
            this.transactionsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.transactionsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(101)))));
            this.transactionsGroupBox.Location = new System.Drawing.Point(275, 285);
            this.transactionsGroupBox.Name = "transactionsGroupBox";
            this.transactionsGroupBox.Size = new System.Drawing.Size(800, 320);
            this.transactionsGroupBox.TabStop = false;
            this.transactionsGroupBox.Text = "Son 5 Banka Hareketi";
            //
            // transaction labels
            //
            this.transaction1Label.AutoSize = false;
            this.transaction1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.transaction1Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transaction1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.transaction1Label.Location = new System.Drawing.Point(18, 45);
            this.transaction1Label.Name = "transaction1Label";
            this.transaction1Label.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.transaction1Label.Size = new System.Drawing.Size(760, 42);
            this.transaction1Label.TabIndex = 0;
            this.transaction1Label.Text = "Metin 1";
            this.transaction1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction2Label.AutoSize = false;
            this.transaction2Label.BackColor = System.Drawing.Color.White;
            this.transaction2Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transaction2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.transaction2Label.Location = new System.Drawing.Point(18, 88);
            this.transaction2Label.Name = "transaction2Label";
            this.transaction2Label.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.transaction2Label.Size = new System.Drawing.Size(760, 42);
            this.transaction2Label.TabIndex = 1;
            this.transaction2Label.Text = "Metin 2";
            this.transaction2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction3Label.AutoSize = false;
            this.transaction3Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.transaction3Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transaction3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.transaction3Label.Location = new System.Drawing.Point(18, 131);
            this.transaction3Label.Name = "transaction3Label";
            this.transaction3Label.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.transaction3Label.Size = new System.Drawing.Size(760, 42);
            this.transaction3Label.TabIndex = 2;
            this.transaction3Label.Text = "Metin 3";
            this.transaction3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction4Label.AutoSize = false;
            this.transaction4Label.BackColor = System.Drawing.Color.White;
            this.transaction4Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transaction4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.transaction4Label.Location = new System.Drawing.Point(18, 174);
            this.transaction4Label.Name = "transaction4Label";
            this.transaction4Label.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.transaction4Label.Size = new System.Drawing.Size(760, 42);
            this.transaction4Label.TabIndex = 3;
            this.transaction4Label.Text = "Metin 4";
            this.transaction4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction5Label.AutoSize = false;
            this.transaction5Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.transaction5Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transaction5Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.transaction5Label.Location = new System.Drawing.Point(18, 217);
            this.transaction5Label.Name = "transaction5Label";
            this.transaction5Label.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.transaction5Label.Size = new System.Drawing.Size(760, 42);
            this.transaction5Label.TabIndex = 4;
            this.transaction5Label.Text = "Metin 5";
            this.transaction5Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.transactionsGroupBox);
            this.Controls.Add(this.isPanel);
            this.Controls.Add(this.vakifPanel);
            this.Controls.Add(this.ziraatPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Yönetimi";
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.ziraatPanel.ResumeLayout(false);
            this.ziraatPanel.PerformLayout();
            this.vakifPanel.ResumeLayout(false);
            this.vakifPanel.PerformLayout();
            this.isPanel.ResumeLayout(false);
            this.isPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Button banksButton;
        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.Button expensesButton;
        private System.Windows.Forms.Button transactionsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel ziraatPanel;
        private System.Windows.Forms.Panel vakifPanel;
        private System.Windows.Forms.Panel isPanel;
        private System.Windows.Forms.Label ziraatNameLabel;
        private System.Windows.Forms.Label vakifNameLabel;
        private System.Windows.Forms.Label isNameLabel;
        private System.Windows.Forms.Label ziraatBalanceLabel;
        private System.Windows.Forms.Label vakifBalanceLabel;
        private System.Windows.Forms.Label isBalanceLabel;
        private System.Windows.Forms.GroupBox transactionsGroupBox;
        private System.Windows.Forms.Label transaction1Label;
        private System.Windows.Forms.Label transaction2Label;
        private System.Windows.Forms.Label transaction3Label;
        private System.Windows.Forms.Label transaction4Label;
        private System.Windows.Forms.Label transaction5Label;

    }
}