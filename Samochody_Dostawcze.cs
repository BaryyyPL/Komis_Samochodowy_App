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
    public partial class Samochody_Dostawcze : Form
    {

        Komis_samochodowy_samochody_dostawcze komis_dostawcze;

        public Samochody_Dostawcze(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_dostawcze = new Komis_samochodowy_samochody_dostawcze(komis);
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
            var lista = komis_dostawcze.Lista_Wszystkich_Samochodow_Dostawczych();
            data_samochody_dostawcze.DataSource = lista.ToList();
        }
    }
}
