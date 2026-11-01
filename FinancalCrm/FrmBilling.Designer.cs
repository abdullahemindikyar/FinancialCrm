namespace FinancalCrm
{
    partial class FrmBilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.paymentFormPanel = new System.Windows.Forms.Panel();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.paymentTitleLabel = new System.Windows.Forms.Label();
            this.paymentIdLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtPaymentTitle = new System.Windows.Forms.TextBox();
            this.txtPaymentPeriod = new System.Windows.Forms.TextBox();
            this.findPaymentButton = new System.Windows.Forms.Button();
            this.paymentListButton = new System.Windows.Forms.Button();
            this.newPaymentButton = new System.Windows.Forms.Button();
            this.deletePaymentButton = new System.Windows.Forms.Button();
            this.updatePaymentButton = new System.Windows.Forms.Button();
            this.paymentsGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.paymentFormPanel.SuspendLayout();
            this.paymentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(943, 71);
            this.topPanel.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.titleLabel.Location = new System.Drawing.Point(26, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fatura Yönetimi";
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
            this.leftPanel.Size = new System.Drawing.Size(219, 466);
            this.leftPanel.TabIndex = 2;
            // 
            // categoriesButton
            // 
            this.categoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
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
            this.invoicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.invoicesButton.FlatAppearance.BorderSize = 0;
            this.invoicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoicesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
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
            // paymentFormPanel
            // 
            this.paymentFormPanel.BackColor = System.Drawing.Color.White;
            this.paymentFormPanel.Controls.Add(this.txtPaymentAmount);
            this.paymentFormPanel.Controls.Add(this.paymentTitleLabel);
            this.paymentFormPanel.Controls.Add(this.paymentIdLabel);
            this.paymentFormPanel.Controls.Add(this.subjectLabel);
            this.paymentFormPanel.Controls.Add(this.amountLabel);
            this.paymentFormPanel.Controls.Add(this.periodLabel);
            this.paymentFormPanel.Controls.Add(this.txtPaymentId);
            this.paymentFormPanel.Controls.Add(this.txtPaymentTitle);
            this.paymentFormPanel.Controls.Add(this.txtPaymentPeriod);
            this.paymentFormPanel.Controls.Add(this.findPaymentButton);
            this.paymentFormPanel.Controls.Add(this.paymentListButton);
            this.paymentFormPanel.Controls.Add(this.newPaymentButton);
            this.paymentFormPanel.Controls.Add(this.deletePaymentButton);
            this.paymentFormPanel.Controls.Add(this.updatePaymentButton);
            this.paymentFormPanel.Location = new System.Drawing.Point(244, 77);
            this.paymentFormPanel.Name = "paymentFormPanel";
            this.paymentFormPanel.Size = new System.Drawing.Size(677, 212);
            this.paymentFormPanel.TabIndex = 1;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaymentAmount.Location = new System.Drawing.Point(111, 110);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(536, 25);
            this.txtPaymentAmount.TabIndex = 13;
            // 
            // paymentTitleLabel
            // 
            this.paymentTitleLabel.AutoSize = true;
            this.paymentTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.paymentTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.paymentTitleLabel.Location = new System.Drawing.Point(21, 16);
            this.paymentTitleLabel.Name = "paymentTitleLabel";
            this.paymentTitleLabel.Size = new System.Drawing.Size(143, 25);
            this.paymentTitleLabel.TabIndex = 0;
            this.paymentTitleLabel.Text = "Ödeme Bilgileri";
            // 
            // paymentIdLabel
            // 
            this.paymentIdLabel.AutoSize = true;
            this.paymentIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.paymentIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(101)))));
            this.paymentIdLabel.Location = new System.Drawing.Point(21, 54);
            this.paymentIdLabel.Name = "paymentIdLabel";
            this.paymentIdLabel.Size = new System.Drawing.Size(72, 19);
            this.paymentIdLabel.TabIndex = 1;
            this.paymentIdLabel.Text = "Ödeme ID";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(101)))));
            this.subjectLabel.Location = new System.Drawing.Point(21, 83);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(43, 19);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Başlık";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(101)))));
            this.amountLabel.Location = new System.Drawing.Point(21, 113);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(49, 19);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Miktar";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.periodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(101)))));
            this.periodLabel.Location = new System.Drawing.Point(21, 142);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(51, 19);
            this.periodLabel.TabIndex = 4;
            this.periodLabel.Text = "Periyot";
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtPaymentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaymentId.Location = new System.Drawing.Point(111, 50);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(490, 25);
            this.txtPaymentId.TabIndex = 5;
            // 
            // txtPaymentTitle
            // 
            this.txtPaymentTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtPaymentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaymentTitle.Location = new System.Drawing.Point(111, 80);
            this.txtPaymentTitle.Name = "txtPaymentTitle";
            this.txtPaymentTitle.Size = new System.Drawing.Size(536, 25);
            this.txtPaymentTitle.TabIndex = 6;
            // 
            // txtPaymentPeriod
            // 
            this.txtPaymentPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtPaymentPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaymentPeriod.Location = new System.Drawing.Point(111, 139);
            this.txtPaymentPeriod.Name = "txtPaymentPeriod";
            this.txtPaymentPeriod.Size = new System.Drawing.Size(536, 25);
            this.txtPaymentPeriod.TabIndex = 8;
            // 
            // findPaymentButton
            // 
            this.findPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(155)))), ((int)(((byte)(115)))));
            this.findPaymentButton.FlatAppearance.BorderSize = 0;
            this.findPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findPaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.findPaymentButton.ForeColor = System.Drawing.Color.White;
            this.findPaymentButton.Location = new System.Drawing.Point(522, 172);
            this.findPaymentButton.Name = "findPaymentButton";
            this.findPaymentButton.Size = new System.Drawing.Size(53, 28);
            this.findPaymentButton.TabIndex = 14;
            this.findPaymentButton.Text = "Bul";
            this.findPaymentButton.UseVisualStyleBackColor = false;
            this.findPaymentButton.Click += new System.EventHandler(this.findPaymentButton_Click);
            // 
            // paymentListButton
            // 
            this.paymentListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.paymentListButton.FlatAppearance.BorderSize = 0;
            this.paymentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentListButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.paymentListButton.ForeColor = System.Drawing.Color.White;
            this.paymentListButton.Location = new System.Drawing.Point(19, 172);
            this.paymentListButton.Name = "paymentListButton";
            this.paymentListButton.Size = new System.Drawing.Size(111, 28);
            this.paymentListButton.TabIndex = 9;
            this.paymentListButton.Text = "Ödeme Listesi";
            this.paymentListButton.UseVisualStyleBackColor = false;
            this.paymentListButton.Click += new System.EventHandler(this.paymentListButton_Click);
            // 
            // newPaymentButton
            // 
            this.newPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.newPaymentButton.FlatAppearance.BorderSize = 0;
            this.newPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.newPaymentButton.ForeColor = System.Drawing.Color.White;
            this.newPaymentButton.Location = new System.Drawing.Point(143, 172);
            this.newPaymentButton.Name = "newPaymentButton";
            this.newPaymentButton.Size = new System.Drawing.Size(111, 28);
            this.newPaymentButton.TabIndex = 10;
            this.newPaymentButton.Text = "Yeni Ödeme";
            this.newPaymentButton.UseVisualStyleBackColor = false;
            this.newPaymentButton.Click += new System.EventHandler(this.newPaymentButton_Click);
            // 
            // deletePaymentButton
            // 
            this.deletePaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(76)))), ((int)(((byte)(82)))));
            this.deletePaymentButton.FlatAppearance.BorderSize = 0;
            this.deletePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deletePaymentButton.ForeColor = System.Drawing.Color.White;
            this.deletePaymentButton.Location = new System.Drawing.Point(267, 172);
            this.deletePaymentButton.Name = "deletePaymentButton";
            this.deletePaymentButton.Size = new System.Drawing.Size(111, 28);
            this.deletePaymentButton.TabIndex = 11;
            this.deletePaymentButton.Text = "Ödeme Sil";
            this.deletePaymentButton.UseVisualStyleBackColor = false;
            this.deletePaymentButton.Click += new System.EventHandler(this.deletePaymentButton_Click);
            // 
            // updatePaymentButton
            // 
            this.updatePaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.updatePaymentButton.FlatAppearance.BorderSize = 0;
            this.updatePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.updatePaymentButton.ForeColor = System.Drawing.Color.White;
            this.updatePaymentButton.Location = new System.Drawing.Point(392, 172);
            this.updatePaymentButton.Name = "updatePaymentButton";
            this.updatePaymentButton.Size = new System.Drawing.Size(124, 28);
            this.updatePaymentButton.TabIndex = 12;
            this.updatePaymentButton.Text = "Ödeme Güncelle";
            this.updatePaymentButton.UseVisualStyleBackColor = false;
            this.updatePaymentButton.Click += new System.EventHandler(this.updatePaymentButton_Click);
            // 
            // paymentsGroupBox
            // 
            this.paymentsGroupBox.BackColor = System.Drawing.Color.White;
            this.paymentsGroupBox.Controls.Add(this.paymentsDataGridView);
            this.paymentsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.paymentsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(101)))));
            this.paymentsGroupBox.Location = new System.Drawing.Point(244, 295);
            this.paymentsGroupBox.Name = "paymentsGroupBox";
            this.paymentsGroupBox.Size = new System.Drawing.Size(677, 230);
            this.paymentsGroupBox.TabIndex = 0;
            this.paymentsGroupBox.TabStop = false;
            this.paymentsGroupBox.Text = "Ödeme Listesi";
            // 
            // paymentsDataGridView
            // 
            this.paymentsDataGridView.AllowUserToAddRows = false;
            this.paymentsDataGridView.AllowUserToDeleteRows = false;
            this.paymentsDataGridView.AllowUserToResizeRows = false;
            this.paymentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.paymentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.paymentsDataGridView.ColumnHeadersHeight = 34;
            this.paymentsDataGridView.EnableHeadersVisualStyles = false;
            this.paymentsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.paymentsDataGridView.Location = new System.Drawing.Point(15, 42);
            this.paymentsDataGridView.MultiSelect = false;
            this.paymentsDataGridView.Name = "paymentsDataGridView";
            this.paymentsDataGridView.ReadOnly = true;
            this.paymentsDataGridView.RowHeadersVisible = false;
            this.paymentsDataGridView.RowTemplate.Height = 30;
            this.paymentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentsDataGridView.Size = new System.Drawing.Size(662, 175);
            this.paymentsDataGridView.TabIndex = 0;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.paymentsGroupBox);
            this.Controls.Add(this.paymentFormPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Yönetimi";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.paymentFormPanel.ResumeLayout(false);
            this.paymentFormPanel.PerformLayout();
            this.paymentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).EndInit();
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
        private System.Windows.Forms.Panel paymentFormPanel;
        private System.Windows.Forms.Label paymentTitleLabel;
        private System.Windows.Forms.Label paymentIdLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.TextBox txtPaymentTitle;
        private System.Windows.Forms.TextBox txtPaymentPeriod;
        private System.Windows.Forms.Button paymentListButton;
        private System.Windows.Forms.Button newPaymentButton;
        private System.Windows.Forms.Button deletePaymentButton;
        private System.Windows.Forms.Button updatePaymentButton;
        private System.Windows.Forms.Button findPaymentButton;
        private System.Windows.Forms.GroupBox paymentsGroupBox;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtPaymentAmount;
    }
}