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
    public partial class Pracownicy : Form
    {

        Komis_samochodowy_pracownicy komis_pracownicy;

        public Pracownicy(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_pracownicy = new Komis_samochodowy_pracownicy(komis);
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
            var lista = komis_pracownicy.Lista_Wszystkich_Pracownikow();
            data_pracownicy.DataSource = lista.ToList();
        }
    }
}
