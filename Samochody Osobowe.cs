﻿using Komis_Samochodowy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                    komis_osobowe.Sortuj_Moc_Rosnaco();
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
                    komis_osobowe.Sortuj_Moc_Malejaco();
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
            try
            {
                if (komis_osobowe.Zmien_Cene_Pojazdu_Po_Vin(tb_zmien_vin.Text, tb_zmien_cena.Text))
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
            catch(Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd");
            }
        }

        private void btn_sprzedaj_Click(object sender, EventArgs e)
        {
            Klient klient = cb_sprzedaj_klient.SelectedItem as Klient;

            try
            {
                if (klient == null)
                {
                    throw new Exception("Taki klient nie istnieje");
                }

                if (komis_osobowe.Sprzedaj_Pojazd_Po_Vin(tb_sprzedaj_vin.Text, klient))
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
            catch(Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd");
            }
        }

        private void Samochody_Osobowe_Load(object sender, EventArgs e)
        {
            cb_sprzedaj_klient.DataSource = komis.klienci.ToList();
            cb_sprzedaj_klient.SelectedItem = null;
            cb_sprzedaj_klient.Text = "Klient";

            cb_rodzaj_paliwa.DataSource = Enum.GetValues(typeof(Rodzaj_paliwa));
            cb_rodzaj_paliwa.SelectedItem = null;
            cb_rodzaj_paliwa.Text = "Rodzaj paliwa";
            cb_rodzaj_nadwozia.DataSource = Enum.GetValues(typeof(Rodzaj_nadwozia));
            cb_rodzaj_nadwozia.SelectedItem = null;
            cb_rodzaj_nadwozia.Text = "Rodzaj nadwozia";
            cb_rodzaj_napedu.DataSource = Enum.GetValues(typeof(Rodzaj_napedu));
            cb_rodzaj_napedu.SelectedItem = null;
            cb_rodzaj_napedu.Text = "Rodzaj napedu";
            cb_skrzynia_biegow.DataSource = Enum.GetValues(typeof(Skrzynia_biegow));
            cb_skrzynia_biegow.SelectedItem = null;
            cb_skrzynia_biegow.Text = "Skrzynia biegow";
            cb_kraj_pochodzenia.DataSource = Enum.GetValues(typeof(Kraj_pochodzenia));
            cb_kraj_pochodzenia.SelectedItem = null;
            cb_kraj_pochodzenia.Text = "Kraj pochodzenia";

            cb_filtruj_rodzaj_paliwa.DataSource = Enum.GetValues(typeof(Rodzaj_paliwa));
            cb_filtruj_rodzaj_paliwa.SelectedItem = null;
            cb_filtruj_rodzaj_paliwa.Text = "Rodzaj paliwa";
            cb_filtruj_rodzaj_nadwozia.DataSource = Enum.GetValues(typeof(Rodzaj_nadwozia));
            cb_filtruj_rodzaj_nadwozia.SelectedItem = null;
            cb_filtruj_rodzaj_nadwozia.Text = "Rodzaj nadwozia";
            cb_filtruj_rodzaj_napedu.DataSource = Enum.GetValues(typeof(Rodzaj_napedu));
            cb_filtruj_rodzaj_napedu.SelectedItem = null;
            cb_filtruj_rodzaj_napedu.Text = "Rodzaj napedu";
            cb_filtruj_skrzynia_biegow.DataSource = Enum.GetValues(typeof(Skrzynia_biegow));
            cb_filtruj_skrzynia_biegow.SelectedItem = null;
            cb_filtruj_skrzynia_biegow.Text = "Skrzynia biegow";
            cb_filtruj_kraj_pochodzenia.DataSource = Enum.GetValues(typeof(Kraj_pochodzenia));
            cb_filtruj_kraj_pochodzenia.SelectedItem = null;
            cb_filtruj_kraj_pochodzenia.Text = "Kraj pochodzenia";
            cb_filtruj_wlasciciel.DataSource = komis.klienci.ToList();
            cb_filtruj_wlasciciel.SelectedItem = null;
            cb_filtruj_wlasciciel.Text = "Wlasciciel";
            cb_filtruj_sprzedany.Items.Add("Tak");
            cb_filtruj_sprzedany.Items.Add("Nie");
            cb_filtruj_sprzedany.SelectedItem = null;
            cb_filtruj_sprzedany.Text = "Sprzedany";

            btn_wyswietl_liste_Click(sender, e);

            foreach (var p in komis_osobowe.samochody_osobowe)
            {
                p.Zmiana_Ceny += pojazd =>
                {
                    MessageBox.Show($"Cena pojazdu {pojazd.Marka} {pojazd.Model} zmieniona na: {pojazd.Cena} zł", "Zmiana ceny");

                    Poinformuj_klientow();
                };

                p.Pojazd_Sprzedany += pojazd =>
                {
                    MessageBox.Show($"Pojazdu {pojazd.Marka} {pojazd.Model} o VIN: {pojazd.Vin} został sprzedany do {pojazd.Wlasciciel.ToString()} za {pojazd.Cena} zł", "Sprzedaż");
     
                };

                p.Dodano_Pojazd += pojazd =>
                {
                    MessageBox.Show($"Dodano pojazd: {pojazd.ToString()}", "Dodano pojazd");

                    Poinformuj_klientow();
                };
            }
        }

        void Poinformuj_klientow()
        {
            string klienci_z_newsletterem = "";

            foreach (var k in komis.klienci)
            {
                if (k.Newsletter)
                {
                    klienci_z_newsletterem += k.ToString() + "; \n";
                }
            }

            MessageBox.Show($"Klienci, którzy zostali poinformowani: \n{klienci_z_newsletterem}", "Poinformowano klientów");
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
                    cb_kraj_pochodzenia.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(tb_marka.Text) ||
                    string.IsNullOrWhiteSpace(tb_model.Text) ||
                    string.IsNullOrWhiteSpace(tb_cena.Text) ||
                    string.IsNullOrWhiteSpace(tb_rok_produkcji.Text) ||
                    string.IsNullOrWhiteSpace(tb_przebieg.Text) ||
                    string.IsNullOrWhiteSpace(tb_vin.Text) ||
                    string.IsNullOrWhiteSpace(tb_pojemnosc_silnika.Text) ||
                    string.IsNullOrWhiteSpace(tb_moc.Text) ||
                    string.IsNullOrWhiteSpace(tb_kolor.Text)
                )
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

            try
            {
                if (komis_osobowe.Dodaj_Samochod_Osobowy(tb_marka.Text, tb_model.Text, tb_cena.Text,
                   tb_rok_produkcji.Text, tb_przebieg.Text, rodzaj_paliwa, tb_vin.Text, !cb_uszkodzony.Checked,
                   tb_pojemnosc_silnika.Text, tb_moc.Text, skrzynia_biegow, kraj_pochodzenia, rodzaj_napedu,
                   tb_kolor.Text, rodzaj_nadwozia))
                {
                    tb_marka.Clear();
                    tb_model.Clear();
                    tb_cena.Clear();
                    tb_rok_produkcji.Clear();
                    tb_przebieg.Clear();
                    tb_vin.Clear();
                    cb_rodzaj_paliwa.SelectedItem = null;
                    cb_rodzaj_paliwa.Text = "Rodzaj paliwa";
                    cb_uszkodzony.Checked = false;
                    tb_pojemnosc_silnika.Clear();
                    tb_moc.Clear();
                    tb_kolor.Clear();
                    cb_skrzynia_biegow.SelectedItem = null;
                    cb_skrzynia_biegow.Text = "Skrzynia biegow";
                    cb_kraj_pochodzenia.SelectedItem = null;
                    cb_kraj_pochodzenia.Text = "Kraj pochodzenia";
                    cb_rodzaj_napedu.SelectedItem = null;
                    cb_rodzaj_napedu.Text = "Rodzaj napedu";
                    cb_rodzaj_nadwozia.SelectedItem = null;
                    cb_rodzaj_nadwozia.Text = "Rodzaj nadwozia";
                    btn_filtruj_resetuj_Click(sender, e);
                    btn_wyswietl_liste_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Niepowodzenie", "Niepowodzenie");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd");
            }

        }

        private void btn_filtruj_resetuj_Click(object sender, EventArgs e)
        {
            cb_filtruj_rodzaj_paliwa.Text = null;
            cb_filtruj_rodzaj_nadwozia.Text = null;
            cb_filtruj_rodzaj_napedu.Text = null;
            cb_filtruj_skrzynia_biegow.Text = null;
            cb_filtruj_kraj_pochodzenia.Text = null;
            cb_filtruj_wlasciciel.Text = null;
            cb_filtruj_sprzedany.Text = null;

            cb_filtruj_rodzaj_paliwa.SelectedItem = null;
            cb_filtruj_rodzaj_paliwa.Text = "Rodzaj paliwa";                   
            cb_filtruj_rodzaj_nadwozia.SelectedItem = null;
            cb_filtruj_rodzaj_nadwozia.Text = "Rodzaj nadwozia";
            cb_filtruj_rodzaj_napedu.SelectedItem = null;
            cb_filtruj_rodzaj_napedu.Text = "Rodzaj napedu";
            cb_filtruj_skrzynia_biegow.SelectedItem = null;
            cb_filtruj_skrzynia_biegow.Text = "Skrzynia biegow";
            cb_filtruj_kraj_pochodzenia.SelectedItem = null;
            cb_filtruj_kraj_pochodzenia.Text = "Kraj pochodzenia";
            cb_filtruj_wlasciciel.SelectedItem = null;
            cb_filtruj_wlasciciel.Text = "Wlasciciel";
            cb_filtruj_sprzedany.SelectedItem = null;
            cb_filtruj_sprzedany.Text = "Sprzedany";
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

            komis_osobowe.Resetuj_Filtry();

            btn_wyswietl_liste_Click(sender, e);
        }

        private void btn_filtruj_zastosuj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_filtruj_rodzaj_paliwa.SelectedItem != null)
                {
                    komis_osobowe.Filtruj_Paliwo((Rodzaj_paliwa)cb_filtruj_rodzaj_paliwa.SelectedItem);
                }
                if (cb_filtruj_rodzaj_nadwozia.SelectedItem != null)
                {
                    komis_osobowe.Filtruj_Nadwozie((Rodzaj_nadwozia)cb_filtruj_rodzaj_nadwozia.SelectedItem);
                }
                if (cb_filtruj_rodzaj_napedu.SelectedItem != null)
                {
                    komis_osobowe.Filtruj_Naped((Rodzaj_napedu)cb_filtruj_rodzaj_napedu.SelectedItem);
                }
                if (cb_filtruj_skrzynia_biegow.SelectedItem != null)
                {
                    komis_osobowe.Filtruj_Skrzynia((Skrzynia_biegow)cb_filtruj_skrzynia_biegow.SelectedItem);
                }
                if (cb_filtruj_kraj_pochodzenia.SelectedItem != null)
                {
                    komis_osobowe.Filtruj_Kraj((Kraj_pochodzenia)cb_filtruj_kraj_pochodzenia.SelectedItem);
                }
                if (cb_filtruj_wlasciciel.SelectedItem != null)
                {
                    cb_filtruj_sprzedany.SelectedIndex = 0;
                    komis_osobowe.Filtruj_Wlasciciel((Klient)cb_filtruj_wlasciciel.SelectedItem);
                }
                if (cb_filtruj_sprzedany.SelectedItem != null)
                {
                    komis_osobowe.Filtruj_Sprzedany(cb_filtruj_sprzedany.SelectedIndex == 0 ? true : false);
                }
                if (cb_filtruj_nieuszkodzony.Checked)
                {
                    komis_osobowe.Filtruj_Nieuszkodzony();
                }
                if (tb_filtruj_marka.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Marka(tb_filtruj_marka.Text);
                }
                if (tb_filtruj_model.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Model(tb_filtruj_model.Text);
                }
                if (tb_filtruj_vin.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_VIN(tb_filtruj_vin.Text);
                }
                if (tb_filtruj_kolor.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Kolor(tb_filtruj_kolor.Text);
                }
                if (tb_minimalna_cena.Text.Length > 0 || tb_maksymalna_cena.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Cena(tb_minimalna_cena.Text, tb_maksymalna_cena.Text);
                }
                if (tb_minimalna_moc.Text.Length > 0 || tb_maksymalna_moc.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Moc(tb_minimalna_moc.Text, tb_maksymalna_moc.Text);
                }
                if (tb_minimalna_pojemnosc.Text.Length > 0 || tb_maksymalna_pojemnosc.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Pojemnosc(tb_minimalna_pojemnosc.Text, tb_maksymalna_pojemnosc.Text);
                }
                if (tb_minimalny_przebieg.Text.Length > 0 || tb_maksymalny_przebieg.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Przebieg(tb_minimalny_przebieg.Text, tb_maksymalny_przebieg.Text);
                }
                if (tb_minimalny_rok.Text.Length > 0 || tb_maksymalny_rok.Text.Length > 0)
                {
                    komis_osobowe.Filtruj_Rok(tb_minimalny_rok.Text, tb_maksymalny_rok.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd");
            }

            btn_wyswietl_liste_Click(sender, e);
        }
    }
}
