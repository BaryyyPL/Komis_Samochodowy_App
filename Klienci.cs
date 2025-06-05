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

        public Klienci(Komis_samochodowy komis)
        {
            InitializeComponent();
            komis_klienci = new Komis_samochodowy_klienci(komis);
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wyswietl_liste_Click(object sender, EventArgs e)
        {
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
    }
}
