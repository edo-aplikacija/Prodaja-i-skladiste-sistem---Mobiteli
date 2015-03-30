using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.IO;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Proizvodi
    {
    public partial class frmDodajProizvod : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private OleDbParameter proizvodID { get; set; }

        public frmDodajProizvod(bool spasiNoviProizvod, bool izaberi, bool spasi, bool obrisi)
            {
            InitializeComponent();
            btnSpasiNoviProizvod.Enabled = spasiNoviProizvod;
            btnIzaberiProizvod.Enabled = izaberi;
            btnSpasi.Enabled = spasi;
            btnObriši.Enabled = obrisi;
            PopuniKategorijuKompaniju();
            }

        public frmDodajProizvod(bool spasiNoviProizvod, bool izaberi, bool spasi, bool obrisi, int proizvodID)
            {
            InitializeComponent();
            btnSpasiNoviProizvod.Enabled = spasiNoviProizvod;
            btnIzaberiProizvod.Enabled = izaberi;
            btnSpasi.Enabled = spasi;
            btnObriši.Enabled = obrisi;
            PopuniKategorijuKompaniju();
            this.proizvodID = new OleDbParameter("@proizvodID", OleDbType.Integer);
            this.proizvodID.Value = proizvodID;          
            }

        private List<OleDbParameter> DodajParametre()
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();

            OleDbParameter imeProizvoda = new OleDbParameter("@imeProizvoda", OleDbType.VarChar);
            OleDbParameter kategorijaID = new OleDbParameter("@kategorijaID", OleDbType.Integer);
            OleDbParameter kompanijaID = new OleDbParameter("@kompanijaID", OleDbType.Integer);
            OleDbParameter cijena = new OleDbParameter("@cijena", OleDbType.VarChar);
            OleDbParameter odlike = new OleDbParameter("@odlike", OleDbType.VarChar);
            OleDbParameter slika = new OleDbParameter("@slika", OleDbType.VarBinary);

            imeProizvoda.Value = txtImeProizvoda.Text;
            kategorijaID.Value = cmbKategorija.Tag;
            kompanijaID.Value = cmbKompanija.Tag;
            
            cijena.Value = numCijena.Value.ToString();
            if (txtOdlike.Text == "")
                odlike.Value = "nije popunjeno";
            else
                odlike.Value = txtOdlike.Text;

            using (MemoryStream ms = new MemoryStream())
                {
                try
                    {
                    Bitmap bitSlika = new Bitmap(pcbSlika.Image);
                    bitSlika.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] podaci = ms.GetBuffer();
                    slika.Value = podaci;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }            
            parametri.Add(imeProizvoda);
            parametri.Add(kategorijaID);
            parametri.Add(kompanijaID);
            parametri.Add(cijena);
            parametri.Add(odlike);
            parametri.Add(slika);

            return parametri;
            }

        private void btnSpasiNoviProizvod_Click(object sender, EventArgs e)
            {
            if (txtImeProizvoda.Text == "")
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Proizvod(ImeProizvoda, KategorijaID, KompanijaID, Cijena, Odlike, Slika)"
                        + " VALUES (@imeProizvoda, @kategorijaID, @kompanijaID, @cijena, @odlike, @slika)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašen novi proizvod", "Proizvod",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDodajProizvod forma = new frmDodajProizvod(true, true, false, false);
                            forma.Show();
                            this.Close();
                            }
                        catch (Exception ex)
                            {
                            MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            }
                        }
                    }
                }
            }


        private void btnSpasi_Click(object sender, EventArgs e)
            {
            if (txtImeProizvoda.Text == "")
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "UPDATE Proizvod SET ImeProizvoda = @imeProizvoda, KategorijaID = @kategorijaID, " +
                        "KompanijaID = @kompanijaID, Cijena = @cijena, Odlike = @odlike, Slika = @slika " +
                        "WHERE ProizvodID = @proizvodID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojUpit.Parameters.Add(proizvodID);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašen proizvod", "Proizvod",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDodajProizvod forma = new frmDodajProizvod(true, true, false, false);
                            forma.Show();
                            this.Close();
                            }
                        catch (Exception ex)
                            {
                            MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            }
                        }
                    }
                }
            }

        private void btnObriši_Click(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "DELETE FROM Proizvod WHERE ProizvodID = @proizvodID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {                        
                        mojUpit.Parameters.Add(proizvodID);
                        mojaKonekcija.Open();
                        mojUpit.ExecuteReader();
                        MessageBox.Show("Uspješno obrisan proizvod", "Proizvod",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDodajProizvod forma = new frmDodajProizvod(true, true, false, false);
                        forma.Show();
                        this.Close();
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        private void btnIzaberiProizvod_Click(object sender, EventArgs e)
            {
            frmProizvod forma = new frmProizvod(this);
            forma.Show();
            this.Hide();
            }

        private void btnIzaberiSliku_Click(object sender, EventArgs e)
            {
            try
                {
                var izaberiSliku = openFileDialog1;
                izaberiSliku.Filter = ("Image Files |*.png; *.bmp; *.jpg; *jpeg; *.gif;");
                izaberiSliku.FilterIndex = 4;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pcbSlika.Image = Image.FromFile(openFileDialog1.FileName);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void PopuniKategorijuKompaniju()
            {
            this.kategorijaTableAdapter.Fill(this.dB_PSS_PMDataSet.Kategorija);
            this.kompanijaTableAdapter.Fill(this.dB_PSS_PMDataSet.Kompanija);
            }

        }
    }
