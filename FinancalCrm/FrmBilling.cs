using FinancalCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancalCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            #region
            InitializeComponent();
            dashboardButton.Click += dashboardButton_Click;
            banksButton.Click += banksButton_Click;
            settingsButton.Click += settingsButton_Click;
            logoutButton.Click += logoutButton_Click;
            #endregion
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            paymentsDataGridView.DataSource = values;
        }

        private void paymentListButton_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            paymentsDataGridView.DataSource = values;
        }

        private void newPaymentButton_Click(object sender, EventArgs e)
        {
            Bills newBill = new Bills
            {
                BillTitle = txtPaymentTitle.Text,
                BillAmount = Convert.ToDecimal(txtPaymentAmount.Text),
                BillPeriod = txtPaymentPeriod.Text
            };

            db.Bills.Add(newBill);
            db.SaveChanges();

            var values = db.Bills.ToList();
            paymentsDataGridView.DataSource = values;
            MessageBox.Show("Ödeme eklendi.");

        }

        private void findPaymentButton_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtPaymentId.Text, out id))
            {
                MessageBox.Show("Geçerli bir ödeme ID'si giriniz.");
                return;
            }

            var value = db.Bills.Where(x => x.BillId == id).FirstOrDefault();

            if (value == null)
            {
                MessageBox.Show("Bu ID'ye ait ödeme bulunamadı.");
                return;
            }

            txtPaymentTitle.Text = value.BillTitle;
            txtPaymentAmount.Text = value.BillAmount.ToString();
            txtPaymentPeriod.Text = value.BillPeriod;

        }

        private void updatePaymentButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtPaymentId.Text);
            var value = db.Bills.Where(x => x.BillId == id).FirstOrDefault();

            value.BillTitle = txtPaymentTitle.Text;
            value.BillAmount = Convert.ToDecimal(txtPaymentAmount.Text);
            value.BillPeriod = txtPaymentPeriod.Text;
            db.SaveChanges();

            var values = db.Bills.ToList();
            paymentsDataGridView.DataSource = values;
            MessageBox.Show("Ödeme güncellendi.");
        }

        private void deletePaymentButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtPaymentId.Text);
            var value = db.Bills.Where(x => x.BillId == id).FirstOrDefault();

            db.Bills.Remove(value);
            db.SaveChanges();

            var values = db.Bills.ToList();
            paymentsDataGridView.DataSource = values;
            MessageBox.Show("Ödeme silindi.");
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDashboard().ShowDialog();
            Show();
        }

        private void banksButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmBanks().ShowDialog();
            Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmSettings().ShowDialog();
            Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
