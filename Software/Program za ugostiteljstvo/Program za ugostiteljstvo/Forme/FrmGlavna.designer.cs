namespace Program_za_ugostiteljstvo
{
    partial class FrmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.panelMeni = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrenutniKorisnik = new System.Windows.Forms.Label();
            this.odjavaBtn = new FontAwesome.Sharp.IconButton();
            this.artikliBtn = new FontAwesome.Sharp.IconButton();
            this.korisniciBtn = new FontAwesome.Sharp.IconButton();
            this.izvjescaBtn = new FontAwesome.Sharp.IconButton();
            this.blagajnaBtn = new FontAwesome.Sharp.IconButton();
            this.skladisteBtn = new FontAwesome.Sharp.IconButton();
            this.izradaRacunaBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.lblSat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trenutnaFormaLbl = new System.Windows.Forms.Label();
            this.trenutnaIkona = new FontAwesome.Sharp.IconPictureBox();
            this.timerSat = new System.Windows.Forms.Timer(this.components);
            this.panelForma = new System.Windows.Forms.Panel();
            this.panelMeni.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trenutnaIkona)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelMeni.Controls.Add(this.label1);
            this.panelMeni.Controls.Add(this.lblTrenutniKorisnik);
            this.panelMeni.Controls.Add(this.odjavaBtn);
            this.panelMeni.Controls.Add(this.artikliBtn);
            this.panelMeni.Controls.Add(this.korisniciBtn);
            this.panelMeni.Controls.Add(this.izvjescaBtn);
            this.panelMeni.Controls.Add(this.blagajnaBtn);
            this.panelMeni.Controls.Add(this.skladisteBtn);
            this.panelMeni.Controls.Add(this.izradaRacunaBtn);
            this.panelMeni.Controls.Add(this.panelLogo);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(200, 861);
            this.panelMeni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 736);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Konobar:";
            // 
            // lblTrenutniKorisnik
            // 
            this.lblTrenutniKorisnik.AutoSize = true;
            this.lblTrenutniKorisnik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrenutniKorisnik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrenutniKorisnik.ForeColor = System.Drawing.Color.Black;
            this.lblTrenutniKorisnik.Location = new System.Drawing.Point(0, 759);
            this.lblTrenutniKorisnik.Name = "lblTrenutniKorisnik";
            this.lblTrenutniKorisnik.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTrenutniKorisnik.Size = new System.Drawing.Size(149, 22);
            this.lblTrenutniKorisnik.TabIndex = 8;
            this.lblTrenutniKorisnik.Text = "<<korisnik>>";
            // 
            // odjavaBtn
            // 
            this.odjavaBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.odjavaBtn.FlatAppearance.BorderSize = 0;
            this.odjavaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odjavaBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.odjavaBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjavaBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.odjavaBtn.IconColor = System.Drawing.Color.Black;
            this.odjavaBtn.IconSize = 40;
            this.odjavaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odjavaBtn.Location = new System.Drawing.Point(0, 781);
            this.odjavaBtn.Name = "odjavaBtn";
            this.odjavaBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.odjavaBtn.Rotation = 0D;
            this.odjavaBtn.Size = new System.Drawing.Size(200, 80);
            this.odjavaBtn.TabIndex = 7;
            this.odjavaBtn.Text = "Odjavi se";
            this.odjavaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odjavaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.odjavaBtn.UseVisualStyleBackColor = true;
            this.odjavaBtn.Click += new System.EventHandler(this.OdjavaBtn_Click);
            // 
            // artikliBtn
            // 
            this.artikliBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.artikliBtn.FlatAppearance.BorderSize = 0;
            this.artikliBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artikliBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.artikliBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikliBtn.IconChar = FontAwesome.Sharp.IconChar.Cocktail;
            this.artikliBtn.IconColor = System.Drawing.Color.Black;
            this.artikliBtn.IconSize = 40;
            this.artikliBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artikliBtn.Location = new System.Drawing.Point(0, 480);
            this.artikliBtn.Name = "artikliBtn";
            this.artikliBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.artikliBtn.Rotation = 0D;
            this.artikliBtn.Size = new System.Drawing.Size(200, 80);
            this.artikliBtn.TabIndex = 6;
            this.artikliBtn.Text = "Artikli";
            this.artikliBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artikliBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.artikliBtn.UseVisualStyleBackColor = true;
            this.artikliBtn.Click += new System.EventHandler(this.ArtikliBtn_Click);
            // 
            // korisniciBtn
            // 
            this.korisniciBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.korisniciBtn.FlatAppearance.BorderSize = 0;
            this.korisniciBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.korisniciBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.korisniciBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisniciBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.korisniciBtn.IconColor = System.Drawing.Color.Black;
            this.korisniciBtn.IconSize = 40;
            this.korisniciBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.korisniciBtn.Location = new System.Drawing.Point(0, 400);
            this.korisniciBtn.Name = "korisniciBtn";
            this.korisniciBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.korisniciBtn.Rotation = 0D;
            this.korisniciBtn.Size = new System.Drawing.Size(200, 80);
            this.korisniciBtn.TabIndex = 5;
            this.korisniciBtn.Text = "Korisnici";
            this.korisniciBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.korisniciBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.korisniciBtn.UseVisualStyleBackColor = true;
            this.korisniciBtn.Click += new System.EventHandler(this.KorisniciBtn_Click);
            // 
            // izvjescaBtn
            // 
            this.izvjescaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.izvjescaBtn.FlatAppearance.BorderSize = 0;
            this.izvjescaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izvjescaBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.izvjescaBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izvjescaBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.izvjescaBtn.IconColor = System.Drawing.Color.Black;
            this.izvjescaBtn.IconSize = 40;
            this.izvjescaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.izvjescaBtn.Location = new System.Drawing.Point(0, 320);
            this.izvjescaBtn.Name = "izvjescaBtn";
            this.izvjescaBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.izvjescaBtn.Rotation = 0D;
            this.izvjescaBtn.Size = new System.Drawing.Size(200, 80);
            this.izvjescaBtn.TabIndex = 4;
            this.izvjescaBtn.Text = "Izvješća";
            this.izvjescaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.izvjescaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.izvjescaBtn.UseVisualStyleBackColor = true;
            this.izvjescaBtn.Click += new System.EventHandler(this.IzvjescaBtn_Click);
            // 
            // blagajnaBtn
            // 
            this.blagajnaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.blagajnaBtn.FlatAppearance.BorderSize = 0;
            this.blagajnaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blagajnaBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.blagajnaBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blagajnaBtn.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.blagajnaBtn.IconColor = System.Drawing.Color.Black;
            this.blagajnaBtn.IconSize = 40;
            this.blagajnaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blagajnaBtn.Location = new System.Drawing.Point(0, 240);
            this.blagajnaBtn.Name = "blagajnaBtn";
            this.blagajnaBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.blagajnaBtn.Rotation = 0D;
            this.blagajnaBtn.Size = new System.Drawing.Size(200, 80);
            this.blagajnaBtn.TabIndex = 3;
            this.blagajnaBtn.Text = "Blagajna";
            this.blagajnaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blagajnaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.blagajnaBtn.UseVisualStyleBackColor = true;
            this.blagajnaBtn.Click += new System.EventHandler(this.BlagajnaBtn_Click);
            // 
            // skladisteBtn
            // 
            this.skladisteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.skladisteBtn.FlatAppearance.BorderSize = 0;
            this.skladisteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skladisteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.skladisteBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skladisteBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.skladisteBtn.IconColor = System.Drawing.Color.Black;
            this.skladisteBtn.IconSize = 40;
            this.skladisteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skladisteBtn.Location = new System.Drawing.Point(0, 160);
            this.skladisteBtn.Name = "skladisteBtn";
            this.skladisteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.skladisteBtn.Rotation = 0D;
            this.skladisteBtn.Size = new System.Drawing.Size(200, 80);
            this.skladisteBtn.TabIndex = 2;
            this.skladisteBtn.Text = "Skladište";
            this.skladisteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skladisteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skladisteBtn.UseVisualStyleBackColor = true;
            this.skladisteBtn.Click += new System.EventHandler(this.SkladisteBtn_Click);
            // 
            // izradaRacunaBtn
            // 
            this.izradaRacunaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.izradaRacunaBtn.FlatAppearance.BorderSize = 0;
            this.izradaRacunaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izradaRacunaBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.izradaRacunaBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izradaRacunaBtn.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.izradaRacunaBtn.IconColor = System.Drawing.Color.Black;
            this.izradaRacunaBtn.IconSize = 40;
            this.izradaRacunaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.izradaRacunaBtn.Location = new System.Drawing.Point(0, 80);
            this.izradaRacunaBtn.Name = "izradaRacunaBtn";
            this.izradaRacunaBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.izradaRacunaBtn.Rotation = 0D;
            this.izradaRacunaBtn.Size = new System.Drawing.Size(200, 80);
            this.izradaRacunaBtn.TabIndex = 1;
            this.izradaRacunaBtn.Text = "Izrada računa";
            this.izradaRacunaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.izradaRacunaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.izradaRacunaBtn.UseVisualStyleBackColor = true;
            this.izradaRacunaBtn.Click += new System.EventHandler(this.IzradaRacunaBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logoPic);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // logoPic
            // 
            this.logoPic.Image = global::Program_za_ugostiteljstvo.Properties.Resources.Logoo;
            this.logoPic.Location = new System.Drawing.Point(12, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(164, 80);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 16;
            this.logoPic.TabStop = false;
            this.logoPic.Click += new System.EventHandler(this.LogoPic_Click);
            // 
            // lblSat
            // 
            this.lblSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(860, 22);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(112, 28);
            this.lblSat.TabIndex = 18;
            this.lblSat.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblSat);
            this.panel1.Controls.Add(this.trenutnaFormaLbl);
            this.panel1.Controls.Add(this.trenutnaIkona);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(6, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 3);
            this.panel2.TabIndex = 19;
            // 
            // trenutnaFormaLbl
            // 
            this.trenutnaFormaLbl.AutoSize = true;
            this.trenutnaFormaLbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trenutnaFormaLbl.Location = new System.Drawing.Point(40, 28);
            this.trenutnaFormaLbl.Name = "trenutnaFormaLbl";
            this.trenutnaFormaLbl.Size = new System.Drawing.Size(80, 22);
            this.trenutnaFormaLbl.TabIndex = 1;
            this.trenutnaFormaLbl.Text = "Početna";
            // 
            // trenutnaIkona
            // 
            this.trenutnaIkona.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.trenutnaIkona.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trenutnaIkona.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.trenutnaIkona.IconColor = System.Drawing.SystemColors.ControlText;
            this.trenutnaIkona.IconSize = 30;
            this.trenutnaIkona.Location = new System.Drawing.Point(6, 24);
            this.trenutnaIkona.Name = "trenutnaIkona";
            this.trenutnaIkona.Size = new System.Drawing.Size(32, 32);
            this.trenutnaIkona.TabIndex = 0;
            this.trenutnaIkona.TabStop = false;
            // 
            // timerSat
            // 
            this.timerSat.Tick += new System.EventHandler(this.TimerSat_Tick);
            // 
            // panelForma
            // 
            this.panelForma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelForma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForma.Location = new System.Drawing.Point(200, 80);
            this.panelForma.Name = "panelForma";
            this.panelForma.Size = new System.Drawing.Size(984, 781);
            this.panelForma.TabIndex = 20;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.panelForma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMeni);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CB RoSa";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.panelMeni.ResumeLayout(false);
            this.panelMeni.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trenutnaIkona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMeni;
        private FontAwesome.Sharp.IconButton izradaRacunaBtn;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton artikliBtn;
        private FontAwesome.Sharp.IconButton korisniciBtn;
        private FontAwesome.Sharp.IconButton izvjescaBtn;
        private FontAwesome.Sharp.IconButton blagajnaBtn;
        private FontAwesome.Sharp.IconButton skladisteBtn;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton odjavaBtn;
        private System.Windows.Forms.Label lblTrenutniKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoPic;
        private FontAwesome.Sharp.IconPictureBox trenutnaIkona;
        private System.Windows.Forms.Label trenutnaFormaLbl;
        private System.Windows.Forms.Timer timerSat;
        private System.Windows.Forms.Panel panelForma;
        private System.Windows.Forms.Panel panel2;
    }
}