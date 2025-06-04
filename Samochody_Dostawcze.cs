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

            data_samochody_dostawcze.Columns["Marka"].DisplayIndex = 0;
            data_samochody_dostawcze.Columns["Model"].DisplayIndex = 1;
            data_samochody_dostawcze.Columns["Rok_Produkcji"].DisplayIndex = 2;
            data_samochody_dostawcze.Columns["Cena"].DisplayIndex = 3;
            data_samochody_dostawcze.Columns["Rodzaj_Zabudowy"].DisplayIndex = 4;
            data_samochody_dostawcze.Columns["Przebieg"].DisplayIndex = 5;
            data_samochody_dostawcze.Columns["Vin"].DisplayIndex = 6;
            data_samochody_dostawcze.Columns["Ladownosc"].DisplayIndex = 7;
            data_samochody_dostawcze.Columns["Liczba_Drzwi_Bocznych"].DisplayIndex = 8;
            data_samochody_dostawcze.Columns["Pojemnosc_Silnika"].DisplayIndex = 9;
            data_samochody_dostawcze.Columns["Moc"].DisplayIndex = 10;
            data_samochody_dostawcze.Columns["Rodzaj_Paliwa"].DisplayIndex = 11;
            data_samochody_dostawcze.Columns["Rodzaj_Napedu"].DisplayIndex = 12;
            data_samochody_dostawcze.Columns["Skrzynia_Biegow"].DisplayIndex = 13;
            data_samochody_dostawcze.Columns["Kraj_Pochodzenia"].DisplayIndex = 14;
            data_samochody_dostawcze.Columns["Nieuszkodzony"].DisplayIndex = 15;
            data_samochody_dostawcze.Columns["Sprzedany"].DisplayIndex = 16;
            data_samochody_dostawcze.Columns["Wlasciciel"].DisplayIndex = 17;
        }
    }
}
