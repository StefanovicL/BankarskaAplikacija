using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public Form1()
        {
            InitializeComponent();
        }
        private void prikazi()
        {
            int broj = 0;
            int najveci = 0;

            foreach (RadioButton rb in gbRacun.Controls)
            {
                if (rb.Checked)
                {
                    foreach (BankaDataSet.KlijentRow red in bankaDataSet.Klijent.Rows)
                    {
                        if (rb.Text == red.RacunRow.Tip.ToString())
                        {
                            broj++;

                            if ((int)red[2] > najveci)
                                najveci = (int)red[2];
                        }
                    }
                    tbRacuni.Text = broj.ToString();
                    tbMaxNovca.Text = najveci.ToString();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.racunTableAdapter.Fill(this.bankaDataSet.Racun);
            this.klijentTableAdapter.Fill(this.bankaDataSet.Klijent);
        }

        private void obradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbRacun.Enabled = true;
        }

        private void rbNamenski_CheckedChanged(object sender, EventArgs e)
        {
            prikazi();
        }

        private void klijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbKlijenti.Enabled = true;
        }

        private void cmbIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPrikaz.Items.Clear();

            try
            {
                konekcija.Open();
                using (SqlCommand komanda = new SqlCommand())
                {
                    komanda.Connection = konekcija;
                    komanda.Parameters.AddWithValue("klijent", cmbIme.Text);
                    komanda.CommandText = "select klijentid, stanje from klijent where imeprezime=@klijent";
                    SqlDataReader reader = komanda.ExecuteReader();
                    while(reader.Read())
                    {
                        lbPrikaz.Items.Add("ID klijenta: " + reader[0].ToString() + " Stanje: " + reader[1].ToString() + "\n");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            lbPrikaz.Items.Clear();

            if(tbStanjeVeceOd.Text != "")
            {
                try
                {
                    konekcija.Open();
                    using(SqlCommand komanda = new SqlCommand())
                    {
                        komanda.Connection = konekcija;
                        komanda.Parameters.AddWithValue("iznos", int.Parse(tbStanjeVeceOd.Text));
                        komanda.CommandText = "select klijentid, stanje from klijent where stanje>@iznos";
                        SqlDataReader reader = komanda.ExecuteReader();
                        while (reader.Read())
                        {
                            lbPrikaz.Items.Add("ID klijenta: " + reader[0].ToString() + " Stanje: " + reader[1].ToString() + "\n");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            else
            {
                MessageBox.Show("Ovo polje je obavezno!", "Obavestenje");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Zelite da izbrisete?", "Potvrda", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                try
                {
                    konekcija.Open();
                    using (SqlCommand komanda = new SqlCommand("delete from klijent where klijentid=" + (int)dataGridView1.CurrentRow.Cells[0].Value, konekcija))
                    {
                        komanda.ExecuteNonQuery();
                        this.klijentTableAdapter.Fill(bankaDataSet.Klijent);
                        MessageBox.Show("Uspesno obrisan klijent");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }
    }
}
