using FinancalCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinancalCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            banksButton.Click += banksButton_Click;
            invoicesButton.Click += invoicesButton_Click;
            settingsButton.Click += settingsButton_Click;
            logoutButton.Click += logoutButton_Click;
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        List<Bills> bills;
        List<BankProcesses> bankProcesses;
        int count = 0;
        int processCount = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            bills = db.Bills.ToList();
            bankProcesses = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).ToList();
            ShowBill();
            ShowBankProcess();
            ShowCharts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowBill();
            ShowBankProcess();
        }

        private void ShowBill()
        {
            if (bills == null || bills.Count == 0)
            {
                lblBillTitle.Text = "Fatura bulunamadı";
                lblBillAmount.Text = "0 ₺";
                return;
            }

            var bill = bills[count];
            lblBillTitle.Text = bill.BillTitle;
            lblBillAmount.Text = bill.BillAmount.ToString() + " ₺";

            count++;
            if (count >= bills.Count)
                count = 0;
        }

        private void ShowBankProcess()
        {
            if (bankProcesses == null || bankProcesses.Count == 0)
            {
                isNameLabel.Text = "İşlem bulunamadı";
                isBalanceLabel.Text = "0 ₺";
                return;
            }

            var bankProcess = bankProcesses[processCount];
            isNameLabel.Text = bankProcess.Description;
            isBalanceLabel.Text = bankProcess.Amount.ToString() + " ₺";

            processCount++;
            if (processCount >= bankProcesses.Count)
                processCount = 0;
        }

        private void banksButton_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmBanks().ShowDialog();
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

        private void ShowCharts()
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[0].Name = "Banka Bakiyesi";
            chart1.Series[0].Points.Clear();

            foreach (var bank in db.Banks.ToList())
                chart1.Series[0].Points.AddXY(bank.BankTitle, bank.BankBalance);

            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart2.Series[0].Name = "Fatura Tutarı";
            chart2.Series[0].Points.Clear();

            foreach (var bill in db.Bills.ToList())
                chart2.Series[0].Points.AddXY(bill.BillTitle, bill.BillAmount);
        }

    }
}
