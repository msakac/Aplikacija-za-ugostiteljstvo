using Program_za_ugostiteljstvo.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Forme
{
    public partial class FrmBlagajna : Form
    {
        public FrmBlagajna()
        {
            InitializeComponent();
        }

        private void FrmBlagajna_Load(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.ToString("dd/MM/yyyy");
            OsvjeziTablice();
            // prostor za graf
            chart1.ChartAreas[0].AxisX.Maximum = 24;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
        }
        private void DgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            Racun racun = null;
            racun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
            DohvatiStavkeRacuna(racun);
        }

        //FUNKCIJE
        private void OsvjeziTablice()
        //Osvjezava prikaz datagridview-a
        {
            List<Racun> listaRacuna = RacunRepository.DohvatiRacunePoDatumu();
            List<StavkaRacuna> stavkeRacuna = StavkeRacunaRepository.DohvatiStavkeRacuna();
            dgvRacuni.DataSource = listaRacuna;
            dgvRacuni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvRacuni.Columns[0].HeaderText = "ID";
            dgvRacuni.Columns[1].HeaderText = "Datum";
            dgvRacuni.Columns[5].HeaderText = "Korisnik";
            txtUkupnoRacuna.Text = listaRacuna.Count.ToString();
            txtUkupnaZarada.Text = listaRacuna.Sum(r => r.Ukupno).ToString();
            txtUkupnoProdanihArtikala.Text = stavkeRacuna.Sum(s => s.Kolicina).ToString();
            PopuniGraf(listaRacuna);
        }
        private void DohvatiStavkeRacuna(Racun racun)
            //Funkcija dohvaca i u datagrid upisuje stavke po racunu
        {
            dgvArtikli.DataSource = null;
            dgvArtikli.DataSource = StavkeRacunaRepository.DohvatiStavkePoRacunu(racun);
            dgvArtikli.Columns[0].Visible = false;
            dgvArtikli.Columns[1].Visible = false;
        }

        private void PopuniGraf(List<Racun> listaRacuna)
            //funkcija popunjava graf racunima tekuceg dana
        {
            DateTime datumVrijeme = DateTime.Now;  //17:35
            int sat = datumVrijeme.Hour + 1; //18

            DateTime datum = datumVrijeme.AddHours(-datumVrijeme.Hour).AddMinutes(-datumVrijeme.Minute).AddSeconds(-datumVrijeme.Second); // 00:00

            for (int i = 0; i < sat; i++)
            {
                int brojRacuna = 0;
                foreach (Racun racun in listaRacuna)
                {
                    if (racun.DatumVrijeme >= datum && racun.DatumVrijeme <= datum.AddHours(1)) // 00:35 >= 00:00 && 00:35 <= 01:00 T
                    {
                        brojRacuna++;
                    }
                }
                chart1.Series["Vrijeme"].Points.AddXY(datum.Hour, brojRacuna);
                datum = datum.AddHours(1);
            }

        }
    }
}
