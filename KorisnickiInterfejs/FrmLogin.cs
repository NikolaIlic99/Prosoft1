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
    public partial class FrmLogin : Form
    {
        private static int brojac=0;
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "Nikola";
            txtPassword.Text = "nikola";
            txtPassword.PasswordChar = '*';

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (String.IsNullOrEmpty(username))
            {
                txtUsername.BackColor = Color.Salmon;
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                txtPassword.BackColor = Color.Salmon;
                return;
            }
            Controller controller = Controller.Instance;
            Producent p= controller.Login(username, password);
            if (p == null)
            {
                brojac++;
                MessageBox.Show("Pogresno uneseni username ili password");
                if (brojac == 3)
                {
                    MessageBox.Show("Prekoracen je broj pokusaja!");
                    this.Dispose();
                }
                return;
            }
            else
            {
                brojac = 0;
                MessageBox.Show("Dobrodosli "+p.Firstname);
                this.DialogResult = DialogResult.OK;
                return;
            }

        }
    }
}
