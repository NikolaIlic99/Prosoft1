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
    public partial class frmDodajEmisiju : Form
    {
        public Emisija emisija;
        BindingList<Angazovanje> angazovanjelista = new BindingList<Angazovanje>();

        public frmDodajEmisiju()
        {
            InitializeComponent();
            Controller controller = Controller.Instance;
            cmbVoditelj.DataSource = controller.VratiSveRadnike();
            cmbRadnik.DataSource = controller.VratiSveRadnike();
            cmbVrstaAngazovanja.DataSource = new List<string>(Enum.GetNames(typeof(VrstaAngazovanja)));
            dgvAngazovanja.DataSource = angazovanjelista;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.Instance;

            Emisija nova = new Emisija
            {
                Naziv = txtNaziv.Text,
                VremePocetka = pickerVremePocetka.Value,
                VremeZavrsetka = pickerVremeZavrsetka.Value,
                Producent = controller.VratiUlogovanog(),
                Voditelj = (Radnik)cmbVoditelj.SelectedItem,
                Angazovanja = angazovanjelista.ToList()
                
                
            };
            emisija = nova;
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnDodajAngazovanje_Click(object sender, EventArgs e)
        {
            Angazovanje novoAngazovanje = new Angazovanje
            {
                VrstaAngazovanja = EnumParser(),
                OpisPosla = txtOpis.Text,
                Trajanje = Int32.Parse(txtTrajanje.Text),
                Radnik=(Radnik)cmbRadnik.SelectedItem
                

            };
            angazovanjelista.Add(novoAngazovanje);
        }

        private VrstaAngazovanja EnumParser()
        {
            if (cmbVrstaAngazovanja.SelectedItem.Equals("Administracija"))
                return VrstaAngazovanja.Administracija;
            if (cmbVrstaAngazovanja.SelectedItem.Equals("Tehnika"))
                return VrstaAngazovanja.Tehnika;
            else 
                return VrstaAngazovanja.Rezija;
            
        }
    }
}
