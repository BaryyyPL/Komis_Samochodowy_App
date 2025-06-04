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

            data_samochody_osobowe.Columns["Marka"].DisplayIndex = 0;
            data_samochody_osobowe.Columns["Model"].DisplayIndex = 1;
            data_samochody_osobowe.Columns["Rok_Produkcji"].DisplayIndex = 2;
            data_samochody_osobowe.Columns["Cena"].DisplayIndex = 3;
            data_samochody_osobowe.Columns["Rodzaj_Nadwozia"].DisplayIndex = 4;
            data_samochody_osobowe.Columns["Przebieg"].DisplayIndex = 5;
            data_samochody_osobowe.Columns["Vin"].DisplayIndex = 6;
            data_samochody_osobowe.Columns["Pojemnosc_Silnika"].DisplayIndex = 7;
            data_samochody_osobowe.Columns["Moc"].DisplayIndex = 8;
            data_samochody_osobowe.Columns["Rodzaj_Paliwa"].DisplayIndex = 9;
            data_samochody_osobowe.Columns["Rodzaj_Napedu"].DisplayIndex = 10;
            data_samochody_osobowe.Columns["Skrzynia_Biegow"].DisplayIndex = 11;
            data_samochody_osobowe.Columns["Kraj_Pochodzenia"].DisplayIndex = 12;
            data_samochody_osobowe.Columns["Nieuszkodzony"].DisplayIndex = 13;
            data_samochody_osobowe.Columns["Sprzedany"].DisplayIndex = 14;
            data_samochody_osobowe.Columns["Wlasciciel"].DisplayIndex = 15;
        }
    }
}
