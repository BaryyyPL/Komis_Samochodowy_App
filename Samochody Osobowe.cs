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

        private void btn_zmien_cene_Click(object sender, EventArgs e)
        {
            if (komis_osobowe.Zmien_Cene_Pojazdu_Po_Vin(tb_zmien_vin.Text, tb_zmien_cena.Text))
            {
                MessageBox.Show($"Zmieniono cenę pojazdu o Vin: {tb_zmien_vin.Text}", "Sukces");
                tb_zmien_cena.Clear();
                tb_zmien_vin.Clear();
                btn_wyswietl_liste_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Niepowodzenie", "Niepowodzenie");
            }
        }

        private void btn_sprzedaj_Click(object sender, EventArgs e)
        {
            Klient klient = cb_sprzedaj_klient.SelectedItem as Klient;

            if (klient != null)
            {
                if (komis_osobowe.Sprzedaj_Pojazd_Po_Vin(tb_sprzedaj_vin.Text, klient))
                {
                    MessageBox.Show($"Sprzedano pojazd o Vin: {tb_sprzedaj_vin.Text}", "Sukces");
                    cb_sprzedaj_klient.SelectedItem = null;
                    tb_sprzedaj_vin.Clear();
                    btn_wyswietl_liste_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Niepowodzenie", "Niepowodzenie");
                }
            }
            else
            {
                MessageBox.Show("Niepowodzenie", "Niepowodzenie");
            }
        }

        private void Samochody_Osobowe_Load(object sender, EventArgs e)
        {
            cb_sprzedaj_klient.DataSource = komis.klienci.ToList();
            cb_sprzedaj_klient.SelectedItem = null;
            cb_sprzedaj_klient.SelectedText = "Klient";

            cb_rodzaj_paliwa.DataSource = Enum.GetValues(typeof(Rodzaj_paliwa));
            cb_sprzedaj_klient.SelectedItem = null;
            cb_rodzaj_paliwa.SelectedText = "Rodzaj paliwa";
            cb_rodzaj_nadwozia.DataSource = Enum.GetValues(typeof(Rodzaj_nadwozia));
            cb_rodzaj_nadwozia.SelectedItem = null;
            cb_rodzaj_nadwozia.SelectedText = "Rodzaj nadwozia";
            cb_rodzaj_napedu.DataSource = Enum.GetValues(typeof(Rodzaj_napedu));
            cb_rodzaj_napedu.SelectedItem = null;
            cb_rodzaj_napedu.SelectedText = "Rodzaj napedu";
            cb_skrzynia_biegow.DataSource = Enum.GetValues(typeof(Skrzynia_biegow));
            cb_skrzynia_biegow.SelectedItem = null;
            cb_skrzynia_biegow.SelectedText = "Skrzynia biegow";
            cb_kraj_pochodzenia.DataSource = Enum.GetValues(typeof(Kraj_pochodzenia));
            cb_kraj_pochodzenia.SelectedItem = null;
            cb_kraj_pochodzenia.SelectedText = "Kraj pochodzenia";

            btn_wyswietl_liste_Click(sender, e);
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            Rodzaj_paliwa rodzaj_paliwa;
            Rodzaj_nadwozia rodzaj_nadwozia;
            Rodzaj_napedu rodzaj_napedu;
            Skrzynia_biegow skrzynia_biegow;
            Kraj_pochodzenia kraj_pochodzenia;

            try
            {
                if (cb_rodzaj_paliwa.SelectedItem == null ||
                    cb_rodzaj_nadwozia.SelectedItem == null ||
                    cb_rodzaj_napedu.SelectedItem == null ||
                    cb_skrzynia_biegow.SelectedItem == null ||
                    cb_kraj_pochodzenia.SelectedItem == null)
                {
                    throw new Exception("Nie wszystkie pola zostały wybrane.");
                }

                rodzaj_paliwa = (Rodzaj_paliwa)cb_rodzaj_paliwa.SelectedItem;
                rodzaj_nadwozia = (Rodzaj_nadwozia)cb_rodzaj_nadwozia.SelectedItem;
                rodzaj_napedu = (Rodzaj_napedu)cb_rodzaj_napedu.SelectedItem;
                skrzynia_biegow = (Skrzynia_biegow)cb_skrzynia_biegow.SelectedItem;
                kraj_pochodzenia = (Kraj_pochodzenia)cb_kraj_pochodzenia.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
                return;
            }

            if(komis_osobowe.Dodaj_Samochod_Osobowy(tb_marka.Text, tb_model.Text, tb_cena.Text,
               tb_rok_produkcji.Text, tb_przebieg.Text, rodzaj_paliwa, tb_vin.Text, !cb_uszkodzony.Checked, 
               tb_pojemnosc_silnika.Text, tb_moc.Text, skrzynia_biegow, kraj_pochodzenia, rodzaj_napedu,
               tb_kolor.Text, rodzaj_nadwozia))
            {
                MessageBox.Show("Dodano samochód", "Sukces");
                tb_marka.Clear();
                tb_model.Clear();
                tb_cena.Clear();
                tb_rok_produkcji.Clear();
                tb_przebieg.Clear();
                tb_vin.Clear();
                cb_rodzaj_paliwa.SelectedItem = null;
                cb_rodzaj_paliwa.SelectedText = "Rodzaj paliwa";
                cb_uszkodzony.Checked = false;
                tb_pojemnosc_silnika.Clear();
                tb_moc.Clear();
                tb_kolor.Clear();
                cb_skrzynia_biegow.SelectedItem = null;
                cb_skrzynia_biegow.SelectedText = "Skrzynia biegow";
                cb_kraj_pochodzenia.SelectedItem = null;
                cb_kraj_pochodzenia.SelectedText = "Kraj pochodzenia";
                cb_rodzaj_napedu.SelectedItem = null;
                cb_rodzaj_napedu.SelectedText = "Rodzaj napedu";
                cb_rodzaj_nadwozia.SelectedItem = null;
                cb_rodzaj_nadwozia.SelectedText = "Rodzaj nadwozia";
                btn_wyswietl_liste_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Niepowodzenie", "Niepowodzenie");
            }
            
        }
    }
}
