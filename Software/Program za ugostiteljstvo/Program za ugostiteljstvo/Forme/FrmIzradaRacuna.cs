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
    public partial class FrmIzradaRacuna : Form
    {
        private Korisnik TrenutniKorisnik { get; set; }
        private Dictionary<Int64, string> tipArtikla = new Dictionary<Int64, string>();
        private List<StavkaRacuna> stavkeRacuna = new List<StavkaRacuna>();

        public FrmIzradaRacuna(Korisnik korisnik)
        {
            InitializeComponent();
            TrenutniKorisnik = korisnik;
        }

        private void FrmIzradaRacuna_Load(object sender, EventArgs e)
        {
            PopuniCbo();
            Int64 idTipArtikla = tipArtikla.FirstOrDefault(x => x.Value == cboTipArtikla.Text).Key;
            OsvjeziTablicuArtikla(idTipArtikla);
            
            
        }
        private void CboTipArtikla_SelectedValueChanged(object sender, EventArgs e)
        {
            Int64 idTipArtikla = tipArtikla.FirstOrDefault(x => x.Value == cboTipArtikla.Text).Key;
            OsvjeziTablicuArtikla(idTipArtikla);
        }
        private void BtnDodajNaRacun_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.CurrentRow != null)
            {
                DodajArtiklNaRacun();  
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran artikl!";
                frmMessage.ShowDialog();
            }
        }
        private void DgvArtikli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DodajArtiklNaRacun();
        }
        private void BtnObrisiSaRacuna_Click(object sender, EventArgs e)
        {
            if (dgvRacun.CurrentRow != null)
            {
                StavkaRacuna stavka = null;
                stavka = dgvRacun.CurrentRow.DataBoundItem as StavkaRacuna;
                stavkeRacuna.Remove(stavka);
                OsvjeziTablicuRacun();
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran artikl na računu";
                frmMessage.ShowDialog();
            }
        }
        private void BtnPodesiKolicinu_Click(object sender, EventArgs e)
        {
            if (dgvRacun.CurrentRow != null)
            {
                StavkaRacuna stavka = null;
                stavka = dgvRacun.CurrentRow.DataBoundItem as StavkaRacuna;
                panelPodesiKoličinu.Show();
                lblID.Text = stavka.IdArtikl.Id.ToString();
                lblNaziv.Text = stavka.Naziv;
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran artikl na računu";
                frmMessage.ShowDialog();
            }
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            txtKolicina.Text = "";
            panelPodesiKoličinu.Hide();
        }
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            string greske = ProvjeriUnosKolicine();
            if (greske != null)
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = greske;
                frmMessage.ShowDialog();

            }
            else
            {
                stavkeRacuna.FirstOrDefault(s => s.IdArtikl.Id == Int64.Parse(lblID.Text)).Kolicina = int.Parse(txtKolicina.Text);
                panelPodesiKoličinu.Hide();
                OsvjeziTablicuRacun();
            }
        }
        private void BtnNoviRacun_Click(object sender, EventArgs e)
        {
            if(stavkeRacuna.Count > 0)
            {
                stavkeRacuna.Clear();
                OsvjeziTablicuRacun();
            }
        }
        private void BtnSpremiRacun_Click(object sender, EventArgs e)
        {
            if (stavkeRacuna.Count() > 0)
            {
                DateTime vrijeme = DateTime.Now;
                double ukupno = Double.Parse(txtUkupno.Text);
                double osnovica = Double.Parse(txtOsnovica.Text);
                double porez = Double.Parse(txtPorez.Text);
                Racun noviRacun = new Racun(vrijeme, ukupno, osnovica, porez, TrenutniKorisnik);

                RacunRepository.DodajRacun(noviRacun);

                foreach (StavkaRacuna stavka in stavkeRacuna)
                {
                    int idRacuna = RacunRepository.DohvatiZadnjiRacun();
                    StavkeRacunaRepository.DodajStavkuRacuna(stavka, idRacuna);
                    int kolicina = stavka.IdArtikl.DostupnaKolicina - stavka.Kolicina;
                    ArtiklRepository.DodajKolicinu(stavka.IdArtikl.Id, kolicina);
                }
                stavkeRacuna.Clear();
                OsvjeziTablicuRacun();
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nema nijedne stavke na računu";
                frmMessage.ShowDialog();
            }
        }

        //FUNKCIJE
        private void PopuniCbo()
        {
            // popis tipa artikala za filtriranje
            foreach (var item in TipArtiklRepository.DohvatiTipoveArtikla())
            {
                tipArtikla.Add(item.Id, item.Naziv);
            }
            cboTipArtikla.DataSource = new BindingSource(tipArtikla, null);
            cboTipArtikla.DisplayMember = "Value";
            cboTipArtikla.ValueMember = "Key";
        }
        private void OsvjeziTablicuArtikla(Int64 tipArtikla)
            //Osvjezava datagrid artikla
        {
            dgvArtikli.DataSource = ArtiklRepository.DohvatiArtiklePoTipu(tipArtikla);
            dgvArtikli.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvArtikli.Columns[0].Visible = false;
            dgvArtikli.Columns[2].Visible = false;
            dgvArtikli.Columns[5].Visible = false;
            dgvArtikli.Columns[6].Visible = false;
            dgvArtikli.Columns[7].Visible = false;
            panelPodesiKoličinu.Hide();
        }
        private void OsvjeziTablicuRacun()
            //osvjezava datagrid racuna
        {
            dgvRacun.DataSource = null;
            dgvRacun.DataSource = stavkeRacuna;
            dgvRacun.Columns[0].Visible = false;
            dgvRacun.Columns[1].Visible = false;
            dgvRacun.Columns[2].HeaderText = "Artikl";
            dgvRacun.ClearSelection();
            UkupnaCijena();
        }
        public string ProvjeriUnosKolicine()
        {
            // provjera unosa u polje količina
            string greska = null;
            int kolicina;
            var kolicinaBroj = int.TryParse(txtKolicina.Text, out kolicina);
            if (!kolicinaBroj)
            {
                greska = "Format unosa je neispravan!";
            }
            if (kolicina < 1)
            {
                greska = "Količina mora biti veća od 1";
            }
            return greska;
        }
        public void UkupnaCijena()
        {
            double ukupnaCijena = 0;
            double porez = 0;
            double osnovica = 0;

            // izračun ukupne cijene računa
            foreach (StavkaRacuna stavka in stavkeRacuna)
            {
                ukupnaCijena += stavka.Cijena * stavka.Kolicina;
            }
            porez = ukupnaCijena / 100 * 13;
            osnovica = ukupnaCijena - porez;
            txtUkupno.Text = ukupnaCijena.ToString();
            txtPorez.Text = porez.ToString();
            txtOsnovica.Text = osnovica.ToString();
        }
        private void DodajArtiklNaRacun()
        {
            Artikl artikl = null;
            artikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
            
            // provjera postojanja ID-a artikla
            if (stavkeRacuna.Exists(s => s.IdArtikl.Id == artikl.Id))
            {
                stavkeRacuna.FirstOrDefault(s => s.IdArtikl.Id == artikl.Id).Kolicina += 1;
            }
            else
            {
                stavkeRacuna.Add(new StavkaRacuna(artikl, artikl.Naziv, artikl.Cijena, 1));
            }

            OsvjeziTablicuRacun();
        }


    }
}
