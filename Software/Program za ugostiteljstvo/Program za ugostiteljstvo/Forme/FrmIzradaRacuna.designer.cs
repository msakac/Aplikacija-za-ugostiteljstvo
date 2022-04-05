namespace Program_za_ugostiteljstvo.Forme
{
    partial class FrmIzradaRacuna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.cboTipArtikla = new System.Windows.Forms.ComboBox();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.btnDodajNaRacun = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiSaRacuna = new FontAwesome.Sharp.IconButton();
            this.btnPodesiKolicinu = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOsnovica = new System.Windows.Forms.TextBox();
            this.txtPorez = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnSpremiRacun = new FontAwesome.Sharp.IconButton();
            this.btnNoviRacun = new FontAwesome.Sharp.IconButton();
            this.panelPodesiKoličinu = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnOdustani = new FontAwesome.Sharp.IconButton();
            this.btnSpremi = new FontAwesome.Sharp.IconButton();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.trenutnaFormaLbl = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.panelPodesiKoličinu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvArtikli.Location = new System.Drawing.Point(12, 95);
            this.dgvArtikli.Name = "dgvArtikli";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikli.Size = new System.Drawing.Size(390, 353);
            this.dgvArtikli.TabIndex = 8;
            this.dgvArtikli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArtikli_CellDoubleClick);
            // 
            // cboTipArtikla
            // 
            this.cboTipArtikla.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboTipArtikla.FormattingEnabled = true;
            this.cboTipArtikla.Location = new System.Drawing.Point(12, 48);
            this.cboTipArtikla.Name = "cboTipArtikla";
            this.cboTipArtikla.Size = new System.Drawing.Size(302, 30);
            this.cboTipArtikla.TabIndex = 16;
            this.cboTipArtikla.SelectedValueChanged += new System.EventHandler(this.CboTipArtikla_SelectedValueChanged);
            // 
            // dgvRacun
            // 
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRacun.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacun.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRacun.EnableHeadersVisualStyles = false;
            this.dgvRacun.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvRacun.Location = new System.Drawing.Point(501, 50);
            this.dgvRacun.Name = "dgvRacun";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacun.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRacun.Size = new System.Drawing.Size(455, 218);
            this.dgvRacun.TabIndex = 17;
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDodajNaRacun.FlatAppearance.BorderSize = 0;
            this.btnDodajNaRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajNaRacun.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDodajNaRacun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaRacun.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnDodajNaRacun.IconColor = System.Drawing.Color.Black;
            this.btnDodajNaRacun.IconSize = 40;
            this.btnDodajNaRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNaRacun.Location = new System.Drawing.Point(12, 455);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDodajNaRacun.Rotation = 0D;
            this.btnDodajNaRacun.Size = new System.Drawing.Size(246, 55);
            this.btnDodajNaRacun.TabIndex = 18;
            this.btnDodajNaRacun.Text = "Dodaj artikl na račun";
            this.btnDodajNaRacun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNaRacun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajNaRacun.UseVisualStyleBackColor = false;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.BtnDodajNaRacun_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tip artikla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Račun";
            // 
            // btnObrisiSaRacuna
            // 
            this.btnObrisiSaRacuna.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnObrisiSaRacuna.FlatAppearance.BorderSize = 0;
            this.btnObrisiSaRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiSaRacuna.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnObrisiSaRacuna.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSaRacuna.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnObrisiSaRacuna.IconColor = System.Drawing.Color.Black;
            this.btnObrisiSaRacuna.IconSize = 30;
            this.btnObrisiSaRacuna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiSaRacuna.Location = new System.Drawing.Point(501, 335);
            this.btnObrisiSaRacuna.Name = "btnObrisiSaRacuna";
            this.btnObrisiSaRacuna.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnObrisiSaRacuna.Rotation = 0D;
            this.btnObrisiSaRacuna.Size = new System.Drawing.Size(127, 55);
            this.btnObrisiSaRacuna.TabIndex = 21;
            this.btnObrisiSaRacuna.Text = "Obriši s računa";
            this.btnObrisiSaRacuna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiSaRacuna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiSaRacuna.UseVisualStyleBackColor = false;
            this.btnObrisiSaRacuna.Click += new System.EventHandler(this.BtnObrisiSaRacuna_Click);
            // 
            // btnPodesiKolicinu
            // 
            this.btnPodesiKolicinu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPodesiKolicinu.FlatAppearance.BorderSize = 0;
            this.btnPodesiKolicinu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPodesiKolicinu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPodesiKolicinu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodesiKolicinu.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnPodesiKolicinu.IconColor = System.Drawing.Color.Black;
            this.btnPodesiKolicinu.IconSize = 30;
            this.btnPodesiKolicinu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodesiKolicinu.Location = new System.Drawing.Point(501, 274);
            this.btnPodesiKolicinu.Name = "btnPodesiKolicinu";
            this.btnPodesiKolicinu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPodesiKolicinu.Rotation = 0D;
            this.btnPodesiKolicinu.Size = new System.Drawing.Size(127, 55);
            this.btnPodesiKolicinu.TabIndex = 22;
            this.btnPodesiKolicinu.Text = "Podesi količinu";
            this.btnPodesiKolicinu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodesiKolicinu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPodesiKolicinu.UseVisualStyleBackColor = false;
            this.btnPodesiKolicinu.Click += new System.EventHandler(this.BtnPodesiKolicinu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Osnovica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Porez:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ukupno:";
            // 
            // txtOsnovica
            // 
            this.txtOsnovica.Enabled = false;
            this.txtOsnovica.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtOsnovica.Location = new System.Drawing.Point(750, 285);
            this.txtOsnovica.Name = "txtOsnovica";
            this.txtOsnovica.Size = new System.Drawing.Size(180, 29);
            this.txtOsnovica.TabIndex = 26;
            // 
            // txtPorez
            // 
            this.txtPorez.Enabled = false;
            this.txtPorez.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPorez.Location = new System.Drawing.Point(750, 320);
            this.txtPorez.Name = "txtPorez";
            this.txtPorez.Size = new System.Drawing.Size(180, 29);
            this.txtPorez.TabIndex = 27;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Enabled = false;
            this.txtUkupno.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupno.Location = new System.Drawing.Point(750, 355);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(180, 29);
            this.txtUkupno.TabIndex = 28;
            // 
            // btnSpremiRacun
            // 
            this.btnSpremiRacun.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpremiRacun.FlatAppearance.BorderSize = 0;
            this.btnSpremiRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremiRacun.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSpremiRacun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiRacun.IconChar = FontAwesome.Sharp.IconChar.Hdd;
            this.btnSpremiRacun.IconColor = System.Drawing.Color.Black;
            this.btnSpremiRacun.IconSize = 40;
            this.btnSpremiRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpremiRacun.Location = new System.Drawing.Point(750, 390);
            this.btnSpremiRacun.Name = "btnSpremiRacun";
            this.btnSpremiRacun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSpremiRacun.Rotation = 0D;
            this.btnSpremiRacun.Size = new System.Drawing.Size(215, 55);
            this.btnSpremiRacun.TabIndex = 29;
            this.btnSpremiRacun.Text = "Spremi račun";
            this.btnSpremiRacun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpremiRacun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpremiRacun.UseVisualStyleBackColor = false;
            this.btnSpremiRacun.Click += new System.EventHandler(this.BtnSpremiRacun_Click);
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNoviRacun.FlatAppearance.BorderSize = 0;
            this.btnNoviRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoviRacun.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNoviRacun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviRacun.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnNoviRacun.IconColor = System.Drawing.Color.Black;
            this.btnNoviRacun.IconSize = 40;
            this.btnNoviRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviRacun.Location = new System.Drawing.Point(750, 451);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNoviRacun.Rotation = 0D;
            this.btnNoviRacun.Size = new System.Drawing.Size(215, 55);
            this.btnNoviRacun.TabIndex = 30;
            this.btnNoviRacun.Text = "Novi račun";
            this.btnNoviRacun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviRacun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoviRacun.UseVisualStyleBackColor = false;
            this.btnNoviRacun.Click += new System.EventHandler(this.BtnNoviRacun_Click);
            // 
            // panelPodesiKoličinu
            // 
            this.panelPodesiKoličinu.BackColor = System.Drawing.Color.PowderBlue;
            this.panelPodesiKoličinu.Controls.Add(this.lblID);
            this.panelPodesiKoličinu.Controls.Add(this.btnOdustani);
            this.panelPodesiKoličinu.Controls.Add(this.btnSpremi);
            this.panelPodesiKoličinu.Controls.Add(this.lblNaziv);
            this.panelPodesiKoličinu.Controls.Add(this.trenutnaFormaLbl);
            this.panelPodesiKoličinu.Controls.Add(this.txtKolicina);
            this.panelPodesiKoličinu.Location = new System.Drawing.Point(453, 411);
            this.panelPodesiKoličinu.Name = "panelPodesiKoličinu";
            this.panelPodesiKoličinu.Size = new System.Drawing.Size(240, 230);
            this.panelPodesiKoličinu.TabIndex = 31;
            this.panelPodesiKoličinu.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblID.Location = new System.Drawing.Point(192, 144);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 22);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
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
            this.btnOdustani.Location = new System.Drawing.Point(45, 138);
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
            this.btnSpremi.Location = new System.Drawing.Point(45, 96);
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
            // lblNaziv
            // 
            this.lblNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(67, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(119, 22);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "NazivArtikla";
            // 
            // trenutnaFormaLbl
            // 
            this.trenutnaFormaLbl.AutoSize = true;
            this.trenutnaFormaLbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trenutnaFormaLbl.Location = new System.Drawing.Point(79, 36);
            this.trenutnaFormaLbl.Name = "trenutnaFormaLbl";
            this.trenutnaFormaLbl.Size = new System.Drawing.Size(76, 22);
            this.trenutnaFormaLbl.TabIndex = 3;
            this.trenutnaFormaLbl.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtKolicina.Location = new System.Drawing.Point(3, 61);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(234, 29);
            this.txtKolicina.TabIndex = 1;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(936, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "kn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(936, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "kn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(936, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "kn";
            // 
            // FrmIzradaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 742);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelPodesiKoličinu);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.btnSpremiRacun);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtPorez);
            this.Controls.Add(this.txtOsnovica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPodesiKolicinu);
            this.Controls.Add(this.btnObrisiSaRacuna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.cboTipArtikla);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "FrmIzradaRacuna";
            this.Text = "FrmIzradaRacuna";
            this.Load += new System.EventHandler(this.FrmIzradaRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.panelPodesiKoličinu.ResumeLayout(false);
            this.panelPodesiKoličinu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.ComboBox cboTipArtikla;
        private System.Windows.Forms.DataGridView dgvRacun;
        private FontAwesome.Sharp.IconButton btnDodajNaRacun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnObrisiSaRacuna;
        private FontAwesome.Sharp.IconButton btnPodesiKolicinu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOsnovica;
        private System.Windows.Forms.TextBox txtPorez;
        private System.Windows.Forms.TextBox txtUkupno;
        private FontAwesome.Sharp.IconButton btnSpremiRacun;
        private FontAwesome.Sharp.IconButton btnNoviRacun;
        private System.Windows.Forms.Panel panelPodesiKoličinu;
        private System.Windows.Forms.Label lblID;
        private FontAwesome.Sharp.IconButton btnOdustani;
        private FontAwesome.Sharp.IconButton btnSpremi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label trenutnaFormaLbl;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}