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
        Komis_samochodowy komis;

        public Samochody_Osobowe(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_osobowe = new Komis_samochodowy_samochody_osobowe(komis);
            this.komis = komis;
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            komis.Czysc_Listy();
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
            if (!cb_filtruj_malejaco.Checked)
            {
                if (rb_filtruj_cena.Checked) 
                {
                    komis_osobowe.Sortuj_Cena_Rosnaco();
                }
                if (rb_filtruj_marka.Checked)
                {
                    komis_osobowe.Sortuj_Alfabetycznie_Rosnaco();
                }
                if (rb_filtruj_moc.Checked)
                {
                    komis_osobowe.Sortuj_Cena_Rosnaco();
                }
                if (rb_filtruj_przebieg.Checked)
                {
                    komis_osobowe.Sortuj_Przebieg_Rosnaco();
                }
                if (rb_filtruj_rocznik.Checked)
                {
                    komis_osobowe.Sortuj_Rocznik_Rosnaco();
                }
            }
            else
            {
                if (rb_filtruj_cena.Checked)
                {
                    komis_osobowe.Sortuj_Cena_Malejaco();
                }
                if (rb_filtruj_marka.Checked)
                {
                    komis_osobowe.Sortuj_Alfabetycznie_Malejaco();
                }
                if (rb_filtruj_moc.Checked)
                {
                    komis_osobowe.Sortuj_Cena_Malejaco();
                }
                if (rb_filtruj_przebieg.Checked)
                {
                    komis_osobowe.Sortuj_Przebieg_Malejaco();
                }
                if (rb_filtruj_rocznik.Checked)
                {
                    komis_osobowe.Sortuj_Rocznik_Malejaco();
                }
            }


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
            data_samochody_osobowe.Columns["Kolor"].DisplayIndex = 12;
            data_samochody_osobowe.Columns["Kraj_Pochodzenia"].DisplayIndex = 13;
            data_samochody_osobowe.Columns["Nieuszkodzony"].DisplayIndex = 14;
            data_samochody_osobowe.Columns["Sprzedany"].DisplayIndex = 15;
            data_samochody_osobowe.Columns["Wlasciciel"].DisplayIndex = 16;
        }
    }
}
