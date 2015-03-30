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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Fakture
    {
    public partial class frmNapraviFakturu : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private int fakturaID { get; set; }

        private int zalihaID { get; set; }

        private int kupacID { get; set; }

        private int proizvodID { get; set; }
        private string proizvodIme { get; set; }
        private decimal proizvodCijena { get; set; }
        private int proizvodKolicina { get; set; }
        private int proizvodDostupnaKolicina { get; set; }
        private decimal proizvodUkupnaCijena
            {
            get
                {
                return Decimal.Multiply(this.proizvodCijena, this.proizvodKolicina);
                }
        }

        private decimal iznosBezPdvFaktura { get; set; }
        private int iznosPdvProcenat { get { return 17; } }
        private decimal iznosPdv
            {
            get
                {
                return Decimal.Multiply(this.iznosBezPdvFaktura, 0.17M);
                }
        }
        private decimal iznosSaPdv
            {
            get
                {
                return Decimal.Multiply(this.iznosBezPdvFaktura, 1.17M);
                }
            }
        private decimal ukupnoPlatio { get; set; }
        private decimal dug
            {
            get
                {
                return Decimal.Subtract(this.ukupnoPlatio, this.iznosSaPdv);
                }
        }

        public frmNapraviFakturu()
            {
            InitializeComponent();
            btnDodajUKorpu.Enabled = false;
            btnNapraviFakturu.Enabled = false;
            PrikaziPodatke();
            }

        private void PrikaziPodatke()
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT A.ZalihaID, A.ProizvodID, B.ImeProizvoda, B.Cijena, A.Kolicina" 
                    + " FROM Zaliha AS A INNER JOIN Proizvod AS B ON A.ProizvodID = B.ProizvodID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Zaliha");
                        dataGridView2.DataSource = rezultati.Tables["Zaliha"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT * FROM Kupac";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Kupac");
                        dataGridView1.DataSource = rezultati.Tables["Kupac"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        private void btnNapraviFakturu_Click(object sender, EventArgs e)
            {
            if (txtKupacIme.Text == "")
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Faktura(FakturaDatum, KupacID, IznosBezPDV, PDVProcenat, PDVIznos, IznosSaPDV, UkupnoPlatio, Dug, Zabiljeske)"
                        + " VALUES (@fakturaDatum, @kupacID, @iznosBezPDV, @pdvProcenat, @pdvIznos, @iznosSaPDV, @ukupnoPlatio, @dug, @zabiljeske)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajFakturaParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašena faktura", "Kupac",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);                     
                            }
                        catch (Exception ex)
                            {
                            MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            }
                        finally
                            {
                            SpasiProdaniProizvod();
                            IzmijeniKolicinuUZalihi();
                            frmNapraviFakturu forma = new frmNapraviFakturu();
                            forma.Show();
                            this.Close();
                            }
                        }
                    }
                }
            }

        private List<OleDbParameter> DodajFakturaParametre()
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();

            OleDbParameter fakturaDatumPar = new OleDbParameter("@fakturaDatum", OleDbType.Date);
            OleDbParameter kupacIDPar = new OleDbParameter("@kupacID", OleDbType.Integer);
            OleDbParameter iznosBezPDVPar = new OleDbParameter("@iznosBezPDV", OleDbType.VarChar);
            OleDbParameter pdvProcenatPar = new OleDbParameter("@pdvProcenat", OleDbType.VarChar);
            OleDbParameter pdvIznosPar = new OleDbParameter("@pdvIznos", OleDbType.VarChar);
            OleDbParameter iznosSaPDVPar = new OleDbParameter("@iznosSaPDV", OleDbType.VarChar);
            OleDbParameter ukupnoPlatioPar = new OleDbParameter("@ukupnoPlatio", OleDbType.VarChar);
            OleDbParameter dugPar = new OleDbParameter("@dug", OleDbType.VarChar);
            OleDbParameter zabiljeskePar = new OleDbParameter("@zabiljeske", OleDbType.VarChar);

            fakturaDatumPar.Value = System.DateTime.Now;
            kupacIDPar.Value = this.kupacID;
            iznosBezPDVPar.Value = this.iznosBezPdvFaktura;
            pdvProcenatPar.Value = this.iznosPdvProcenat;
            pdvIznosPar.Value = this.iznosPdv;
            iznosSaPDVPar.Value = this.iznosSaPdv;
            ukupnoPlatioPar.Value = this.ukupnoPlatio;
            dugPar.Value = this.dug;
            if (txtZabiljeske.Text == "")
                zabiljeskePar.Value = "nije popunjeno";
            else
                zabiljeskePar.Value = txtZabiljeske.Text;

            parametri.Add(fakturaDatumPar);
            parametri.Add(kupacIDPar);
            parametri.Add(iznosBezPDVPar);
            parametri.Add(pdvProcenatPar);
            parametri.Add(pdvIznosPar);
            parametri.Add(iznosSaPDVPar);
            parametri.Add(ukupnoPlatioPar);
            parametri.Add(dugPar);
            parametri.Add(zabiljeskePar);

            return parametri;
            }

        private void SpasiProdaniProizvod()
            {
            DajFakturaID();
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO ProdanoProizvoda(FakturaID, ProizvodID, Kolicina, Cijena, UkupnaCijena)"
                        + " VALUES (@fakturaID, @proizvodID, @kolicina, @cijena, @ukupnaCijena)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajProdanoProizvodaParametre(i);
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
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

        private void DajFakturaID()
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT FakturaID FROM Faktura ORDER BY FakturaID DESC";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        this.fakturaID = Convert.ToInt32(mojUpit.ExecuteScalar().ToString());
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
        }

        private List<OleDbParameter> DodajProdanoProizvodaParametre(int broj)
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();
          
            OleDbParameter fakturaIDPar = new OleDbParameter("@fakturaID", OleDbType.Integer);
            OleDbParameter proizvodIDPar = new OleDbParameter("@proizvodID", OleDbType.VarChar);
            OleDbParameter kolicinaPar = new OleDbParameter("@kolicina", OleDbType.VarChar);
            OleDbParameter cijenaPar = new OleDbParameter("@cijena", OleDbType.VarChar);
            OleDbParameter ukupnaCijenaPar = new OleDbParameter("@ukupnaCijena", OleDbType.VarChar);

            fakturaIDPar.Value = fakturaID;
            proizvodIDPar.Value = listView1.Items[broj].SubItems[1].Text;
            kolicinaPar.Value = listView1.Items[broj].SubItems[4].Text;
            cijenaPar.Value = listView1.Items[broj].SubItems[3].Text;
            ukupnaCijenaPar.Value = listView1.Items[broj].SubItems[5].Text;

            parametri.Add(fakturaIDPar);
            parametri.Add(proizvodIDPar);
            parametri.Add(kolicinaPar);
            parametri.Add(cijenaPar);
            parametri.Add(ukupnaCijenaPar);

            return parametri;
            }

        private void IzmijeniKolicinuUZalihi()
            {
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "UPDATE Zaliha SET Kolicina = Kolicina - @kolicina, UkupnaCijena = UkupnaCijena - @ukupnaCijena WHERE ZalihaID = @zalihaID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajZalihaParametre(i);
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteNonQuery();
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

        private List<OleDbParameter> DodajZalihaParametre(int broj)
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();
          
            OleDbParameter zalihaIDPar = new OleDbParameter("@zalihaID", OleDbType.Integer);
            OleDbParameter kolicinaPar = new OleDbParameter("@kolicina", OleDbType.VarChar);
            OleDbParameter ukupnaCijenaPar = new OleDbParameter("@ukupnaCijena", OleDbType.VarChar);

            zalihaIDPar.Value = listView1.Items[broj].SubItems[0].Text;
            kolicinaPar.Value = listView1.Items[broj].SubItems[4].Text;
            ukupnaCijenaPar.Value = listView1.Items[broj].SubItems[5].Text;

            parametri.Add(zalihaIDPar);
            parametri.Add(kolicinaPar);
            parametri.Add(ukupnaCijenaPar);

            return parametri;
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {           
            this.Close();
            }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
                {
                DataGridViewRow podaci = dataGridView1.SelectedRows[0];
                PopuniKupacFormu(podaci);
                
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
                {
                DataGridViewRow podaci = dataGridView2.SelectedRows[0];
                PopuniProizvodFormu(podaci);
                
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }

        private void PopuniKupacFormu(DataGridViewRow podaci)
            {
            txtKupacIme.Text = podaci.Cells[1].Value.ToString();
            this.kupacID = (int)podaci.Cells[0].Value;

            if (txtProizvodIme.Text != "")
                btnDodajUKorpu.Enabled = true;
        }

        private void PopuniProizvodFormu(DataGridViewRow podaci)
            {
            this.zalihaID = (int)podaci.Cells[0].Value;

            this.proizvodID = (int)podaci.Cells[1].Value;

            this.proizvodIme = podaci.Cells[2].Value.ToString();
            txtProizvodIme.Text = this.proizvodIme;

            this.proizvodCijena = (decimal)podaci.Cells[3].Value;
            txtProizvodCijena.Text = this.proizvodCijena.ToString();

            this.proizvodDostupnaKolicina = (int)podaci.Cells[4].Value;
            txtDostupnaKolicina.Text = this.proizvodDostupnaKolicina.ToString();

            this.proizvodKolicina = (int)numKolicina.Value;

            txtProizvodUkupno.Text = this.proizvodUkupnaCijena.ToString();

            if (txtKupacIme.Text != "")
                btnDodajUKorpu.Enabled = true;

            numKolicina.Maximum = this.proizvodDostupnaKolicina;
        }

        private void btnDodajUKorpu_Click(object sender, EventArgs e)
            {
            listView1.Items.Add(new ListViewItem(new string[] {this.zalihaID.ToString(), this.proizvodID.ToString(), this.proizvodIme, this.proizvodCijena.ToString(), this.proizvodKolicina.ToString(), this.proizvodUkupnaCijena.ToString() }));
            this.iznosBezPdvFaktura += this.proizvodUkupnaCijena;
            btnNapraviFakturu.Enabled = true;
            IzracunajFakturu();
            }

        private void numKolicina_KeyUp(object sender, KeyEventArgs e)
            {
            this.proizvodKolicina = (int)numKolicina.Value;
            txtProizvodUkupno.Text = this.proizvodUkupnaCijena.ToString();
            }

        private void numPlatio_KeyUp(object sender, KeyEventArgs e)
            {
            this.ukupnoPlatio = (decimal)numPlatio.Value;
            IzracunajFakturu();
            }

        private void IzracunajFakturu()
            {
            txtUkupnoBezPDV.Text = this.iznosBezPdvFaktura.ToString();
            txtPDVProcenat.Text = this.iznosPdvProcenat.ToString();
            txtUkupnoSaPDV.Text = this.iznosSaPdv.ToString();
            txtDug.Text = this.dug.ToString();
            }
        }
    }
