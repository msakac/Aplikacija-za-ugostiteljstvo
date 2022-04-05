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

namespace Program_za_ugostiteljstvo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LblExit_Click(object sender, EventArgs e) //klik event na label za zatvaranje forme
        {
            this.Close();
        }
        private void LblMinimize_Click(object sender, EventArgs e) //klik event na label za minimaliziranje forme
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void TxtUsername_Click(object sender, EventArgs e) //klik event na textbox korisnicko ime
        {
            if(txtUsername.Text == "Korisnicko ime")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
            if(txtPassword.Text == "")
            {
                PostaviFont();
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
                txtUsername.Text = "";
            }
        }
        private void TxtPassword_Click(object sender, EventArgs e) //klik event na textbox lozinka
        {
            if(txtPassword.Text == "Lozinka")
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
            if(txtUsername.Text == "")
            {
                PostaviFont();
                txtPassword.Text = "";
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e) //klik event na gumb 'Prijavi se'
        {
            Korisnik korisnik = KorisnikRepository.DohvatiKorisnika(txtUsername.Text, txtPassword.Text);
            if (korisnik == null)
            {
                FrmMessageBox frmMessage = new FrmMessageBox();
                frmMessage.lblPoruka.Text = "Neispravni korisnički podaci !";
                frmMessage.ShowDialog();
                PostaviFont();
            }
            else
            {
                this.Hide();
                FrmGlavna frmGlavna = new FrmGlavna(korisnik);
                frmGlavna.Closed += (s, args) => this.Close();
                frmGlavna.Show();
            }
        }
        private void TimerSat_Tick(object sender, EventArgs e)
        {
            lblSat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            timerSat.Start();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
        }
        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
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
        /// Funkcija postavlja placeholder i boju kad txtbox ostane prazan
        /// </summary>
        private void PostaviFont() 
        {
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Lozinka";
            txtPassword.ForeColor = Color.Gray;

            txtUsername.Text = "Korisnicko ime";
            txtUsername.ForeColor = Color.Gray;
        }
    }
}
