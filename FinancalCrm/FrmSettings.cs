using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinancalCrm
{
    public partial class FrmSettings : Form
    {
        DateTime startTime = DateTime.Now;

        public FrmSettings()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void lightThemeButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            settingsPanel.BackColor = Color.White;
            titleLabel.ForeColor = Color.FromArgb(30, 48, 77);
        }

        private void darkThemeButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(35, 38, 45);
            settingsPanel.BackColor = Color.FromArgb(48, 52, 60);
            titleLabel.ForeColor = Color.White;
        }

        private void biggerFontButton_Click(object sender, EventArgs e)
        {
            Font = new Font(Font.FontFamily, Font.Size + 1F);
        }

        private void smallerFontButton_Click(object sender, EventArgs e)
        {
            if (Font.Size > 8F)
                Font = new Font(Font.FontFamily, Font.Size - 1F);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = DateTime.Now - startTime;
            uptimeLabel.Text = "Uygulama açık kalma süresi: " + time.ToString(@"hh\:mm\:ss");
        }
    }
}
