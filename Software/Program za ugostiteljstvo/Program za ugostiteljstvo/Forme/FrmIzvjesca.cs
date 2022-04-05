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

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Forme
{
    public partial class FrmIzvjesca : Form
    {

        Dictionary<string, string> grupiranje = new Dictionary<string, string>();

        public FrmIzvjesca()
        {
            InitializeComponent();
        }

        private void FrmIzvjesca_Load(object sender, EventArgs e)
        {
            OsvjeziTablice(null);
            grupiranje.Add("DatumVrijeme", "Po datumu");
            grupiranje.Add("IdKorisnik", "Po korisniku");
            grupiranje.Add("Ukupno", "Po ukupno");
            cboGrupiraj.DataSource = new BindingSource(grupiranje, null);
            cboGrupiraj.DisplayMember = "Value";
            cboGrupiraj.ValueMember = "Key";
        }
        private void DgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            Racun racun = null;
            racun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
            DohvatiStavkeRacuna(racun);
        }
        private void BtnObrisiRacun_Click(object sender, EventArgs e)
        {
            Racun racun = null;
            if (dgvRacuni.CurrentRow != null)
            {
                racun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
                StavkeRacunaRepository.ObrisiStavkeRacuna(racun);
                RacunRepository.ObrisiRacun(racun);
                OsvjeziTablice(null);
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran račun!";
                frmMessage.ShowDialog();
            }
        }
        private void BtnGrupiraj_Click(object sender, EventArgs e)
        {
            string grupirajKljuc = grupiranje.FirstOrDefault(x => x.Value == cboGrupiraj.Text).Key;
            OsvjeziTablice(grupirajKljuc);
        }

        //FUNKCIJE
        private void DohvatiStavkeRacuna(Racun racun)
        {
            dgvArtikli.DataSource = null;
            dgvArtikli.DataSource = StavkeRacunaRepository.DohvatiStavkePoRacunu(racun);
            dgvArtikli.Columns[0].Visible = false;
            dgvArtikli.Columns[1].Visible = false;
        }
        private void OsvjeziTablice(string atribut)
        //Osvjezava prikaz datagridview-a
        {
            List<Racun> listaRacuna = RacunRepository.DohvatiRacune(atribut);
            List<StavkaRacuna> stavkeRacuna = StavkeRacunaRepository.DohvatiStavkeRacuna();
            dgvRacuni.DataSource = listaRacuna;
            dgvRacuni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvRacuni.Columns[0].HeaderText = "ID";
            dgvRacuni.Columns[1].HeaderText = "Datum";
            dgvRacuni.Columns[5].HeaderText = "Korisnik";
            txtUkupnoRacuna.Text = listaRacuna.Count.ToString();
            txtUkupnaZarada.Text = listaRacuna.Sum(r => r.Ukupno).ToString();
            txtUkupanPorez.Text = listaRacuna.Sum(r => r.Porez).ToString();
            txtUkupnoProdanihArtikala.Text = stavkeRacuna.Sum(s => s.Kolicina).ToString();
        }
    }
}
