using Komis_Samochodowy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis_Samochodowy_App
{
    public partial class Klienci : Form
    {

        Komis_samochodowy_klienci komis_klienci;

        public Klienci(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_klienci = new Komis_samochodowy_klienci(komis);
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
            var lista = komis_klienci.Lista_Wszystkich_Klientow();
            data_klienci.DataSource = lista.ToList();
        }
    }
}
