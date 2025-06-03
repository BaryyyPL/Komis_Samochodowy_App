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
        public Samochody_Osobowe()
        {
            InitializeComponent();
        }

        private void btn_cofnij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
