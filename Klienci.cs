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
    public partial class Klienci : Form
    {

        Komis_samochodowy_klienci komis_klienci;
        Komis_samochodowy komis;

        public Klienci(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_klienci = new Komis_samochodowy_klienci(komis);
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
                komis_klienci.Sortuj_Nazwisko_Rosnaco();
            }
            else if (rb_nazwisko_malejaco.Checked)
            {
                komis_klienci.Sortuj_Nazwisko_Malejaco();
            }
            else if (rb_imie_rosnaco.Checked)
            {
                komis_klienci.Sortuj_Imie_Rosnaco();
            }
            else
            {
                komis_klienci.Sortuj_Imie_Malejaco();
            }

            var lista = komis_klienci.Lista_Wszystkich_Klientow();

            data_klienci.DataSource = lista.ToList();

            data_klienci.Columns["Nazwisko"].DisplayIndex = 0;
            data_klienci.Columns["Imie"].DisplayIndex = 1;
            data_klienci.Columns["Numer_Telefonu"].DisplayIndex = 2;
            data_klienci.Columns["Email"].DisplayIndex = 3;
            data_klienci.Columns["Newsletter"].DisplayIndex = 4;
        }

        private void btn_dodaj_klienta_Click(object sender, EventArgs e)
        {
            if (komis_klienci.Dodaj_Klienta(tb_imie.Text, tb_nazwisko.Text, tb_numer_telefonu.Text, tb_email.Text, cb_newsletter.Checked))
            {
                MessageBox.Show("Dodano klienta", "Sukces");
                tb_imie.Clear();
                tb_nazwisko.Clear();
                tb_email.Clear();
                cb_newsletter.Checked = false;
                tb_numer_telefonu.Clear();

                btn_wyswietl_liste_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Brakujące dane klienta", "Niepowodzenia");
            }

        }

        private void btn_zasub_newsletter_Click(object sender, EventArgs e)
        {
            if (komis_klienci.Zasubskrybuj_Newsletter_Po_Numerze_Telefonu(tb_zasub_numer_telefonu.Text, cb_zasub_newsletter.Checked))
            {
                MessageBox.Show("Sukces", "Sukces");
                cb_zasub_newsletter.Checked = false;
                tb_zasub_numer_telefonu.Clear();

                btn_wyswietl_liste_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Niepowodzenie", "Niepowodzenia");
            }
        }

        private void btn_resetuj_filtry_Click(object sender, EventArgs e)
        {
            komis_klienci.Resetuj_Filtry();
            tb_filtruj_nazwisko.Clear();
            tb_filtruj_imie.Clear();
            tb_filtruj_numer_telefonu.Clear();
            tb_filtruj_email.Clear();
            cb_filtruj_newsletter.Checked = false;

            btn_wyswietl_liste_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_filtruj_nazwisko.Text.Length > 0)
            {
                komis_klienci.Filtruj_Nazwisko(tb_filtruj_nazwisko.Text);
            }
            if (tb_filtruj_imie.Text.Length > 0)
            {
                komis_klienci.Filtruj_Imie(tb_filtruj_imie.Text);
            }
            if (tb_filtruj_numer_telefonu.Text.Length > 0)
            {
                komis_klienci.Filtruj_Numer_Telefonu(tb_filtruj_numer_telefonu.Text);
            }
            if (tb_filtruj_email.Text.Length > 0)
            {
                komis_klienci.Filtruj_Email(tb_filtruj_email.Text);
            }
            if (cb_filtruj_newsletter.Checked == true)
            {
                komis_klienci.Filtruj_Newsletter();
            }

            btn_wyswietl_liste_Click(sender, e);
        }
    }
}
