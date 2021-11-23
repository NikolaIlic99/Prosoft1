using AppLogic;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Controller controller = Controller.Instance;
            Producent current = controller.VratiUlogovanog();
            this.Text = "Welcome " + current.Firstname;
            lblNamePlaceholder.Text = current.Firstname + " " + current.Lastname;
            dataGridView1.DataSource = controller.VratiSveEmisije(current);

        }

        private void btnNovaEmisija_Click(object sender, EventArgs e)
        {
            frmDodajEmisiju frm = new frmDodajEmisiju();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Controller controller = Controller.Instance;
                controller.UnesiNovuEmisiju(frm.emisija);
                ReloadForm();
            }


        }
        private void ReloadForm()
        {

            Controller controller = Controller.Instance;
            Producent current = controller.VratiUlogovanog();
            dataGridView1.DataSource = controller.VratiSveEmisije(current);
            
        }
    }
}
