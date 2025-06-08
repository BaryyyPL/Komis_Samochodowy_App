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
        Komis_samochodowy komis;

        public Pracownicy(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_pracownicy = new Komis_samochodowy_pracownicy(komis);
            this.komis = komis;
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            komis.Czysc_Listy();
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
            if (rb_nazwisko_rosnaco.Checked)
            {
                komis_pracownicy.Sortuj_Nazwisko_Rosnaco();
            }
            else if (rb_nazwisko_malejaco.Checked)
            {
                komis_pracownicy.Sortuj_Nazwisko_Malejaco();
            }
            else if (rb_imie_rosnaco.Checked)
            {
                komis_pracownicy.Sortuj_Imie_Rosnaco();
            }
            else if (rb_imie_malejco.Checked)
            {
                komis_pracownicy.Sortuj_Imie_Malejaco();
            }
            else if (rb_stanowisko_rosnaco.Checked)
            {
                komis_pracownicy.Sortuj_Stanowisko_Rosnaco();
            }
            else if (rb_stanowisko_malejaco.Checked)
            {
                komis_pracownicy.Sortuj_Stanowisko_Malejaco();
            }
            else if (rb_pensja_rosnaco.Checked)
            {
                komis_pracownicy.Sortuj_Pensja_Rosnaco();
            }
            else
            {
                komis_pracownicy.Sortuj_Pensja_Malejaco();
            }

            var lista = komis_pracownicy.Lista_Wszystkich_Pracownikow();
            data_pracownicy.DataSource = lista.ToList();

            data_pracownicy.Columns["Nazwisko"].DisplayIndex = 0;
            data_pracownicy.Columns["Imie"].DisplayIndex = 1;
            data_pracownicy.Columns["Numer_Telefonu"].DisplayIndex = 2;
            data_pracownicy.Columns["Email"].DisplayIndex = 3;
            data_pracownicy.Columns["Stanowisko"].DisplayIndex = 4;
            data_pracownicy.Columns["Pensja"].DisplayIndex = 5;
        }

        private void btn_dodaj_pracownika_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_imie.Text) &&
                    !string.IsNullOrWhiteSpace(tb_nazwisko.Text) &&
                    !string.IsNullOrWhiteSpace(tb_numer_telefonu.Text) &&
                    !string.IsNullOrWhiteSpace(tb_email.Text) &&
                    !string.IsNullOrWhiteSpace(tb_stanowisko.Text) &&
                    !string.IsNullOrWhiteSpace(tb_pensja.Text) &&
                    komis_pracownicy.Dodaj_Pracownika(tb_imie.Text, tb_nazwisko.Text,
                        tb_numer_telefonu.Text, tb_email.Text, tb_stanowisko.Text, tb_pensja.Text))
                {
                    tb_imie.Clear();
                    tb_nazwisko.Clear();
                    tb_email.Clear();
                    tb_numer_telefonu.Clear();
                    tb_stanowisko.Clear();
                    tb_pensja.Clear();

                    btn_wyswietl_liste_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Proszę uzupełnić wszystkie dane pracownika", "Brakujące dane");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dodawania pracownika: {ex.Message}", "Błąd");
            }

        }

        private void btn_daj_podwyzke_Click(object sender, EventArgs e)
        {
            try
            {
                if (komis_pracownicy.Daj_Podwyzke_Po_Numerze_Telefonu(tb_podwyzka_numer_telefonu.Text, tb_podwyzka_kwota_podwyzki.Text))
                {
                    tb_podwyzka_kwota_podwyzki.Clear();
                    tb_podwyzka_numer_telefonu.Clear();

                    btn_wyswietl_liste_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Niepowodzenie", "Niepowodzenia");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd");
            }
        }

        private void btn_resetuj_filtry_Click(object sender, EventArgs e)
        {
            komis_pracownicy.Resetuj_Filtry();
            tb_filtruj_nazwisko.Clear();
            tb_filtruj_imie.Clear();
            tb_filtruj_numer_telefonu.Clear();
            tb_filtruj_email.Clear();
            tb_filtruj_pensja_maksymalna.Clear();
            tb_filtruj_pensja_minimalna.Clear();
            tb_filtruj_stanowisko.Clear();

            btn_wyswietl_liste_Click(sender, e);
        }

        private void btn_zastosuj_filtry_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_filtruj_nazwisko.Text.Length > 0)
                {
                    komis_pracownicy.Filtruj_Nazwisko(tb_filtruj_nazwisko.Text);
                }
                if (tb_filtruj_imie.Text.Length > 0)
                {
                    komis_pracownicy.Filtruj_Imie(tb_filtruj_imie.Text);
                }
                if (tb_filtruj_numer_telefonu.Text.Length > 0)
                {
                    komis_pracownicy.Filtruj_Numer_Telefonu(tb_filtruj_numer_telefonu.Text);
                }
                if (tb_filtruj_email.Text.Length > 0)
                {
                    komis_pracownicy.Filtruj_Email(tb_filtruj_email.Text);
                }
                if (tb_filtruj_stanowisko.Text.Length > 0)
                {
                    komis_pracownicy.Filtruj_Stanowisko(tb_filtruj_stanowisko.Text);
                }
                if (tb_filtruj_pensja_minimalna.Text.Length > 0 || tb_filtruj_pensja_maksymalna.Text.Length > 0)
                {
                    komis_pracownicy.Filtruj_Pensja(tb_filtruj_pensja_minimalna.Text, tb_filtruj_pensja_maksymalna.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}", "Błąd");
            }

            btn_wyswietl_liste_Click(sender, e);
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            btn_wyswietl_liste_Click(sender, e);

            foreach(var p in komis_pracownicy.pracownicy)
            {
                p.Podwyzka += pracownik =>
                {
                    MessageBox.Show($"Pracownik: {pracownik.Imie} {pracownik.Nazwisko} {pracownik.Stanowisko} dostał podwyżkę i zarabia teraz {pracownik.Pensja}", "Podwyżka");
                };

                p.Dodano_Osobe += pracownik =>
                {
                    MessageBox.Show($"Dodano nowego pracownika {pracownik.ToString()}", "Dodano pracownika");
                };
            }
        }
    }
}
