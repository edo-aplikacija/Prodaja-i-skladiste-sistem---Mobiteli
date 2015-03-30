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
    public partial class GlavnaForma : Form
        {
        

        public GlavnaForma(string uloga, string korisnickoIme)
            {
            InitializeComponent();
            lblUloga.Text = uloga;
            lblKorisnickoIme.Text = korisnickoIme;
            lblDatumVrijeme.Text = DateTime.Now.ToString();
            }

        private void napustiProgramToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Close();
            Application.Exit();
            }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Forme.Korisnici.PrijavaForma prijava = new Korisnici.PrijavaForma();
            prijava.Show();
            this.Close();
            }

        private void btnDodajKupca_Click(object sender, EventArgs e)
            {
            Forme.Kupci.DodajKupcaForma dodajKupca = new Kupci.DodajKupcaForma(true, false, false, true);
            dodajKupca.Show();            
            }

        private void btnIzvjestajZaKupce_Click(object sender, EventArgs e)
            {
            Forme.Kupci.KupacForma forma = new Kupci.KupacForma(this);
            forma.Show();
            }

        private void btnKorisnici_Click(object sender, EventArgs e)
            {
            Forme.Korisnici.frmKorisnici forma = new Forme.Korisnici.frmKorisnici(this);
            forma.Show();
            }

        private void btnUpravljajKorisnicima_Click(object sender, EventArgs e)
            {
            Forme.Korisnici.frmRegistracija forma = new Forme.Korisnici.frmRegistracija(true, true, false, false);
            forma.Show();
            }

        private void btnProdaja_Click(object sender, EventArgs e)
            {
            Forme.Prodano.frmProdano forma = new Forme.Prodano.frmProdano();
            forma.Show();
            }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
            {
            Forme.Proizvodi.frmDodajProizvod forma = new Proizvodi.frmDodajProizvod(true, true, false, false);
            forma.Show();
            }

        private void btnZaliha_Click(object sender, EventArgs e)
            {
            Forme.Zaliha.frmDodajZalihu forma = new Forme.Zaliha.frmDodajZalihu(true, false, false, false);
            forma.Show();
            }

        private void btnKompanija_Click(object sender, EventArgs e)
            {
            Forme.Kompanije.frmDodajKompaniju forma = new Kompanije.frmDodajKompaniju(true, true, false, false);
            forma.Show();
            }

        private void btnKategorija_Click(object sender, EventArgs e)
            {
            Forme.Kategorije.frmDodajKategoriju forma = new Kategorije.frmDodajKategoriju(true, true, false, false);
            forma.Show();
            }

        private void btnFakture_Click(object sender, EventArgs e)
            {
            Forme.Fakture.frmNapraviFakturu forma = new Forme.Fakture.frmNapraviFakturu();
            forma.Show();
            }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Forme.Proizvodi.frmProizvod forma = new Forme.Proizvodi.frmProizvod(this);
            forma.Show();
            }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Forme.Kupci.KupacForma kupacForma = new Kupci.KupacForma(this);
            kupacForma.Show();
            }

        private void zalihaToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Forme.Zaliha.frmDodajZalihu forma = new Forme.Zaliha.frmDodajZalihu(true, false, false, false);
            forma.Show();
            }

        private void faktureToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Forme.Fakture.frmNapraviFakturu forma = new Forme.Fakture.frmNapraviFakturu();
            forma.Show();
            }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
            {
            
            }


        }
    }
