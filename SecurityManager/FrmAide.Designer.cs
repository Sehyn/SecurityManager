
namespace SecurityManager
{
    partial class FrmAide
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.BtnClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.BtnErreur0x1 = new Siticone.UI.WinForms.SiticoneButton();
            this.Animation = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.gunaPanel1.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.siticoneControlBox2);
            this.gunaPanel1.Controls.Add(this.BtnClose);
            this.gunaPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(599, 41);
            this.gunaPanel1.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(207, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(186, 15);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Security Manager (SM - 0.0.1) WIP";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(500, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BorderRadius = 10;
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.BtnClose.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.BtnClose.HoveredState.IconColor = System.Drawing.Color.White;
            this.BtnClose.HoveredState.Parent = this.BtnClose;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(551, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(45, 29);
            this.BtnClose.TabIndex = 3;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 31);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(800, 10);
            this.gunaSeparator1.TabIndex = 2;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.BtnErreur0x1);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(0, 47);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(599, 239);
            this.siticoneGroupBox1.TabIndex = 11;
            this.siticoneGroupBox1.Text = "Centre d\'aide Security Manager";
            // 
            // BtnErreur0x1
            // 
            this.BtnErreur0x1.CheckedState.Parent = this.BtnErreur0x1;
            this.BtnErreur0x1.CustomImages.Parent = this.BtnErreur0x1;
            this.BtnErreur0x1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnErreur0x1.ForeColor = System.Drawing.Color.White;
            this.BtnErreur0x1.HoveredState.Parent = this.BtnErreur0x1;
            this.BtnErreur0x1.Location = new System.Drawing.Point(12, 48);
            this.BtnErreur0x1.Name = "BtnErreur0x1";
            this.BtnErreur0x1.ShadowDecoration.Parent = this.BtnErreur0x1;
            this.BtnErreur0x1.Size = new System.Drawing.Size(575, 45);
            this.BtnErreur0x1.TabIndex = 0;
            this.BtnErreur0x1.Text = "Erreur: 0x1";
            this.BtnErreur0x1.Click += new System.EventHandler(this.BtnErreur0x1_Click);
            // 
            // Animation
            // 
            this.Animation.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.Animation.Interval = 800;
            this.Animation.TargetControl = this;
            // 
            // FrmAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 369);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAide";
            this.Load += new System.EventHandler(this.FrmAide_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox BtnClose;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.UI.WinForms.SiticoneButton BtnErreur0x1;
        public Guna.UI.WinForms.GunaAnimateWindow Animation;
    }
}