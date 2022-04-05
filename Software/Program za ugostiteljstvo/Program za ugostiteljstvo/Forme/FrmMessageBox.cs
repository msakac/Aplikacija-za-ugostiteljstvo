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

namespace Program_za_ugostiteljstvo.Klase
{
    public partial class FrmMessageBox : Form
    {
        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e) //zatvara formu
        {
            this.Close();
        }
        private void LblPoruka_Paint(object sender, PaintEventArgs e) 
        {
            e.Graphics.DrawRectangle(new Pen(Color.DarkRed, 5),
                this.DisplayRectangle); //nacrta border oko labela
        }
    }
}
