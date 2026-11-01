using FinancalCrm.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinancalCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            #region
            InitializeComponent();
            btnDashboard.Click += dashboardButton_Click;
            btnBilling.Click += invoicesButton_Click;
            btnSettings.Click += settingsButton_Click;
            btnLogout.Click += logoutButton_Click;
            #endregion
        }

        private void ConfigureNavigationButton(Button button, string text, int top)
        {
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 10F);
            button.ForeColor = Color.FromArgb(224, 232, 242);
            button.Location = new Point(18, top);
            button.Size = new Size(184, 38);
            button.Text = text;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(14, 0, 0, 0);
            button.UseVisualStyleBackColor = false;
        }

        private void ConfigureBankCard(Panel card, Label name, Label balance, string title, int left, Color color)
        {
            card.BackColor = color;
            card.Cursor = Cursors.Hand;
            card.Tag = title;
            card.Click += BankCard_Click;
            card.Controls.Add(balance);
            card.Controls.Add(name);
            card.Location = new Point(left, 170);
            card.Size = new Size(214, 110);
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            name.ForeColor = Color.White;
            name.Location = new Point(16, 13);
            name.Text = title;
            balance.AutoSize = true;
            balance.Font = new Font("Segoe UI Semibold", 27F, FontStyle.Bold);
            balance.ForeColor = Color.White;
            balance.Location = new Point(15, 44);
            balance.Text = "0.00 ₺";
            balance.Cursor = Cursors.Hand;
            balance.Tag = title;
            balance.Click += BankCard_Click;
            name.Cursor = Cursors.Hand;
            name.Tag = title;
            name.Click += BankCard_Click;
        }

        private void BankCard_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            string bankName = clickedControl != null ? clickedControl.Tag as string : null;

            if (!string.IsNullOrEmpty(bankName))
            {
                MessageBox.Show(bankName + " seçildi.", "Banka Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {

            // Banka bakiye bilgilerini veritabanından çekme
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();

            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();

            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBalance.Text = Convert.ToDecimal(ziraatBankBalance).ToString("N2") + " ₺";
            lblVakifBalance.Text = Convert.ToDecimal(vakifBankBalance).ToString("N2") + " ₺";
            lblIsBalance.Text = Convert.ToDecimal(isBankBalance).ToString("N2") + " ₺";

            // Banka hareketleri 
            dgvBankTransactions.Rows.Clear();
            foreach (var process in db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5))
            {
                dgvBankTransactions.Rows.Add(
                    process.Banks == null ? "Banka" : process.Banks.BankTitle,
                    process.Description,
                    Convert.ToDecimal(process.Amount).ToString("N2") + " ₺",
                    process.ProcessDate.HasValue ? process.ProcessDate.Value.ToString("dd.MM.yyyy") : "-");
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDashboard().ShowDialog();
            Show();
        }

        private void invoicesButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmBilling().ShowDialog();
            Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmSettings().ShowDialog();
            Show();
        }

    }
}
