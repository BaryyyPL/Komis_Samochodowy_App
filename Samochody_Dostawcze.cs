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
        Komis_samochodowy komis;

        public Samochody_Dostawcze(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_dostawcze = new Komis_samochodowy_samochody_dostawcze(komis);
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
                    komis_dostawcze.Sortuj_Cena_Rosnaco();
                }
                if (rb_filtruj_marka.Checked)
                {
                    komis_dostawcze.Sortuj_Alfabetycznie_Rosnaco();
                }
                if (rb_filtruj_moc.Checked)
                {
                    komis_dostawcze.Sortuj_Cena_Rosnaco();
                }
                if (rb_filtruj_przebieg.Checked)
                {
                    komis_dostawcze.Sortuj_Przebieg_Rosnaco();
                }
                if (rb_filtruj_rocznik.Checked)
                {
                    komis_dostawcze.Sortuj_Rocznik_Rosnaco();
                }
            }
            else
            {
                if (rb_filtruj_cena.Checked)
                {
                    komis_dostawcze.Sortuj_Cena_Malejaco();
                }
                if (rb_filtruj_marka.Checked)
                {
                    komis_dostawcze.Sortuj_Alfabetycznie_Malejaco();
                }
                if (rb_filtruj_moc.Checked)
                {
                    komis_dostawcze.Sortuj_Cena_Malejaco();
                }
                if (rb_filtruj_przebieg.Checked)
                {
                    komis_dostawcze.Sortuj_Przebieg_Malejaco();
                }
                if (rb_filtruj_rocznik.Checked)
                {
                    komis_dostawcze.Sortuj_Rocznik_Malejaco();
                }
            }

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
            data_samochody_dostawcze.Columns["Kolor"].DisplayIndex = 14;
            data_samochody_dostawcze.Columns["Kraj_Pochodzenia"].DisplayIndex = 15;
            data_samochody_dostawcze.Columns["Nieuszkodzony"].DisplayIndex = 16;
            data_samochody_dostawcze.Columns["Sprzedany"].DisplayIndex = 17;
            data_samochody_dostawcze.Columns["Wlasciciel"].DisplayIndex = 18;
        }

        private void btn_zmien_cene_Click(object sender, EventArgs e)
        {
            if (komis_dostawcze.Zmien_Cene_Pojazdu_Po_Vin(tb_zmien_vin.Text, tb_zmien_cena.Text))
            {
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
                if (komis_dostawcze.Sprzedaj_Pojazd_Po_Vin(tb_sprzedaj_vin.Text, klient))
                {
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

        private void Samochody_Dostawcze_Load(object sender, EventArgs e)
        {
            cb_sprzedaj_klient.DataSource = komis.klienci.ToList();
            cb_sprzedaj_klient.SelectedItem = null;
            cb_sprzedaj_klient.SelectedText = "Klient";

            cb_rodzaj_paliwa.DataSource = Enum.GetValues(typeof(Rodzaj_paliwa));
            cb_rodzaj_paliwa.SelectedItem = null;
            cb_rodzaj_paliwa.SelectedText = "Rodzaj paliwa";
            cb_rodzaj_zabudowy.DataSource = Enum.GetValues(typeof(Rodzaj_zabudowy));
            cb_rodzaj_zabudowy.SelectedItem = null;
            cb_rodzaj_zabudowy.SelectedText = "Rodzaj zabudowy";
            cb_rodzaj_napedu.DataSource = Enum.GetValues(typeof(Rodzaj_napedu));
            cb_rodzaj_napedu.SelectedItem = null;
            cb_rodzaj_napedu.SelectedText = "Rodzaj napedu";
            cb_skrzynia_biegow.DataSource = Enum.GetValues(typeof(Skrzynia_biegow));
            cb_skrzynia_biegow.SelectedItem = null;
            cb_skrzynia_biegow.SelectedText = "Skrzynia biegow";
            cb_kraj_pochodzenia.DataSource = Enum.GetValues(typeof(Kraj_pochodzenia));
            cb_kraj_pochodzenia.SelectedItem = null;
            cb_kraj_pochodzenia.SelectedText = "Kraj pochodzenia";

            cb_filtruj_rodzaj_paliwa.DataSource = Enum.GetValues(typeof(Rodzaj_paliwa));
            cb_filtruj_rodzaj_paliwa.SelectedItem = null;
            cb_filtruj_rodzaj_paliwa.SelectedText = "Rodzaj paliwa";
            cb_filtruj_rodzaj_zabudowy.DataSource = Enum.GetValues(typeof(Rodzaj_zabudowy));
            cb_filtruj_rodzaj_zabudowy.SelectedItem = null;
            cb_filtruj_rodzaj_zabudowy.SelectedText = "Rodzaj zabudowy";
            cb_filtruj_rodzaj_napedu.DataSource = Enum.GetValues(typeof(Rodzaj_napedu));
            cb_filtruj_rodzaj_napedu.SelectedItem = null;
            cb_filtruj_rodzaj_napedu.SelectedText = "Rodzaj napedu";
            cb_filtruj_skrzynia_biegow.DataSource = Enum.GetValues(typeof(Skrzynia_biegow));
            cb_filtruj_skrzynia_biegow.SelectedItem = null;
            cb_filtruj_skrzynia_biegow.SelectedText = "Skrzynia biegow";
            cb_filtruj_kraj_pochodzenia.DataSource = Enum.GetValues(typeof(Kraj_pochodzenia));
            cb_filtruj_kraj_pochodzenia.SelectedItem = null;
            cb_filtruj_kraj_pochodzenia.SelectedText = "Kraj pochodzenia";
            cb_filtruj_wlasciciel.DataSource = komis.klienci.ToList();
            cb_filtruj_wlasciciel.SelectedItem = null;
            cb_filtruj_wlasciciel.SelectedText = "Wlasciciel";
            cb_filtruj_sprzedany.Items.Add("Tak");
            cb_filtruj_sprzedany.Items.Add("Nie");
            cb_filtruj_sprzedany.SelectedItem = null;
            cb_filtruj_sprzedany.SelectedText = "Sprzedany";

            btn_wyswietl_liste_Click(sender, e);

            foreach (var p in komis_dostawcze.samochody_dostawcze)
            {
                p.Zmiana_Ceny += pojazd =>
                {
                    MessageBox.Show($"Cena pojazdu {pojazd.Marka} {pojazd.Model} zmieniona na: {pojazd.Cena} zł", "Zmiana ceny");
                };

                p.Pojazd_Sprzedany += pojazd =>
                {
                    MessageBox.Show($"Pojazdu {pojazd.Marka} {pojazd.Model} o VIN: {pojazd.Vin} został sprzedany do {pojazd.Wlasciciel.ToString()} za {pojazd.Cena} zł", "Sprzedaż");
                };

                p.Dodano_Pojazd += pojazd =>
                {
                    MessageBox.Show($"Dodano pojazd: {pojazd.ToString()}", "Dodano pojazd");
                };
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            Rodzaj_paliwa rodzaj_paliwa;
            Rodzaj_zabudowy rodzaj_zabudowy;
            Rodzaj_napedu rodzaj_napedu;
            Skrzynia_biegow skrzynia_biegow;
            Kraj_pochodzenia kraj_pochodzenia;

            try
            {
                if (cb_rodzaj_paliwa.SelectedItem == null ||
                    cb_rodzaj_zabudowy.SelectedItem == null ||
                    cb_rodzaj_napedu.SelectedItem == null ||
                    cb_skrzynia_biegow.SelectedItem == null ||
                    cb_kraj_pochodzenia.SelectedItem == null)
                {
                    throw new Exception("Nie wszystkie pola zostały wybrane.");
                }

                rodzaj_paliwa = (Rodzaj_paliwa)cb_rodzaj_paliwa.SelectedItem;
                rodzaj_zabudowy = (Rodzaj_zabudowy)cb_rodzaj_zabudowy.SelectedItem;
                rodzaj_napedu = (Rodzaj_napedu)cb_rodzaj_napedu.SelectedItem;
                skrzynia_biegow = (Skrzynia_biegow)cb_skrzynia_biegow.SelectedItem;
                kraj_pochodzenia = (Kraj_pochodzenia)cb_kraj_pochodzenia.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
                return;
            }

            if (komis_dostawcze.Dodaj_Samochod_Dostawczy(tb_marka.Text, tb_model.Text, tb_cena.Text,
               tb_rok_produkcji.Text, tb_przebieg.Text, rodzaj_paliwa, tb_vin.Text, !cb_uszkodzony.Checked,
               tb_pojemnosc_silnika.Text, tb_moc.Text, skrzynia_biegow, kraj_pochodzenia, rodzaj_napedu,
               tb_kolor.Text, tb_ladownosc.Text, tb_liczba_drzwi_bocznych.Text, rodzaj_zabudowy))
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
                cb_filtruj_rodzaj_zabudowy.SelectedItem = null;
                cb_filtruj_rodzaj_zabudowy.SelectedText = "Rodzaj zabudowy";
                tb_liczba_drzwi_bocznych.Clear();
                tb_ladownosc.Clear();
                btn_filtruj_resetuj_Click(sender, e);
                btn_wyswietl_liste_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Niepowodzenie", "Niepowodzenie");
            }

        }

        private void btn_filtruj_resetuj_Click(object sender, EventArgs e)
        {
            cb_filtruj_rodzaj_paliwa.Text = null;
            cb_filtruj_rodzaj_zabudowy.Text = null;
            cb_filtruj_rodzaj_napedu.Text = null;
            cb_filtruj_skrzynia_biegow.Text = null;
            cb_filtruj_kraj_pochodzenia.Text = null;
            cb_filtruj_wlasciciel.Text = null;
            cb_filtruj_sprzedany.Text = null;

            cb_filtruj_rodzaj_paliwa.SelectedItem = null;
            cb_filtruj_rodzaj_paliwa.SelectedText = "Rodzaj paliwa";
            cb_filtruj_rodzaj_zabudowy.SelectedItem = null;
            cb_filtruj_rodzaj_zabudowy.SelectedText = "Rodzaj zabudowy";
            cb_filtruj_rodzaj_napedu.SelectedItem = null;
            cb_filtruj_rodzaj_napedu.SelectedText = "Rodzaj napedu";
            cb_filtruj_skrzynia_biegow.SelectedItem = null;
            cb_filtruj_skrzynia_biegow.SelectedText = "Skrzynia biegow";
            cb_filtruj_kraj_pochodzenia.SelectedItem = null;
            cb_filtruj_kraj_pochodzenia.SelectedText = "Kraj pochodzenia";
            cb_filtruj_wlasciciel.SelectedItem = null;
            cb_filtruj_wlasciciel.SelectedText = "Wlasciciel";
            cb_filtruj_sprzedany.SelectedItem = null;
            cb_filtruj_sprzedany.SelectedText = "Sprzedany";
            tb_filtruj_marka.Clear();
            tb_filtruj_model.Clear();
            tb_filtruj_vin.Clear();
            tb_filtruj_kolor.Clear();
            cb_filtruj_nieuszkodzony.Checked = false;
            tb_minimalna_cena.Clear();
            tb_maksymalna_cena.Clear();
            tb_minimalna_moc.Clear();
            tb_maksymalna_moc.Clear();
            tb_minimalna_pojemnosc.Clear();
            tb_maksymalna_pojemnosc.Clear();
            tb_minimalny_przebieg.Clear();
            tb_maksymalny_przebieg.Clear();
            tb_minimalny_rok.Clear();
            tb_maksymalny_rok.Clear();
            tb_filtruj_minimalna_liczba_drzwi_bocznych.Clear();
            tb_filtruj_maksymalna_liczba_drzwi_bocznych.Clear();
            tb_filtruj_minimalna_ladownosc.Clear();
            tb_filtruj_maksymalna_ladownosc.Clear();

            komis_dostawcze.Resetuj_Filtry();

            btn_wyswietl_liste_Click(sender, e);
        }

        private void btn_filtruj_zastosuj_Click(object sender, EventArgs e)
        {
            if (cb_filtruj_rodzaj_paliwa.SelectedItem != null)
            {
                komis_dostawcze.Filtruj_Paliwo((Rodzaj_paliwa)cb_filtruj_rodzaj_paliwa.SelectedItem);
            }
            if (cb_filtruj_rodzaj_zabudowy.SelectedItem != null)
            {
                komis_dostawcze.Filtruj_Zabudowa((Rodzaj_zabudowy)cb_filtruj_rodzaj_zabudowy.SelectedItem);
            }
            if (cb_filtruj_rodzaj_napedu.SelectedItem != null)
            {
                komis_dostawcze.Filtruj_Naped((Rodzaj_napedu)cb_filtruj_rodzaj_napedu.SelectedItem);
            }
            if (cb_filtruj_skrzynia_biegow.SelectedItem != null)
            {
                komis_dostawcze.Filtruj_Skrzynia((Skrzynia_biegow)cb_filtruj_skrzynia_biegow.SelectedItem);
            }
            if (cb_filtruj_kraj_pochodzenia.SelectedItem != null)
            {
                komis_dostawcze.Filtruj_Kraj((Kraj_pochodzenia)cb_filtruj_kraj_pochodzenia.SelectedItem);
            }
            if (cb_filtruj_wlasciciel.SelectedItem != null)
            {
                cb_filtruj_sprzedany.SelectedIndex = 0;
                komis_dostawcze.Filtruj_Wlasciciel((Klient)cb_filtruj_wlasciciel.SelectedItem);
            }
            if (cb_filtruj_sprzedany.SelectedItem != null)
            {
                komis_dostawcze.Filtruj_Sprzedany(cb_filtruj_sprzedany.SelectedIndex == 0 ? true : false);
            }
            if (cb_filtruj_nieuszkodzony.Checked)
            {
                komis_dostawcze.Filtruj_Nieuszkodzony();
            }
            if (tb_filtruj_marka.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Marka(tb_filtruj_marka.Text);
            }
            if (tb_filtruj_model.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Model(tb_filtruj_model.Text);
            }
            if (tb_filtruj_vin.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_VIN(tb_filtruj_vin.Text);
            }
            if (tb_filtruj_kolor.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Kolor(tb_filtruj_kolor.Text);
            }
            if (tb_minimalna_cena.Text.Length > 0 || tb_maksymalna_cena.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Cena(tb_minimalna_cena.Text, tb_maksymalna_cena.Text);
            }
            if (tb_minimalna_moc.Text.Length > 0 || tb_maksymalna_moc.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Moc(tb_minimalna_moc.Text, tb_maksymalna_moc.Text);
            }
            if (tb_minimalna_pojemnosc.Text.Length > 0 || tb_maksymalna_pojemnosc.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Pojemnosc(tb_minimalna_pojemnosc.Text, tb_maksymalna_pojemnosc.Text);
            }
            if (tb_minimalny_przebieg.Text.Length > 0 || tb_maksymalny_przebieg.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Przebieg(tb_minimalny_przebieg.Text, tb_maksymalny_przebieg.Text);
            }
            if (tb_minimalny_rok.Text.Length > 0 || tb_maksymalny_rok.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Rok(tb_minimalny_rok.Text, tb_maksymalny_rok.Text);
            }
            if (tb_filtruj_minimalna_ladownosc.Text.Length > 0 || tb_filtruj_maksymalna_ladownosc.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Ladownosc(tb_filtruj_minimalna_ladownosc.Text, tb_filtruj_maksymalna_ladownosc.Text);
            }
            if (tb_filtruj_minimalna_liczba_drzwi_bocznych.Text.Length > 0 || tb_filtruj_maksymalna_liczba_drzwi_bocznych.Text.Length > 0)
            {
                komis_dostawcze.Filtruj_Drzwi(tb_filtruj_minimalna_liczba_drzwi_bocznych.Text, tb_filtruj_maksymalna_liczba_drzwi_bocznych.Text);
            }

            btn_wyswietl_liste_Click(sender, e);
        }
    }
}
