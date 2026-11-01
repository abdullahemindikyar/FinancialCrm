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
            dashboardButton.Click += dashboardButton_Click;
            invoicesButton.Click += invoicesButton_Click;
            settingsButton.Click += settingsButton_Click;
            logoutButton.Click += logoutButton_Click;
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

            ziraatBalanceLabel.Text = ziraatBankBalance.ToString() + " ₺";
            vakifBalanceLabel.Text = vakifBankBalance.ToString() + " ₺";
            isBalanceLabel.Text = isBankBalance.ToString() + " ₺";

            // Banka hareketleri 
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            transaction1Label.Text = bankProcess1.Description + " - " + bankProcess1.Amount.ToString() + " ₺" +  bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(1).Take(1).FirstOrDefault();
            transaction2Label.Text = bankProcess2.Description + " - " + bankProcess2.Amount.ToString() + " ₺" + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(2).Take(1).FirstOrDefault();
            transaction3Label.Text = bankProcess3.Description + " - " + bankProcess3.Amount.ToString() + " ₺" + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(3).Take(1).FirstOrDefault();
            transaction4Label.Text = bankProcess4.Description + " - " + bankProcess4.Amount.ToString() + " ₺" + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(4).Take(1).FirstOrDefault();
            transaction5Label.Text = bankProcess5.Description + " - " + bankProcess5.Amount.ToString() + " ₺" + bankProcess5.ProcessDate;
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
