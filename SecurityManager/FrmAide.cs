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
    public partial class FrmAide : Form
    {
        public FrmAide()
        {
            InitializeComponent();
        }

        private void BtnErreur0x1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Security Manager ne parvient pas a trouver le dossier nécessaire a son bon fonctionnement il est necessaire de faire une rénitialisation de l'application (CTRL + F3) au démarage l'application ou dans le menu paramètres.", "Erreur: 0x1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmAide_Load(object sender, EventArgs e)
        {
            Animation.Start();
        }

    
    }
}
