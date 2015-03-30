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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Zaliha
    {
    public partial class frmDodajZalihu : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private int zalihaID { get; set; }
        private int proizvodID { get; set; }
        private int kolicina { get; set; }
        private decimal cijenaBezPdv { get; set; }
        private decimal ukupnaCijena
            {
            get
                {
                return (decimal)this.kolicina * this.cijenaBezPdv;
                }
        }

        public frmDodajZalihu(bool dodajUZalihu, bool ocistiFormu, bool spasi, bool obrisi)
            {
            InitializeComponent();
            btnDodajUZalihu.Enabled = dodajUZalihu;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            btnOcistiFormu.Enabled = ocistiFormu;
            PrikaziPodatke();
            }

        private void PopuniPolja()
            {
            this.proizvodID = (int)cmbProizvod.Tag;
            this.kolicina = (int)numKolicina.Value;
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT Cijena FROM Proizvod WHERE ProizvodID = @proizvodID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbParameter proizvodParID = new OleDbParameter("@proizvodID", OleDbType.Integer);
                        proizvodParID.Value = (int)cmbProizvod.Tag;
                        mojUpit.Parameters.Add(proizvodParID);

                        txtCijena.Text = mojUpit.ExecuteScalar().ToString();
                        this.cijenaBezPdv = Convert.ToDecimal(txtCijena.Text);
                        txtUkupnaCijena.Text = this.ukupnaCijena.ToString();
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
        }

        private void PrikaziPodatke()
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT Zaliha.ZalihaID, Zaliha.ProizvodID, Proizvod.ImeProizvoda, Zaliha.Kolicina, Zaliha.UkupnaCijena, Zaliha.ZalihaDatum" +
                    " FROM Zaliha INNER JOIN Proizvod ON Zaliha.ProizvodID = Proizvod.ProizvodID";
                    
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Proizvod");
                        dataGridView1.DataSource = rezultati.Tables["Proizvod"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        private void PopuniFormu(DataGridViewRow podaci)
            {
            this.zalihaID = (int)podaci.Cells[0].Value;

            cmbProizvod.Tag = (int)podaci.Cells[1].Value;
            cmbProizvod.Text = podaci.Cells[2].Value.ToString();

            numKolicina.Value = (int)podaci.Cells[3].Value;
            PopuniPolja();
            btnDodajUZalihu.Enabled = false;
            btnSpasi.Enabled = true;
            btnObrisi.Enabled = true;
            btnOcistiFormu.Enabled = true;
            }

        private List<OleDbParameter> DodajParametre()
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();

            OleDbParameter proizvodParID = new OleDbParameter("@proizvidID", OleDbType.Integer);
            OleDbParameter zalihaDatum = new OleDbParameter("@zalihaDatum", OleDbType.Date);
            OleDbParameter kolicinaPar = new OleDbParameter("@kolicina", OleDbType.Integer);
            OleDbParameter ukupnaCijenaPar = new OleDbParameter("@UkupnaCijena", OleDbType.VarChar);

            proizvodParID.Value = this.proizvodID;
            zalihaDatum.Value = System.DateTime.Now;
            kolicinaPar.Value = this.kolicina;
            ukupnaCijenaPar.Value = this.ukupnaCijena;
            
            parametri.Add(proizvodParID);
            parametri.Add(zalihaDatum);
            parametri.Add(kolicinaPar);
            parametri.Add(ukupnaCijenaPar);

            return parametri;
            }

        private void frmDodajZalihu_Load(object sender, EventArgs e)
            {                       
            this.proizvodTableAdapter.Fill(this.dB_PSS_PMDataSet.Proizvod);
            PopuniPolja();
            }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
                {
                DataGridViewRow podaci = dataGridView1.SelectedRows[0];
                PopuniFormu(podaci);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }

        private void btnDodajUZalihu_Click(object sender, EventArgs e)
            {
            if (numKolicina.Value == 0)
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Zaliha(ProizvodID, ZalihaDatum, Kolicina, UkupnaCijena)"
                        + " VALUES (@proizvodID, @zalihaDatum, @kolicina, @ukupnaCijena)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno dodano u zalihu", "Zaliha",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDodajZalihu forma = new frmDodajZalihu(true, false, false, false);
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
            if (numKolicina.Value == 0)
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "UPDATE Zaliha SET ProizvodID = @proizvodID, ZalihaDatum = @zalihaDatum, Kolicina = @kolicina,"
                        + " UkupnaCijena = @ukupnaCijena WHERE ZalihaID = @zalihaID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            OleDbParameter zalihaIDPar = new OleDbParameter("@zalihaID", OleDbType.Integer);
                            zalihaIDPar.Value = zalihaID;
                            mojUpit.Parameters.Add(zalihaIDPar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašeno", "Zaliha",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDodajZalihu forma = new frmDodajZalihu(true, false, false, false);
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

        private void btnObrisi_Click(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "DELETE FROM Zaliha WHERE ZalihaID = @zalihaID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {                      
                        OleDbParameter zalihaIDPar = new OleDbParameter("@zalihaID", OleDbType.Integer);
                        zalihaIDPar.Value = zalihaID;
                        mojUpit.Parameters.Add(zalihaIDPar);
                        mojaKonekcija.Open();
                        mojUpit.ExecuteReader();
                        MessageBox.Show("Uspješno obrisano", "Zaliha",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDodajZalihu forma = new frmDodajZalihu(true, false, false, false);
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

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void numKolicina_ValueChanged(object sender, EventArgs e)
            {
            PopuniPolja();
            }

        private void cmbProizvod_SelectedIndexChanged(object sender, EventArgs e)
            {
            PopuniPolja();
            }

        private void numKolicina_KeyUp(object sender, KeyEventArgs e)
            {
            PopuniPolja();
            }

        private void btnOcistiFormu_Click(object sender, EventArgs e)
            {
            frmDodajZalihu forma = new frmDodajZalihu(true, false, false, false);
            forma.Show();
            this.Close();
            }
        }
    }
