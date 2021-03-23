using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManager
{
    public partial class FrmConnexion : Form
    {

        public bool LoginFlag { get; set; }

        public FrmConnexion()
        {
            InitializeComponent();
            LoginFlag = false;


        }

        public void Alert(string msg, FrmNotification.AlertTypeEnum type)
        {
            FrmNotification f = new FrmNotification();
            f.setAlert(msg, type);
        }


        private void Connexion_Load(object sender, EventArgs e)
        {
            Animate.Start();

        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {

            DB_SMTableAdapters.UsersTableAdapter userAda = new DB_SMTableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPassword(TxtNomUtilisateur.Text, TxtMotDePasse.Text);
            if (dt.Rows.Count > 0)
            {
                this.Alert("Connecté en tant que: "+TxtNomUtilisateur.Text, FrmNotification.AlertTypeEnum.Success);
                LoginFlag = true;
                FrmUtilisateur FormUtilisateur = new FrmUtilisateur();
                this.Hide();
                FormUtilisateur.Show();
            }
            else
            {
                this.Alert("Utilisateur ou mot de passe incorrect!", FrmNotification.AlertTypeEnum.Error);
                TxtMotDePasse.Text = null;
                LoginFlag = false;

            }
    
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
