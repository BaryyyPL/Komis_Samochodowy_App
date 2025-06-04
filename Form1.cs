using Komis_Samochodowy;

namespace Komis_Samochodowy_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var komis = new Komis_samochodowy();
            komis.Stworz_Listy();
        }

        private void btn_samochody_osobowe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var samochody_osobowe_form= new Samochody_Osobowe();
            samochody_osobowe_form.FormClosed += (s, args) => this.Show();
            samochody_osobowe_form.Show();
        }

        private void btn_pracownicy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pracownicy_form = new Pracownicy();
            pracownicy_form.FormClosed += (s, args) => this.Show();
            pracownicy_form.Show();
        }

        private void btn_samochody_dostawcze_Click(object sender, EventArgs e)
        {
            this.Hide();
            var samochody_dostawcze_form = new Samochody_Dostawcze();
            samochody_dostawcze_form.FormClosed += (s, args) => this.Show();
            samochody_dostawcze_form.Show();
        }

        private void btn_klienci_Click(object sender, EventArgs e)
        {
            this.Hide();
            var klienci_form = new Klienci();
            klienci_form.FormClosed += (s, args) => this.Show();
            klienci_form.Show();
        }
    }
}
