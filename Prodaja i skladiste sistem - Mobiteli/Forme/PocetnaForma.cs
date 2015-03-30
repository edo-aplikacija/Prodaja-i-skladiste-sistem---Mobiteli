using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void timerPocetna_Tick(object sender, EventArgs e)
        {
            Forme.Korisnici.PrijavaForma prijavaForma = new Korisnici.PrijavaForma();
            pgbPocetna.Visible = true;

            this.pgbPocetna.Value = this.pgbPocetna.Value + 5;
            if (this.pgbPocetna.Value < 70)
            {
                lbUcitavanje.Text = "Učitavanje programa...";
            }
            else if (pgbPocetna.Value < 100)
                {
                lbUcitavanje.Text = "Startanje programa...";
            }
            else if (pgbPocetna.Value == 100)
                {
                prijavaForma.Show();
                timerPocetna.Enabled = false;
                this.Hide();
            }


        }


    }
}
