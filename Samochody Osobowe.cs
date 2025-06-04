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
    public partial class Samochody_Osobowe : Form
    {

        Komis_samochodowy_samochody_osobowe komis_osobowe;

        public Samochody_Osobowe(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_osobowe = new Komis_samochodowy_samochody_osobowe(komis);
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
            var lista = komis_osobowe.Lista_Wszystkich_Samochodow_Osobowych();
            data_samochody_osobowe.DataSource = lista.ToList();
        }
    }
}
