namespace FinancalCrm
{
    partial class FrmSettings
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
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.lightThemeButton = new System.Windows.Forms.Button();
            this.darkThemeButton = new System.Windows.Forms.Button();
            this.fontLabel = new System.Windows.Forms.Label();
            this.biggerFontButton = new System.Windows.Forms.Button();
            this.smallerFontButton = new System.Windows.Forms.Button();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.Controls.Add(this.titleLabel);
            this.settingsPanel.Controls.Add(this.themeLabel);
            this.settingsPanel.Controls.Add(this.lightThemeButton);
            this.settingsPanel.Controls.Add(this.darkThemeButton);
            this.settingsPanel.Controls.Add(this.fontLabel);
            this.settingsPanel.Controls.Add(this.biggerFontButton);
            this.settingsPanel.Controls.Add(this.smallerFontButton);
            this.settingsPanel.Controls.Add(this.uptimeLabel);
            this.settingsPanel.Location = new System.Drawing.Point(20, 20);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(560, 300);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(30, 48, 77);
            this.titleLabel.Location = new System.Drawing.Point(24, 22);
            this.titleLabel.Text = "Ayarlar";
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.themeLabel.Location = new System.Drawing.Point(26, 78);
            this.themeLabel.Text = "Tema";
            // 
            // lightThemeButton
            // 
            this.lightThemeButton.BackColor = System.Drawing.Color.FromArgb(43, 111, 220);
            this.lightThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightThemeButton.ForeColor = System.Drawing.Color.White;
            this.lightThemeButton.Location = new System.Drawing.Point(130, 73);
            this.lightThemeButton.Size = new System.Drawing.Size(110, 30);
            this.lightThemeButton.Text = "Gündüz";
            this.lightThemeButton.UseVisualStyleBackColor = false;
            this.lightThemeButton.Click += new System.EventHandler(this.lightThemeButton_Click);
            // 
            // darkThemeButton
            // 
            this.darkThemeButton.BackColor = System.Drawing.Color.FromArgb(35, 38, 45);
            this.darkThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkThemeButton.ForeColor = System.Drawing.Color.White;
            this.darkThemeButton.Location = new System.Drawing.Point(250, 73);
            this.darkThemeButton.Size = new System.Drawing.Size(110, 30);
            this.darkThemeButton.Text = "Gece";
            this.darkThemeButton.UseVisualStyleBackColor = false;
            this.darkThemeButton.Click += new System.EventHandler(this.darkThemeButton_Click);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fontLabel.Location = new System.Drawing.Point(26, 126);
            this.fontLabel.Text = "Yazı boyutu";
            // 
            // biggerFontButton
            // 
            this.biggerFontButton.Location = new System.Drawing.Point(130, 121);
            this.biggerFontButton.Size = new System.Drawing.Size(110, 30);
            this.biggerFontButton.Text = "Büyüt";
            this.biggerFontButton.Click += new System.EventHandler(this.biggerFontButton_Click);
            // 
            // smallerFontButton
            // 
            this.smallerFontButton.Location = new System.Drawing.Point(250, 121);
            this.smallerFontButton.Size = new System.Drawing.Size(110, 30);
            this.smallerFontButton.Text = "Küçült";
            this.smallerFontButton.Click += new System.EventHandler(this.smallerFontButton_Click);
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.uptimeLabel.Location = new System.Drawing.Point(26, 190);
            this.uptimeLabel.Text = "Uygulama açık kalma süresi: 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSettings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 252);
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.settingsPanel);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Button lightThemeButton;
        private System.Windows.Forms.Button darkThemeButton;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Button biggerFontButton;
        private System.Windows.Forms.Button smallerFontButton;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
