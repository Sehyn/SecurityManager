
namespace SecurityManager
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.BtnClose = new Siticone.UI.WinForms.SiticoneControlBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.DragCtrl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMotDePasse = new Siticone.UI.WinForms.SiticoneTextBox();
            this.TxtNomUtilisateur = new Siticone.UI.WinForms.SiticoneTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnConnexion = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gunaPanel1.Size = new System.Drawing.Size(464, 41);
            this.gunaPanel1.TabIndex = 8;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 13);
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
            this.siticoneControlBox2.Location = new System.Drawing.Point(365, 3);
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
            this.BtnClose.Location = new System.Drawing.Point(416, 3);
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
            this.gunaSeparator1.Size = new System.Drawing.Size(577, 10);
            this.gunaSeparator1.TabIndex = 2;
            // 
            // DragCtrl
            // 
            this.DragCtrl.TargetControl = this;
            // 
            // Animate
            // 
            this.Animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.Animate.Interval = 800;
            this.Animate.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConnexion);
            this.groupBox1.Controls.Add(this.TxtMotDePasse);
            this.groupBox1.Controls.Add(this.TxtNomUtilisateur);
            this.groupBox1.Location = new System.Drawing.Point(47, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 154);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion:";
            // 
            // TxtMotDePasse
            // 
            this.TxtMotDePasse.Animated = false;
            this.TxtMotDePasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMotDePasse.DefaultText = "";
            this.TxtMotDePasse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMotDePasse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMotDePasse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMotDePasse.DisabledState.Parent = this.TxtMotDePasse;
            this.TxtMotDePasse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMotDePasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMotDePasse.FocusedState.Parent = this.TxtMotDePasse;
            this.TxtMotDePasse.ForeColor = System.Drawing.Color.Gray;
            this.TxtMotDePasse.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMotDePasse.HoveredState.Parent = this.TxtMotDePasse;
            this.TxtMotDePasse.Location = new System.Drawing.Point(16, 65);
            this.TxtMotDePasse.Name = "TxtMotDePasse";
            this.TxtMotDePasse.PasswordChar = '\0';
            this.TxtMotDePasse.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtMotDePasse.PlaceholderText = "Mot de passe..";
            this.TxtMotDePasse.SelectedText = "";
            this.TxtMotDePasse.ShadowDecoration.Parent = this.TxtMotDePasse;
            this.TxtMotDePasse.Size = new System.Drawing.Size(312, 31);
            this.TxtMotDePasse.TabIndex = 17;
            // 
            // TxtNomUtilisateur
            // 
            this.TxtNomUtilisateur.Animated = false;
            this.TxtNomUtilisateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNomUtilisateur.DefaultText = "";
            this.TxtNomUtilisateur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNomUtilisateur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNomUtilisateur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNomUtilisateur.DisabledState.Parent = this.TxtNomUtilisateur;
            this.TxtNomUtilisateur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNomUtilisateur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNomUtilisateur.FocusedState.Parent = this.TxtNomUtilisateur;
            this.TxtNomUtilisateur.ForeColor = System.Drawing.Color.Gray;
            this.TxtNomUtilisateur.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNomUtilisateur.HoveredState.Parent = this.TxtNomUtilisateur;
            this.TxtNomUtilisateur.Location = new System.Drawing.Point(16, 28);
            this.TxtNomUtilisateur.Name = "TxtNomUtilisateur";
            this.TxtNomUtilisateur.PasswordChar = '\0';
            this.TxtNomUtilisateur.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtNomUtilisateur.PlaceholderText = "Nom d\'utilisateur..";
            this.TxtNomUtilisateur.SelectedText = "";
            this.TxtNomUtilisateur.ShadowDecoration.Parent = this.TxtNomUtilisateur;
            this.TxtNomUtilisateur.Size = new System.Drawing.Size(312, 31);
            this.TxtNomUtilisateur.TabIndex = 16;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(421, 218);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel2.TabIndex = 30;
            this.gunaLabel2.Text = "v.0.0.1";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.AnimationHoverSpeed = 0.07F;
            this.BtnConnexion.AnimationSpeed = 0.03F;
            this.BtnConnexion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnConnexion.BorderColor = System.Drawing.Color.Black;
            this.BtnConnexion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnConnexion.FocusedColor = System.Drawing.Color.Empty;
            this.BtnConnexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnConnexion.ForeColor = System.Drawing.Color.White;
            this.BtnConnexion.Image = ((System.Drawing.Image)(resources.GetObject("BtnConnexion.Image")));
            this.BtnConnexion.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnConnexion.Location = new System.Drawing.Point(16, 101);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnConnexion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnConnexion.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnConnexion.OnHoverImage = null;
            this.BtnConnexion.OnPressedColor = System.Drawing.Color.Black;
            this.BtnConnexion.Size = new System.Drawing.Size(312, 31);
            this.BtnConnexion.TabIndex = 18;
            this.BtnConnexion.Text = "S\'authentifier";
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 236);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Manager (SM.0.0.1) - W.I.P";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox BtnClose;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaDragControl DragCtrl;
        public Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton BtnConnexion;
        private Siticone.UI.WinForms.SiticoneTextBox TxtMotDePasse;
        private Siticone.UI.WinForms.SiticoneTextBox TxtNomUtilisateur;
    }
}

