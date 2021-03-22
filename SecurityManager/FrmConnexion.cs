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
        public FrmConnexion()
        {
            InitializeComponent();
#if DEBUG
            this.Alert("Mode Dev", FrmNotification.AlertTypeEnum.Warning);
#endif

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

       
    }
}
