using FontAwesome.Sharp;
using Program_za_ugostiteljstvo.Forme;
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

//Kreirali: Martin Sakač i Borna Rosandić

namespace Program_za_ugostiteljstvo
{
    public partial class FrmGlavna : Form
    {
        private IconButton trenutniBtn;
        private Panel rubPanel;
        private Form trenutnaForma;

        public Korisnik TrenutniKorisnik { get; set; }

        public FrmGlavna(Korisnik korisnik)
        {
            InitializeComponent();
            TrenutniKorisnik = korisnik;

            //Dekoracija kraj gumba
            rubPanel = new Panel();
            rubPanel.Size = new Size(7, 80);
            panelMeni.Controls.Add(rubPanel);

            lblTrenutniKorisnik.Text = korisnik.KorisnickoIme;

            //Ako korisnik nije admin, sakrivamo tipke
            if (!KorisnikRepository.IsAdmin(korisnik))
            {
                artikliBtn.Hide();
                korisniciBtn.Hide();
            }

        }

        private void IzradaRacunaBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OtvoriFormu(new FrmIzradaRacuna(TrenutniKorisnik));
        }
        private void SkladisteBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OtvoriFormu(new FrmSkladiste());
        }
        private void BlagajnaBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OtvoriFormu(new FrmBlagajna());
        }
        private void IzvjescaBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OtvoriFormu(new FrmIzvjesca());
        }
        private void KorisniciBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OtvoriFormu(new FrmKorisnici(TrenutniKorisnik));
        }
        private void ArtikliBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           OtvoriFormu(new FrmArtikli());
        }
        private void OdjavaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin loginFrm = new FrmLogin();
            loginFrm.Closed += (s, args) => this.Close();
            loginFrm.Show();
        }
        private void LogoPic_Click(object sender, EventArgs e)
        {
            DisableButton();
            trenutnaIkona.IconChar = IconChar.Home;
            trenutnaFormaLbl.Text = "Početna";
            OtvoriFormu(new FrmPocetna());
        }
        private void TimerSat_Tick(object sender, EventArgs e)
        {
            lblSat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            timerSat.Start();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
            OtvoriFormu(new FrmPocetna());
        }
        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory + "\\user_help.chm";
                if (System.IO.File.Exists(putanja))
                {
                    System.Diagnostics.Process.Start(putanja);
                }
                else
                {
                    FrmMessageBox frmMessage = new FrmMessageBox();
                    frmMessage.lblPoruka.Text = $"Ne mogu otvoriti pomoć!";
                    frmMessage.ShowDialog();
                }
            }
        }


        /// <summary>
        /// Funkcija na pritisak tipke postavlja dizajn iste i ikonu i tekst u zaglavlju
        /// </summary>
        /// <param name="senderBtn">Parametar funkcije koji sadrži referencu na objekt koji je podigao dogadaj </param>
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Dizajn tipke
                trenutniBtn = (IconButton)senderBtn;
                trenutniBtn.BackColor = Color.White;
                trenutniBtn.ForeColor = Color.DeepSkyBlue;
                trenutniBtn.TextAlign = ContentAlignment.MiddleCenter;
                trenutniBtn.IconColor = Color.DeepSkyBlue;
                trenutniBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                trenutniBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Lijevi rub kraj tipke
                rubPanel.Show();
                rubPanel.BackColor = Color.Black;
                rubPanel.Location = new Point(0, trenutniBtn.Location.Y);
                rubPanel.Visible = true;
                rubPanel.BringToFront();
                //Ikona i tekst u zaglavlju
                trenutnaIkona.IconChar = trenutniBtn.IconChar;
                trenutnaFormaLbl.Text = trenutniBtn.Text;
            }
        }

        /// <summary>
        /// Funkcija vraća dizajn pritisnute tipke na početno stanje
        /// </summary>
        private void DisableButton()
        {
            if (trenutniBtn != null)
            {
                //Vraćanje tipke na podeseno
                trenutniBtn.BackColor = Color.DeepSkyBlue;
                trenutniBtn.ForeColor = Color.Black;
                trenutniBtn.TextAlign = ContentAlignment.MiddleLeft;
                trenutniBtn.IconColor = Color.Black;
                trenutniBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                trenutniBtn.ImageAlign = ContentAlignment.MiddleLeft;
                rubPanel.Hide();
            }
        }

        /// <summary>
        /// Funkcija otvara novu formu i po potrebi zatvara prethodno otvorenu formu
        /// </summary>
        /// <param name="novaForma">Parametar funkcije instanca klase Form</param>
        private void OtvoriFormu(Form novaForma)
        {
            if (trenutnaForma != null)
            {
                trenutnaForma.Close();
            }
            trenutnaForma = novaForma;
            novaForma.TopLevel = false;
            novaForma.FormBorderStyle = FormBorderStyle.None;
            novaForma.Dock = DockStyle.Fill;
            panelForma.Controls.Add(novaForma);
            panelForma.Tag = novaForma;
            novaForma.BringToFront();
            novaForma.Show();
        }
    }
}
