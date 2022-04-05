namespace Program_za_ugostiteljstvo.Forme
{
    partial class FrmSkladiste
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnDodajKolicinu = new FontAwesome.Sharp.IconButton();
            this.panelDodajKolicinu = new System.Windows.Forms.Panel();
            this.lblKriticnaKolicina = new System.Windows.Forms.Label();
            this.lblDostupnaKolicina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new FontAwesome.Sharp.IconButton();
            this.btnSpremi = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.trenutnaFormaLbl = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.panelDodajKolicinu.SuspendLayout();
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
            this.dgvArtikli.Location = new System.Drawing.Point(12, 12);
            this.dgvArtikli.Name = "dgvArtikli";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikli.Size = new System.Drawing.Size(944, 233);
            this.dgvArtikli.TabIndex = 5;
            this.dgvArtikli.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvArtikli_CellFormatting);
            // 
            // btnDodajKolicinu
            // 
            this.btnDodajKolicinu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDodajKolicinu.FlatAppearance.BorderSize = 0;
            this.btnDodajKolicinu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajKolicinu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDodajKolicinu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKolicinu.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnDodajKolicinu.IconColor = System.Drawing.Color.Black;
            this.btnDodajKolicinu.IconSize = 40;
            this.btnDodajKolicinu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajKolicinu.Location = new System.Drawing.Point(12, 251);
            this.btnDodajKolicinu.Name = "btnDodajKolicinu";
            this.btnDodajKolicinu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDodajKolicinu.Rotation = 0D;
            this.btnDodajKolicinu.Size = new System.Drawing.Size(215, 55);
            this.btnDodajKolicinu.TabIndex = 11;
            this.btnDodajKolicinu.Text = "Dodaj količinu";
            this.btnDodajKolicinu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajKolicinu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKolicinu.UseVisualStyleBackColor = false;
            this.btnDodajKolicinu.Click += new System.EventHandler(this.BtnDodajKolicinu_Click);
            // 
            // panelDodajKolicinu
            // 
            this.panelDodajKolicinu.BackColor = System.Drawing.Color.PowderBlue;
            this.panelDodajKolicinu.Controls.Add(this.lblID);
            this.panelDodajKolicinu.Controls.Add(this.lblKriticnaKolicina);
            this.panelDodajKolicinu.Controls.Add(this.lblDostupnaKolicina);
            this.panelDodajKolicinu.Controls.Add(this.label1);
            this.panelDodajKolicinu.Controls.Add(this.btnOdustani);
            this.panelDodajKolicinu.Controls.Add(this.btnSpremi);
            this.panelDodajKolicinu.Controls.Add(this.label2);
            this.panelDodajKolicinu.Controls.Add(this.lblNaziv);
            this.panelDodajKolicinu.Controls.Add(this.trenutnaFormaLbl);
            this.panelDodajKolicinu.Controls.Add(this.txtKolicina);
            this.panelDodajKolicinu.Location = new System.Drawing.Point(316, 324);
            this.panelDodajKolicinu.Name = "panelDodajKolicinu";
            this.panelDodajKolicinu.Size = new System.Drawing.Size(364, 263);
            this.panelDodajKolicinu.TabIndex = 14;
            this.panelDodajKolicinu.Visible = false;
            // 
            // lblKriticnaKolicina
            // 
            this.lblKriticnaKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKriticnaKolicina.AutoSize = true;
            this.lblKriticnaKolicina.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblKriticnaKolicina.Location = new System.Drawing.Point(190, 68);
            this.lblKriticnaKolicina.Name = "lblKriticnaKolicina";
            this.lblKriticnaKolicina.Size = new System.Drawing.Size(138, 22);
            this.lblKriticnaKolicina.TabIndex = 16;
            this.lblKriticnaKolicina.Text = "KriticnaKolicina";
            // 
            // lblDostupnaKolicina
            // 
            this.lblDostupnaKolicina.AutoSize = true;
            this.lblDostupnaKolicina.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblDostupnaKolicina.Location = new System.Drawing.Point(190, 36);
            this.lblDostupnaKolicina.Name = "lblDostupnaKolicina";
            this.lblDostupnaKolicina.Size = new System.Drawing.Size(157, 22);
            this.lblDostupnaKolicina.TabIndex = 15;
            this.lblDostupnaKolicina.Text = "DostupnaKolicina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kritična količina:";
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
            this.btnOdustani.Location = new System.Drawing.Point(206, 195);
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
            this.btnSpremi.Location = new System.Drawing.Point(17, 195);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Količina na skladištu:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblNaziv.Location = new System.Drawing.Point(5, 5);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(119, 22);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "NazivArtikla";
            // 
            // trenutnaFormaLbl
            // 
            this.trenutnaFormaLbl.AutoSize = true;
            this.trenutnaFormaLbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trenutnaFormaLbl.Location = new System.Drawing.Point(108, 113);
            this.trenutnaFormaLbl.Name = "trenutnaFormaLbl";
            this.trenutnaFormaLbl.Size = new System.Drawing.Size(127, 22);
            this.trenutnaFormaLbl.TabIndex = 3;
            this.trenutnaFormaLbl.Text = "Dodaj količinu";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtKolicina.Location = new System.Drawing.Point(112, 138);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(141, 29);
            this.txtKolicina.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblID.Location = new System.Drawing.Point(317, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 22);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // FrmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 742);
            this.Controls.Add(this.panelDodajKolicinu);
            this.Controls.Add(this.btnDodajKolicinu);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "FrmSkladiste";
            this.Text = "FrmSkladiste";
            this.Load += new System.EventHandler(this.FrmSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.panelDodajKolicinu.ResumeLayout(false);
            this.panelDodajKolicinu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private FontAwesome.Sharp.IconButton btnDodajKolicinu;
        private System.Windows.Forms.Panel panelDodajKolicinu;
        private System.Windows.Forms.Label lblKriticnaKolicina;
        private System.Windows.Forms.Label lblDostupnaKolicina;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnOdustani;
        private FontAwesome.Sharp.IconButton btnSpremi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label trenutnaFormaLbl;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblID;
    }
}