using Komis_Samochodowy;

namespace Komis_Samochodowy_App
{
    public partial class Form1 : Form
    {

        Komis_samochodowy komis;

        public Form1()
        {
            InitializeComponent();
            komis = new Komis_samochodowy();
            komis.Stworz_Listy();
        }

        private void btn_samochody_osobowe_Click(object sender, EventArgs e)
        {
            komis.Wybor("samochody_osobowe");

            this.Hide();
            var samochody_osobowe_form = new Samochody_Osobowe(komis);
            samochody_osobowe_form.FormClosed += (s, args) => this.Show();
            samochody_osobowe_form.Show();
        }

        private void btn_pracownicy_Click(object sender, EventArgs e)
        {
            komis.Wybor("pracownicy");

            this.Hide();
            var pracownicy_form = new Pracownicy(komis);
            pracownicy_form.FormClosed += (s, args) => this.Show();
            pracownicy_form.Show();
        }

        private void btn_samochody_dostawcze_Click(object sender, EventArgs e)
        {
            komis.Wybor("samochody_dostawcze");

            this.Hide();
            var samochody_dostawcze_form = new Samochody_Dostawcze(komis);
            samochody_dostawcze_form.FormClosed += (s, args) => this.Show();
            samochody_dostawcze_form.Show();
        }

        private void btn_klienci_Click(object sender, EventArgs e)
        {
            komis.Wybor("klienci");

            this.Hide();
            var klienci_form = new Klienci(komis);
            klienci_form.FormClosed += (s, args) => this.Show();
            klienci_form.Show();
        }
    }
}
