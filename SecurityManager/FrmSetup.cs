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
using System.Threading;

namespace SecurityManager
{
    public partial class FrmSetup : Form
    {
        public FrmSetup()
        {
            InitializeComponent();
        }



        private void SetupFR_Load(object sender, EventArgs e)
        {
            Animate.Start();
            Verification();



        }


        private async void Creation()
        {
            try
            {

                if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager")))
                {
                    LblStatus.Text = "Création dossier Security Manager dans C:/Documents..";
                    await Task.Delay(2000);
                    Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager"));
                    LblStatus.Text = "Dossier Security Manager crée [1/6]";
                    await Task.Delay(2000);


                    if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs")))
                    {
                        LblStatus.Text = "Création dossier Log dans C:/Documents/Security Manager..";
                        Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs"));
                        await Task.Delay(2000);

                        LblStatus.Text = "Dossier Logs crée [2/6]";
                        await Task.Delay(2000);

                        if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante")))
                        {
                            await Task.Delay(2000);
                            LblStatus.Text = "Création dossier Main Courante dans C:/Documents/Security Manager/Logs..";
                            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante"));
                            await Task.Delay(2000);
                            LblStatus.Text = "Dossier Main courante crée [3/6]";

                        }
                    }

                }
                else
                {
                    if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager")))
                    {
                        await Task.Delay(2000);
                        LblStatus.Text = "Dossier Security Manager existant! [1/6]";
                        if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs")))
                        {
                            await Task.Delay(2000);
                            LblStatus.Text = "Dossier Logs existant! [2/6]";
                            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante")))
                            {
                                await Task.Delay(2000);
                                LblStatus.Text = "Dossier Main Courante existant! [3/6]";
                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                LblStatus.Text = "Erreur: " + ex.Message;
            }

        }

        private async void Verification()
        {

            try
            {
                LblStatus.Text = "Vérification et mise à jour de Security Manager [1/7]";
                //Faire système de mise à jour + lbl qui montre version actuelle
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Update"));
                await Task.Delay(1000);
                LblStatus.Text = "Parametrage de Security Manager [2/7]";
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager"));
                await Task.Delay(750);
                LblStatus.Text = "Vérification et création des fichiers requis [3/7]";
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs"));
                await Task.Delay(750);
                LblStatus.Text = "Vérification et création des dossiers de sauvegarde [4/7]";
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Main Courante"));
                await Task.Delay(750);
                LblStatus.Text = "Vérification et création de la main courante électronique [5/7]";
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Controle Boutique"));
                await Task.Delay(750);
                LblStatus.Text = "Optimisation et finalisation.. [6/7]";
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs","Prises de service"));
                await Task.Delay(1050);
                LblStatus.Text = "L'équipe de Security Manager vous remercie! [7/7]";
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Historique connexion"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Security Manager", "Logs", "Exceptions"));

                await Task.Delay(1050);
                FrmConnexion F1 = new FrmConnexion();
                this.Hide();
                await Task.Delay(550);
                F1.Show();
    

            }
            catch (Exception ex)
            {
                LblStatus.ForeColor = Color.Red;
                LblStatus.Text = "Erreur: " + ex.Message;
            }


        }

        private void SetupFR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F3)
            {
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous rénitialiser l'application ?\r\nVous perdrez toutes les données non sauvegardées (Main courante, etc..)", "Rénitialiser ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LblStatus.ForeColor = Color.Blue;
                    LblStatus.Text = "[!] Rénitialisation en cours..";
                    //Code pour suppresion fichiers + parametres
                }
                else if (dialogResult == DialogResult.No)
                {
                    Verification();
                }
            }
        }
    }
}
