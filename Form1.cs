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
            var formKlienci = new Samochody_Osobowe();
            formKlienci.FormClosed += (s, args) => this.Show(); // Pokazuje Form1 po zamkniêciu
            formKlienci.Show();
        }

        private void btn_pracownicy_Click(object sender, EventArgs e)
        {

        }

        private void btn_samochody_dostawcze_Click(object sender, EventArgs e)
        {

        }

        private void btn_klienci_Click(object sender, EventArgs e)
        {

        }
    }
}
