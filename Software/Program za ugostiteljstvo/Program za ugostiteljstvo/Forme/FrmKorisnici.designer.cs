namespace Program_za_ugostiteljstvo.Forme
{
    partial class FrmKorisnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new FontAwesome.Sharp.IconButton();
            this.btnAzuriraj = new FontAwesome.Sharp.IconButton();
            this.btnObrisi = new FontAwesome.Sharp.IconButton();
            this.panelKorisnik = new System.Windows.Forms.Panel();
            this.txtUloga = new System.Windows.Forms.TextBox();
            this.btnOdustani = new FontAwesome.Sharp.IconButton();
            this.btnSpremi = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.trenutnaFormaLbl = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrupiraj = new FontAwesome.Sharp.IconButton();
            this.cboGrupiraj = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.panelKorisnik.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKorisnici.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKorisnici.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKorisnici.EnableHeadersVisualStyles = false;
            this.dgvKorisnici.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 63);
            this.dgvKorisnici.Name = "dgvKorisnici";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKorisnici.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKorisnici.Size = new System.Drawing.Size(944, 233);
            this.dgvKorisnici.TabIndex = 3;
            this.dgvKorisnici.SelectionChanged += new System.EventHandler(this.DgvKorisnici_SelectionChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodaj.IconColor = System.Drawing.Color.Black;
            this.btnDodaj.IconSize = 40;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(12, 302);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDodaj.Rotation = 0D;
            this.btnDodaj.Size = new System.Drawing.Size(215, 55);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj korisnika";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAzuriraj.FlatAppearance.BorderSize = 0;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAzuriraj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAzuriraj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.btnAzuriraj.IconColor = System.Drawing.Color.Black;
            this.btnAzuriraj.IconSize = 40;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(233, 302);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAzuriraj.Rotation = 0D;
            this.btnAzuriraj.Size = new System.Drawing.Size(225, 55);
            this.btnAzuriraj.TabIndex = 7;
            this.btnAzuriraj.Text = "Ažuriraj korisnika";
            this.btnAzuriraj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.BtnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnObrisi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnObrisi.IconColor = System.Drawing.Color.Black;
            this.btnObrisi.IconSize = 40;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Location = new System.Drawing.Point(741, 302);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnObrisi.Rotation = 0D;
            this.btnObrisi.Size = new System.Drawing.Size(215, 55);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši korisnika";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // panelKorisnik
            // 
            this.panelKorisnik.BackColor = System.Drawing.Color.PowderBlue;
            this.panelKorisnik.Controls.Add(this.txtUloga);
            this.panelKorisnik.Controls.Add(this.btnOdustani);
            this.panelKorisnik.Controls.Add(this.btnSpremi);
            this.panelKorisnik.Controls.Add(this.label5);
            this.panelKorisnik.Controls.Add(this.label4);
            this.panelKorisnik.Controls.Add(this.txtLozinka);
            this.panelKorisnik.Controls.Add(this.label3);
            this.panelKorisnik.Controls.Add(this.txtKorIme);
            this.panelKorisnik.Controls.Add(this.label2);
            this.panelKorisnik.Controls.Add(this.txtPrezime);
            this.panelKorisnik.Controls.Add(this.label1);
            this.panelKorisnik.Controls.Add(this.txtIme);
            this.panelKorisnik.Controls.Add(this.trenutnaFormaLbl);
            this.panelKorisnik.Controls.Add(this.txtID);
            this.panelKorisnik.Location = new System.Drawing.Point(208, 390);
            this.panelKorisnik.Name = "panelKorisnik";
            this.panelKorisnik.Size = new System.Drawing.Size(521, 291);
            this.panelKorisnik.TabIndex = 9;
            this.panelKorisnik.Visible = false;
            // 
            // txtUloga
            // 
            this.txtUloga.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUloga.Location = new System.Drawing.Point(361, 136);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(141, 29);
            this.txtUloga.TabIndex = 14;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdustani.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOdustani.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnOdustani.IconColor = System.Drawing.Color.Black;
            this.btnOdustani.IconSize = 20;
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(361, 191);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOdustani.Rotation = 0D;
            this.btnOdustani.Size = new System.Drawing.Size(141, 36);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpremi.FlatAppearance.BorderSize = 0;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSpremi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSpremi.IconColor = System.Drawing.Color.Black;
            this.btnSpremi.IconSize = 20;
            this.btnSpremi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpremi.Location = new System.Drawing.Point(26, 191);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSpremi.Rotation = 0D;
            this.btnSpremi.Size = new System.Drawing.Size(141, 36);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpremi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(357, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uloga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(188, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lozinka";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtLozinka.Location = new System.Drawing.Point(192, 136);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(141, 29);
            this.txtLozinka.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Korisničko ime";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtKorIme.Location = new System.Drawing.Point(26, 136);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(141, 29);
            this.txtKorIme.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPrezime.Location = new System.Drawing.Point(361, 51);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(141, 29);
            this.txtPrezime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(188, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtIme.Location = new System.Drawing.Point(192, 51);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(141, 29);
            this.txtIme.TabIndex = 4;
            // 
            // trenutnaFormaLbl
            // 
            this.trenutnaFormaLbl.AutoSize = true;
            this.trenutnaFormaLbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trenutnaFormaLbl.Location = new System.Drawing.Point(22, 26);
            this.trenutnaFormaLbl.Name = "trenutnaFormaLbl";
            this.trenutnaFormaLbl.Size = new System.Drawing.Size(108, 22);
            this.trenutnaFormaLbl.TabIndex = 3;
            this.trenutnaFormaLbl.Text = "ID korisnika";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtID.Location = new System.Drawing.Point(26, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(141, 29);
            this.txtID.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnGrupiraj);
            this.panel1.Controls.Add(this.cboGrupiraj);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPretrazi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 45);
            this.panel1.TabIndex = 15;
            // 
            // btnGrupiraj
            // 
            this.btnGrupiraj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGrupiraj.FlatAppearance.BorderSize = 0;
            this.btnGrupiraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrupiraj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGrupiraj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupiraj.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGrupiraj.IconColor = System.Drawing.Color.Black;
            this.btnGrupiraj.IconSize = 20;
            this.btnGrupiraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrupiraj.Location = new System.Drawing.Point(3, 4);
            this.btnGrupiraj.Name = "btnGrupiraj";
            this.btnGrupiraj.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGrupiraj.Rotation = 0D;
            this.btnGrupiraj.Size = new System.Drawing.Size(141, 36);
            this.btnGrupiraj.TabIndex = 15;
            this.btnGrupiraj.Text = "Grupiraj";
            this.btnGrupiraj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrupiraj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrupiraj.UseVisualStyleBackColor = false;
            this.btnGrupiraj.Click += new System.EventHandler(this.BtnGrupiraj_Click);
            // 
            // cboGrupiraj
            // 
            this.cboGrupiraj.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboGrupiraj.FormattingEnabled = true;
            this.cboGrupiraj.Location = new System.Drawing.Point(150, 7);
            this.cboGrupiraj.Name = "cboGrupiraj";
            this.cboGrupiraj.Size = new System.Drawing.Size(202, 30);
            this.cboGrupiraj.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label9.Location = new System.Drawing.Point(718, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Pretraži";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPretrazi.Location = new System.Drawing.Point(798, 7);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(141, 29);
            this.txtPretrazi.TabIndex = 6;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.TxtPretrazi_TextChanged);
            // 
            // FrmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelKorisnik);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvKorisnici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmKorisnici";
            this.Text = "FrmKorisnici";
            this.Load += new System.EventHandler(this.FrmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.panelKorisnik.ResumeLayout(false);
            this.panelKorisnik.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private FontAwesome.Sharp.IconButton btnDodaj;
        private FontAwesome.Sharp.IconButton btnAzuriraj;
        private FontAwesome.Sharp.IconButton btnObrisi;
        private System.Windows.Forms.Panel panelKorisnik;
        private System.Windows.Forms.TextBox txtID;
        private FontAwesome.Sharp.IconButton btnOdustani;
        private FontAwesome.Sharp.IconButton btnSpremi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label trenutnaFormaLbl;
        private System.Windows.Forms.TextBox txtUloga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboGrupiraj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPretrazi;
        private FontAwesome.Sharp.IconButton btnGrupiraj;
    }
}