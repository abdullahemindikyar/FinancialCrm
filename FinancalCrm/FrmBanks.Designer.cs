namespace FinancalCrm
{
    partial class FrmBanks
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlZiraat;
        private System.Windows.Forms.Panel pnlVakıf;
        private System.Windows.Forms.Panel pnlIs;
        private System.Windows.Forms.Label lblZiraatTitle;
        private System.Windows.Forms.Label lblVakifTitle;
        private System.Windows.Forms.Label lblIsTitle;
        private System.Windows.Forms.Label lblZiraatBalance;
        private System.Windows.Forms.Label lblVakifBalance;
        private System.Windows.Forms.Label lblIsBalance;
        private System.Windows.Forms.GroupBox grpBankTransactions;
        private System.Windows.Forms.DataGridView dgvBankTransactions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button CreateNavButton(string name, string text, int top)
        {
            var button = new System.Windows.Forms.Button();
            button.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Segoe UI", 10F);
            button.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(16, top);
            button.Name = name;
            button.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            button.Size = new System.Drawing.Size(184, 38);
            button.Text = text;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.UseVisualStyleBackColor = false;
            return button;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlZiraat = new System.Windows.Forms.Panel();
            this.pnlVakıf = new System.Windows.Forms.Panel();
            this.pnlIs = new System.Windows.Forms.Panel();
            this.lblZiraatTitle = new System.Windows.Forms.Label();
            this.lblVakifTitle = new System.Windows.Forms.Label();
            this.lblIsTitle = new System.Windows.Forms.Label();
            this.lblZiraatBalance = new System.Windows.Forms.Label();
            this.lblVakifBalance = new System.Windows.Forms.Label();
            this.lblIsBalance = new System.Windows.Forms.Label();
            this.grpBankTransactions = new System.Windows.Forms.GroupBox();
            this.dgvBankTransactions = new System.Windows.Forms.DataGridView();
            this.btnCategories = CreateNavButton("btnCategories", "Kategoriler", 24);
            this.btnBanks = CreateNavButton("btnBanks", "Bankalar", 70);
            this.btnBilling = CreateNavButton("btnBilling", "Faturalar", 116);
            this.btnExpenses = CreateNavButton("btnExpenses", "Giderler", 162);
            this.btnTransactions = CreateNavButton("btnTransactions", "Banka Hareketleri", 208);
            this.btnDashboard = CreateNavButton("btnDashboard", "Dashboard", 254);
            this.btnSettings = CreateNavButton("btnSettings", "Ayarlar", 300);
            this.btnLogout = CreateNavButton("btnLogout", "Çıkış Yap", 346);
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpBankTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransactions)).BeginInit();
            this.SuspendLayout();
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1100, 82);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 48, 77);
            this.lblTitle.Location = new System.Drawing.Point(28, 12);
            this.lblTitle.Text = "Banka Yönetimi";
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 132, 150);
            this.lblSubtitle.Location = new System.Drawing.Point(31, 51);
            this.lblSubtitle.Text = "Hesaplarınızı ve banka hareketlerinizi tek ekrandan yönetin";
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(22, 43, 76);
            this.pnlSidebar.Controls.Add(this.btnCategories);
            this.pnlSidebar.Controls.Add(this.btnBanks);
            this.pnlSidebar.Controls.Add(this.btnBilling);
            this.pnlSidebar.Controls.Add(this.btnExpenses);
            this.pnlSidebar.Controls.Add(this.btnTransactions);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(216, 598);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.pnlContent.Controls.Add(this.pnlZiraat);
            this.pnlContent.Controls.Add(this.pnlVakıf);
            this.pnlContent.Controls.Add(this.pnlIs);
            this.pnlContent.Controls.Add(this.grpBankTransactions);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24, 24, 24, 20);
            this.pnlZiraat.BackColor = System.Drawing.Color.FromArgb(21, 174, 160);
            this.pnlZiraat.Location = new System.Drawing.Point(24, 24);
            this.pnlZiraat.Size = new System.Drawing.Size(260, 132);
            this.pnlZiraat.Controls.Add(this.lblZiraatTitle);
            this.pnlZiraat.Controls.Add(this.lblZiraatBalance);
            this.pnlVakıf.BackColor = System.Drawing.Color.FromArgb(48, 146, 218);
            this.pnlVakıf.Location = new System.Drawing.Point(300, 24);
            this.pnlVakıf.Size = new System.Drawing.Size(260, 132);
            this.pnlVakıf.Controls.Add(this.lblVakifTitle);
            this.pnlVakıf.Controls.Add(this.lblVakifBalance);
            this.pnlIs.BackColor = System.Drawing.Color.FromArgb(155, 91, 184);
            this.pnlIs.Location = new System.Drawing.Point(576, 24);
            this.pnlIs.Size = new System.Drawing.Size(260, 132);
            this.pnlIs.Controls.Add(this.lblIsTitle);
            this.pnlIs.Controls.Add(this.lblIsBalance);
            ConfigureCardLabels();
            this.grpBankTransactions.BackColor = System.Drawing.Color.White;
            this.grpBankTransactions.Controls.Add(this.dgvBankTransactions);
            this.grpBankTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpBankTransactions.Location = new System.Drawing.Point(24, 178);
            this.grpBankTransactions.Size = new System.Drawing.Size(812, 370);
            this.grpBankTransactions.Text = "Son Banka Hareketleri";
            this.dgvBankTransactions.AllowUserToAddRows = false;
            this.dgvBankTransactions.AllowUserToDeleteRows = false;
            this.dgvBankTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBankTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvBankTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBankTransactions.ColumnHeadersHeight = 38;
            this.dgvBankTransactions.Location = new System.Drawing.Point(16, 29);
            this.dgvBankTransactions.ReadOnly = true;
            this.dgvBankTransactions.RowHeadersVisible = false;
            this.dgvBankTransactions.Size = new System.Drawing.Size(780, 325);
            this.dgvBankTransactions.Columns.Add("colBank", "Banka");
            this.dgvBankTransactions.Columns.Add("colDescription", "Açıklama");
            this.dgvBankTransactions.Columns.Add("colAmount", "Tutar");
            this.dgvBankTransactions.Columns.Add("colDate", "Tarih");
            this.dgvBankTransactions.Rows.Add("Ziraat Bankası", "Hesap hareketi", "0,00 ₺", "-");
            this.dgvBankTransactions.Rows.Add("VakıfBank", "Hesap hareketi", "0,00 ₺", "-");
            this.dgvBankTransactions.Rows.Add("İş Bankası", "Hesap hareketi", "0,00 ₺", "-");
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(920, 600);
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Yönetimi";
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.grpBankTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransactions)).EndInit();
            this.ResumeLayout(false);
        }

        private void ConfigureCardLabels()
        {
            ConfigureCardLabel(this.lblZiraatTitle, "Ziraat Bankası", 16, 14);
            ConfigureCardLabel(this.lblVakifTitle, "VakıfBank", 16, 14);
            ConfigureCardLabel(this.lblIsTitle, "İş Bankası", 16, 14);
            ConfigureBalanceLabel(this.lblZiraatBalance, 16, 49);
            ConfigureBalanceLabel(this.lblVakifBalance, 16, 49);
            ConfigureBalanceLabel(this.lblIsBalance, 16, 49);
        }

        private void ConfigureCardLabel(System.Windows.Forms.Label label, string text, int left, int top)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(left, top);
            label.Text = text;
        }

        private void ConfigureBalanceLabel(System.Windows.Forms.Label label, int left, int top)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(left, top);
            label.Text = "0,00 ₺";
        }
    }
}