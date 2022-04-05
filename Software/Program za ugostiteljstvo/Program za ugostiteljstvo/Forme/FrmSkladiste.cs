using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_za_ugostiteljstvo.Klase;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Forme
{
    public partial class FrmSkladiste : Form
    {
        public FrmSkladiste()
        {
            InitializeComponent();
        }

        private void FrmSkladiste_Load(object sender, EventArgs e)
        {
            OsvjeziTablice();
        }
        private void DgvArtikli_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvArtikli.Rows.Count; i++)
            {
                // provjera kritične i dostupne količine artikala na skladištu
                int dostupnaKolicina = int.Parse(dgvArtikli.Rows[i].Cells[5].Value.ToString());
                int kriticnaKolicina = int.Parse(dgvArtikli.Rows[i].Cells[6].Value.ToString());
                if (dostupnaKolicina < kriticnaKolicina)
                {
                    dgvArtikli.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            string greske = ProvjeriUnos();
            if (greske != null)
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = greske;
                frmMessage.ShowDialog();

            }
            else
            {
                // ako nema greške dodaje se novi artikl i količina na skaldište
                int novaKolicina = int.Parse(lblDostupnaKolicina.Text) + int.Parse(txtKolicina.Text);
                Int64 id = Int64.Parse(lblID.Text);
                ArtiklRepository.DodajKolicinu(id, novaKolicina);
                FrmMessageBox frmMessage = new FrmMessageBox();
                // povratna poruka potvrde
                frmMessage.lblPoruka.Text = $"Dodali ste {txtKolicina.Text} {lblNaziv.Text} na skladiste";
                frmMessage.ShowDialog();
                OsvjeziTablice();
            }
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            panelDodajKolicinu.Hide();
            txtKolicina.Text = "";
        }
        private void BtnDodajKolicinu_Click(object sender, EventArgs e)
        {
            txtKolicina.Text = "";
            Artikl artikl = null;

            if (dgvArtikli.CurrentRow != null)
            {
                artikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                panelDodajKolicinu.Show();
                PopuniObrazac(artikl);
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran artikl!";
                frmMessage.ShowDialog();
            }
        }

        //FUNKCIJE
        private void PopuniObrazac(Artikl artikl)
        {
            lblNaziv.Text = artikl.Naziv.ToString();
            lblDostupnaKolicina.Text = artikl.DostupnaKolicina.ToString();
            lblKriticnaKolicina.Text = artikl.KriticnaKolicina.ToString();
            lblID.Text = artikl.Id.ToString();
        }
        private string ProvjeriUnos()
        {
            string greska = null;
            int kolicina;
            // provjera unosa u polje količina
            var kolicinaBroj = int.TryParse(txtKolicina.Text, out kolicina);
            if (!kolicinaBroj)
            {
                greska = "Format unosa je neispravan!";
            }

            return greska;
        }
        private void OsvjeziTablice()
        //Osvjezava prikaz datagridview-a
        {
            dgvArtikli.DataSource = ArtiklRepository.DohvatiArtikle();
            dgvArtikli.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvArtikli.Columns[0].HeaderText = "ID";
            dgvArtikli.Columns[2].HeaderText = "Tip";
            dgvArtikli.Columns[5].HeaderText = "Dostupna kolicina";
            dgvArtikli.Columns[6].HeaderText = "Kriticna kolicina";
            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvArtikli_CellFormatting);
            panelDodajKolicinu.Hide();
        }
    }
}
