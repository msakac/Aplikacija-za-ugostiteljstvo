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

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Forme
{
    public partial class FrmKorisnici : Form
    {

        bool zastavicaAzuriranje = false;
        string azurirajKorIme = "";
        Dictionary<string, string> grupiranje = new Dictionary<string, string>();
        Korisnik TrenutniKorisnik;

        public FrmKorisnici(Korisnik korisnik)
        {
            TrenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void FrmKorisnici_Load(object sender, EventArgs e)
        {
            OsvjeziTablice(null,null);
            PopuniCbo();
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            zastavicaAzuriranje = false;
            OcistiObrazac();
            panelKorisnik.Show();
        }
        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            zastavicaAzuriranje = true;
            Korisnik korisnik = null;
            azurirajKorIme = "";

            if (dgvKorisnici.CurrentRow != null)
            {
                korisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                panelKorisnik.Show();
                PopuniObrazac(korisnik);
                azurirajKorIme = korisnik.KorisnickoIme;
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran korisnik!";
                frmMessage.ShowDialog();
            }
        }
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = null;
            if (dgvKorisnici.CurrentRow != null)
            {
                korisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                if (korisnik.Id == TrenutniKorisnik.Id)
                {
                    FrmMessageBox frmMessage = new FrmMessageBox();
                    frmMessage.lblPoruka.Text = "Ne mozete obrisati svoj profil!";
                    frmMessage.ShowDialog();
                }
                else
                {
                    if (korisnik.Obrisan == 1)
                    {
                        KorisnikRepository.VratiKorisnika(korisnik);
                    }
                    else
                    {
                        KorisnikRepository.ObrisiKorisnika(korisnik);
                    }
                }
                
                OsvjeziTablice(null,null);
            }
            else
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Nije odabran korisnik!";
                frmMessage.ShowDialog();
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
                Korisnik noviKorisnik = new Korisnik(Int64.Parse(txtID.Text), txtIme.Text, txtPrezime.Text, txtKorIme.Text, txtLozinka.Text, Int64.Parse(txtUloga.Text), 0);
                if (zastavicaAzuriranje)
                {
                    KorisnikRepository.AzurirajKorisnika(noviKorisnik);
                }
                else
                {
                    KorisnikRepository.DodajKorisnika(noviKorisnik);
                }
                OsvjeziTablice(null,null);
            }
        }
        private void BtnGrupiraj_Click(object sender, EventArgs e)
        {
            string grupirajKljuc = grupiranje.FirstOrDefault(x => x.Value == cboGrupiraj.Text).Key;
            OsvjeziTablice(grupirajKljuc, null);

        }
        private void TxtPretrazi_TextChanged(object sender, EventArgs e)
        {
            string trazi = txtPretrazi.Text;
            OsvjeziTablice(null, trazi);
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            panelKorisnik.Hide();
        }


        //*********FUNKCIJE*********//
        private void PopuniCbo()
        //Popunjava combobox za grupiranje vrijednostima
        {
            //Id, Ime, Prezime, KorisnickoIme, IdUloga
            grupiranje.Add("Id", "ID-u");
            grupiranje.Add("Ime", "Imenu");
            grupiranje.Add("Prezime", "Prezimenu");
            grupiranje.Add("KorisnickoIme", "Korisnickom imenu");
            grupiranje.Add("IdUloga", "Ulozi");
            cboGrupiraj.DataSource = new BindingSource(grupiranje, null);
            cboGrupiraj.DisplayMember = "Value";
            cboGrupiraj.ValueMember = "Key";
        }
        private void OsvjeziTablice(string atribut, string trazi)
        //Osvjezava prikaz datagridview-a
        {
            dgvKorisnici.DataSource = KorisnikRepository.DohvatiKorisnike(atribut,trazi);
            dgvKorisnici.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvKorisnici.Columns[0].HeaderText = "ID";
            dgvKorisnici.Columns[3].HeaderText = "Korisničko ime";
            dgvKorisnici.Columns[5].HeaderText = "SHA1 lozinka";
            dgvKorisnici.Columns[6].HeaderText = "Uloga";
            dgvKorisnici.Columns[7].Visible = false;
            dgvKorisnici.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvKorisnici_CellFormatting);
            panelKorisnik.Hide();
        }
        private void DgvKorisnici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvKorisnici.Rows.Count-1; i++)
            {
                int obrisan = int.Parse(dgvKorisnici.Rows[i].Cells[7].Value.ToString());
                if (obrisan == 1)
                {
                    dgvKorisnici.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }
        private string ProvjeriUnos()
        //provjerava unos kod kreiranja novog korisnika
        {
            string greska = null;

            //provjeravamo da su podaci uneseni u sve textboxove
            foreach (TextBox tb in panelKorisnik.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()))
                {
                    greska = "Niste unijeli sve podatke";
                    return greska;
                }
            }
            //provjeravamo ulogu
            if (txtUloga.Text != "1" && txtUloga.Text != "0")
            {
                greska = "Uloga može biti 0 ili 1";
            }

            //provjeravamo dostupnost ID-a kod kreiranja novog korisnika
            if (!zastavicaAzuriranje && KorisnikRepository.ProvjeriID(Int64.Parse(txtID.Text)) != null)
            {
                greska = $"ID {txtID.Text} vec postoji u bazi!";
            }

            //provjeravamo dostupnost korisnickog imena kod kreiranja novog korisnika
            if (!zastavicaAzuriranje && KorisnikRepository.ProvjeriKorisnickoIme(txtKorIme.Text) != null)
            {
                greska = $"Korisničko ime {txtKorIme.Text} već postoji u bazi!";
            }

            //kod azuriranja provjeravamo dostupnost korisnickog imena ukoliko je originalno promijenjeno
            if (zastavicaAzuriranje && azurirajKorIme != txtKorIme.Text)
            {
                if (KorisnikRepository.ProvjeriKorisnickoIme(txtKorIme.Text) != null)
                {
                    greska = $"Korisničko ime {txtKorIme.Text} već postoji u bazi!";
                }
            }

            return greska;
        }
        private void PopuniObrazac(Korisnik korisnik)
        //popuni textboxove poodacima izabranog korisnika
        {
            txtID.Text = korisnik.Id.ToString();
            txtID.Enabled = false;
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtKorIme.Text = korisnik.KorisnickoIme;
            txtLozinka.Text = korisnik.Lozinka;
            txtUloga.Text = korisnik.IdUloga.ToString();
        }
        private void OcistiObrazac()
        //ocisti textboxove
        {
            panelKorisnik.Hide();
            txtID.Text = "";
            txtID.Enabled = true;
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKorIme.Text = "";
            txtLozinka.Text = "";
            txtUloga.Text = "";
        }

        private void DgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            Korisnik korisnik = null;
            if (dgvKorisnici.CurrentRow != null)
            {
                korisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                if (korisnik.Obrisan == 1)
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
