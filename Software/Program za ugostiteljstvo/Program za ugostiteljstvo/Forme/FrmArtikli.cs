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
    public partial class FrmArtikli : Form
    {
        bool zastavicaAzuriranje = false;
        Dictionary<Int64, string> tipArtikla = new Dictionary<Int64, string>(); //za dodavanje novog i azuriranje artikla
        Dictionary<string, string> grupiranje = new Dictionary<string, string>(); //za grupiranje

        public FrmArtikli()
        {
            InitializeComponent();
        }

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziTablice(null,null);
            PopuniCbo();
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            zastavicaAzuriranje = false;
            OcistiObrazac();
            panelArtikl.Show();
        }
        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            zastavicaAzuriranje = true;
            Artikl artikl = null;

            if (dgvArtikli.CurrentRow != null)
            {
                artikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                panelArtikl.Show();
                PopuniObrazac(artikl);
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran artikl!";
                frmMessage.ShowDialog();
            }
        }
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            // obrisati odabran artikl iz popisa
            Artikl artikl = null;
            if (dgvArtikli.CurrentRow != null)
            {
                artikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                if (artikl.Obrisan == 1)
                {
                    ArtiklRepository.VratiArtikl(artikl);
                }
                else
                {
                    ArtiklRepository.ObrisiArtikl(artikl);
                }
                OsvjeziTablice(null, null);
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran artikl!";
                frmMessage.ShowDialog();
            }
        }
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            // provjera unosa novog artikla
            string greske = ProvjeriUnos();
            if (greske != null)
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = greske;
                frmMessage.ShowDialog();

            }
            else
            {
                // unos novog artikla
                Int64 idTipArtikla = tipArtikla.FirstOrDefault(x => x.Value == cboTipArtikla.Text).Key;
                TipArtikl tipArtikl = null;
                tipArtikl = TipArtiklRepository.DohvatiTipArtikla(idTipArtikla);

                Artikl noviArtikl = new Artikl(Int64.Parse(txtID.Text), txtNaziv.Text, tipArtikl, double.Parse(txtDoza.Text), double.Parse(txtCijena.Text), int.Parse(txtDostupnaKol.Text), int.Parse(txtKriticnaKol.Text), 0);
                if (zastavicaAzuriranje)
                {
                    ArtiklRepository.AzurirajArtikl(noviArtikl);
                }
                else
                {
                    ArtiklRepository.DodajArtikl(noviArtikl);
                }
                OsvjeziTablice(null, null);
            }
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            panelArtikl.Hide();
        }
        private void TxtPretrazi_TextChanged(object sender, EventArgs e)
        {
            // metoda za pretraživanje
            string trazi = txtPretrazi.Text;
            OsvjeziTablice(null, trazi);
        }
        private void BtnGrupiraj_Click(object sender, EventArgs e)
        {
            // metoda za grupiranje
            string grupirajKljuc = grupiranje.FirstOrDefault(x => x.Value == cboGrupiraj.Text).Key;
            OsvjeziTablice(grupirajKljuc, null);
        }
        private void DgvArtikli_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // uvjet za kritičnu količinu
            for (int i = 0; i < dgvArtikli.Rows.Count-1; i++)
            {
                int obrisan = int.Parse(dgvArtikli.Rows[i].Cells[7].Value.ToString());
                int dostupnaKolicina = int.Parse(dgvArtikli.Rows[i].Cells[5].Value.ToString());
                int kriticnaKolicina = int.Parse(dgvArtikli.Rows[i].Cells[6].Value.ToString());
                if (dostupnaKolicina < kriticnaKolicina)
                {
                    dgvArtikli.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (obrisan == 1)
                {
                    dgvArtikli.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }

        //FUNKCIJE
        private void OsvjeziTablice(string atribut, string trazi)
        //Osvjezava prikaz datagridview-a
        {
            dgvArtikli.DataSource = ArtiklRepository.DohvatiSveArtikle(atribut, trazi);
            dgvArtikli.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvArtikli.Columns[0].HeaderText = "ID";
            dgvArtikli.Columns[2].HeaderText = "Tip";
            dgvArtikli.Columns[5].HeaderText = "Dostupna kolicina";
            dgvArtikli.Columns[6].HeaderText = "Kriticna kolicina";
            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvArtikli_CellFormatting);
            panelArtikl.Hide();
        }
        private void PopuniCbo()
        //Popunjava combobox za grupiranje i combobox-a za tip artikla
        {
            //Id, Naziv, IdTipArtikl, Doza, Cijena, DostupnaKolicina, KriticnaKolicina
            grupiranje.Add("Id", "ID-u");
            grupiranje.Add("Naziv", "Nazivu");
            grupiranje.Add("IdTipArtikl", "Tipu artikla");
            grupiranje.Add("Cijena", "Cijeni");
            grupiranje.Add("DostupnaKolicina", "Dostupnoj kolicini");
            cboGrupiraj.DataSource = new BindingSource(grupiranje, null);
            cboGrupiraj.DisplayMember = "Value";
            cboGrupiraj.ValueMember = "Key";

            foreach (var item in TipArtiklRepository.DohvatiTipoveArtikla())
            {
                tipArtikla.Add(item.Id, item.Naziv);
            }
            cboTipArtikla.DataSource = new BindingSource(tipArtikla, null);
            cboTipArtikla.DisplayMember = "Value";
            cboTipArtikla.ValueMember = "Key";
        }
        private void OcistiObrazac()
        {
            //brisanje vrijedonsti iz prikaza na formi
            panelArtikl.Hide();
            txtID.Text = "";
            txtID.Enabled = true;
            txtNaziv.Text = "";
            txtCijena.Text = "";
            txtDostupnaKol.Text = "";
            txtDoza.Text = "";
            txtKriticnaKol.Text = "";
        }
        private string ProvjeriUnos()
        {
            string greska = null;

            //provjeravamo da su podaci uneseni u sve textboxove
            foreach (TextBox tb in panelArtikl.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()))
                {
                    greska = "Niste unijeli sve podatke";
                    return greska;
                }
            }

            //provjeravamo dostupnost ID-a kod kreiranja novog korisnika
            if (!zastavicaAzuriranje && ArtiklRepository.ProvjeriID(Int64.Parse(txtID.Text)) != null)
            {
                greska = $"ID {txtID.Text} vec postoji u bazi!";
            }
            //provjera numerickih vrijednosti
            double doza;
            var dozaBroj = double.TryParse(txtDoza.Text, out doza);
            double cijena;
            var cijenaBroj = double.TryParse(txtCijena.Text, out cijena);
            double kritKol;
            var kritKolBroj = double.TryParse(txtKriticnaKol.Text, out kritKol);
            double dostKol;
            var dostKolBroj = double.TryParse(txtDostupnaKol.Text, out dostKol);
            if (!dozaBroj || !cijenaBroj || !kritKolBroj || !dostKolBroj)
            {
                greska = "Format unosa je neispravan!";
            }

            return greska;
        }
        private void PopuniObrazac(Artikl artikl)
        {
            // postavljanje vrijednosti u formu 
            txtID.Text = artikl.Id.ToString();
            txtID.Enabled = false;
            txtNaziv.Text = artikl.Naziv.ToString();
            txtCijena.Text = artikl.Cijena.ToString();
            txtDostupnaKol.Text = artikl.DostupnaKolicina.ToString();
            txtDoza.Text = artikl.Doza.ToString();
            txtKriticnaKol.Text = artikl.KriticnaKolicina.ToString();
            cboTipArtikla.SelectedIndex = cboTipArtikla.FindString(artikl.IdTipArtikl.Naziv);

        }

        private void DgvArtikli_SelectionChanged(object sender, EventArgs e)
        {
            Artikl artikl = null;
            if (dgvArtikli.CurrentRow != null)
            {
                artikl = dgvArtikli.CurrentRow.DataBoundItem as Artikl;
                if (artikl.Obrisan == 1)
                {
                    btnObrisi.Text = "Vrati";
                }
                else
                {
                    btnObrisi.Text = "Obrisi";
                }
            }
        }
    }
}
