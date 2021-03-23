using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManager
{
    public partial class FrmUtilisateur : Form
    {
        public FrmUtilisateur()
        {



            InitializeComponent();
            try
            {


                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Historique connexion", DateTime.Now.ToString("dd-MM-yyyy") + "- Historique.txt"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] - Connexion de l'agent: " + LblUtilisateur.Text);
                }
                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante", DateTime.Now.ToString("dd-MM-yyyy") + "- Main Courante.txt"), true))
                {
                    tw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
                    tw.WriteLine("[ MAIN COURANTE " + DateTime.Now + " ] Par: " + LblUtilisateur.Text);
                    tw.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");


                }
            }
            catch (DirectoryNotFoundException)
            {
                this.Alert("Erreur: 0x1", FrmNotification.AlertTypeEnum.Error);

            }
            catch (Exception ex)
            {
                this.Alert("Erreur: Voir fichier Exceptions.log.", FrmNotification.AlertTypeEnum.Error);

                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Exceptions", DateTime.Now.ToString("dd-MM-yyyy") + "- Exceptions.log"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] - Erreur: " + ex.Message);
                }

            }

        }

        public void Alert(string msg, FrmNotification.AlertTypeEnum type)
        {
            FrmNotification f = new FrmNotification();
            f.setAlert(msg, type);
        }


        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Alert("Deconnexion en cours..", FrmNotification.AlertTypeEnum.Warning);

            try
            {
                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Historique connexion", DateTime.Now.ToString("dd-MM-yyyy") + "- Historique.txt"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] - Deconnexion de l'agent: " + LblUtilisateur.Text);
                }
                FrmConnexion FormConnexion = new FrmConnexion();

                this.Hide();
                FormConnexion.Show();
            }
            catch (DirectoryNotFoundException)
            {
                this.Alert("Erreur: 0x1", FrmNotification.AlertTypeEnum.Error);

            }
            catch (Exception ex)
            {
                this.Alert("Erreur: Voir fichier Exceptions.log.", FrmNotification.AlertTypeEnum.Error);

                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Exceptions", DateTime.Now.ToString("dd-MM-yyyy") + "- Exceptions.log"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] - Erreur: " + ex.Message);
                }
            }

        }



        private void BtnMainCourante_Click(object sender, EventArgs e)
        {
            try
            {


                TxtMainCourante.Text = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante", DateTime.Now.ToString("dd-MM-yyyy") + "- Main Courante.txt"));
                PanelConsignes.Visible = false;
                BtnMainCourante.Enabled = false;
                BtnPriseDeService.Enabled = true;
                PanelPriseDeService.Visible = false;
                PanelMainCourante.Visible = true;
                TxtMainCourante.AppendText(TxtMainCourante.Text);

            }
            catch (DirectoryNotFoundException)
            {
                this.Alert("Erreur: 0x1", FrmNotification.AlertTypeEnum.Error);

            }
            catch (Exception ex)
            {
                this.Alert("Erreur: Voir fichier Exceptions.log.", FrmNotification.AlertTypeEnum.Error);

                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Exceptions", DateTime.Now.ToString("dd-MM-yyyy") + "- Exceptions.log"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] - Erreur: " + ex.Message);
                }
            }

        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {

            PanelConsignes.Visible = true;
            BtnMainCourante.Enabled = true;
            BtnPriseDeService.Enabled = true;
            PanelMainCourante.Visible = false;
            PanelPriseDeService.Visible = false;

        }

        private void BtnAjoutEvenement_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante", DateTime.Now.ToString("dd-MM-yyyy") + "- Main Courante.txt"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] -  " + TxtMainCouranteAjout.Text);


                }

                TxtMainCourante.Text = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante", DateTime.Now.ToString("dd-MM-yyyy") + "- Main Courante.txt"));
                TxtMainCouranteAjout.Text = null;
                TxtMainCourante.AppendText(TxtMainCourante.Text);

            }
            catch (DirectoryNotFoundException)
            {
                this.Alert("Erreur: 0x1", FrmNotification.AlertTypeEnum.Error);

            }
            catch (Exception ex)
            {
                this.Alert("Erreur: Voir fichier Exceptions.log.", FrmNotification.AlertTypeEnum.Error);

                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Exceptions", DateTime.Now.ToString("dd-MM-yyyy") + "- Exceptions.log"), true))
                {
                    tw.WriteLine("[" + DateTime.Now + "] - Erreur: " + ex.Message);
                }
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmUtilisateur_Load_1(object sender, EventArgs e)
        {
            Animation.Start();
        }

        private void BtnAide_Click_1(object sender, EventArgs e)
        {
            FrmAide FormAide = new FrmAide();
            FormAide.Show();
        }

        private void BtnPriseDeService_Click(object sender, EventArgs e)
        {
            PanelConsignes.Visible = false;
            PanelMainCourante.Visible = false;
            PanelPriseDeService.Visible = true;
            BtnPriseDeService.Enabled = false;
            BtnMainCourante.Enabled = true;
        }
    }
}
