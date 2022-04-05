namespace Program_za_ugostiteljstvo.Forme
{
    partial class FrmIzvjesca
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiRacun = new FontAwesome.Sharp.IconButton();
            this.btnGrupiraj = new FontAwesome.Sharp.IconButton();
            this.cboGrupiraj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUkupnoRacuna = new System.Windows.Forms.TextBox();
            this.trenutnaFormaLbl = new System.Windows.Forms.Label();
            this.txtUkupnaZarada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUkupanPorez = new System.Windows.Forms.TextBox();
            this.txtUkupnoProdanihArtikala = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Računi";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRacuni.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacuni.EnableHeadersVisualStyles = false;
            this.dgvRacuni.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvRacuni.Location = new System.Drawing.Point(1, 51);
            this.dgvRacuni.Name = "dgvRacuni";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRacuni.Size = new System.Drawing.Size(639, 210);
            this.dgvRacuni.TabIndex = 21;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.DgvRacuni_SelectionChanged);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvArtikli.Location = new System.Drawing.Point(1, 291);
            this.dgvArtikli.Name = "dgvArtikli";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArtikli.Size = new System.Drawing.Size(531, 353);
            this.dgvArtikli.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Artikli računa";
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnObrisiRacun.FlatAppearance.BorderSize = 0;
            this.btnObrisiRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiRacun.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnObrisiRacun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRacun.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnObrisiRacun.IconColor = System.Drawing.Color.Black;
            this.btnObrisiRacun.IconSize = 40;
            this.btnObrisiRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiRacun.Location = new System.Drawing.Point(660, 51);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnObrisiRacun.Rotation = 0D;
            this.btnObrisiRacun.Size = new System.Drawing.Size(215, 55);
            this.btnObrisiRacun.TabIndex = 25;
            this.btnObrisiRacun.Text = "Obriši račun";
            this.btnObrisiRacun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiRacun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiRacun.UseVisualStyleBackColor = false;
            this.btnObrisiRacun.Click += new System.EventHandler(this.BtnObrisiRacun_Click);
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
            this.btnGrupiraj.Location = new System.Drawing.Point(288, 9);
            this.btnGrupiraj.Name = "btnGrupiraj";
            this.btnGrupiraj.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGrupiraj.Rotation = 0D;
            this.btnGrupiraj.Size = new System.Drawing.Size(141, 36);
            this.btnGrupiraj.TabIndex = 27;
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
            this.cboGrupiraj.Location = new System.Drawing.Point(97, 12);
            this.cboGrupiraj.Name = "cboGrupiraj";
            this.cboGrupiraj.Size = new System.Drawing.Size(185, 30);
            this.cboGrupiraj.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(646, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ukupno računa:";
            // 
            // txtUkupnoRacuna
            // 
            this.txtUkupnoRacuna.Enabled = false;
            this.txtUkupnoRacuna.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupnoRacuna.Location = new System.Drawing.Point(792, 140);
            this.txtUkupnoRacuna.Name = "txtUkupnoRacuna";
            this.txtUkupnoRacuna.Size = new System.Drawing.Size(136, 29);
            this.txtUkupnoRacuna.TabIndex = 33;
            // 
            // trenutnaFormaLbl
            // 
            this.trenutnaFormaLbl.AutoSize = true;
            this.trenutnaFormaLbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trenutnaFormaLbl.Location = new System.Drawing.Point(647, 187);
            this.trenutnaFormaLbl.Name = "trenutnaFormaLbl";
            this.trenutnaFormaLbl.Size = new System.Drawing.Size(139, 22);
            this.trenutnaFormaLbl.TabIndex = 29;
            this.trenutnaFormaLbl.Text = "Ukupna zarada:";
            // 
            // txtUkupnaZarada
            // 
            this.txtUkupnaZarada.Enabled = false;
            this.txtUkupnaZarada.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupnaZarada.Location = new System.Drawing.Point(792, 180);
            this.txtUkupnaZarada.Name = "txtUkupnaZarada";
            this.txtUkupnaZarada.Size = new System.Drawing.Size(136, 29);
            this.txtUkupnaZarada.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(930, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "kn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(930, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "kn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.Location = new System.Drawing.Point(647, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ukupan porez:";
            // 
            // txtUkupanPorez
            // 
            this.txtUkupanPorez.Enabled = false;
            this.txtUkupanPorez.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupanPorez.Location = new System.Drawing.Point(792, 220);
            this.txtUkupanPorez.Name = "txtUkupanPorez";
            this.txtUkupanPorez.Size = new System.Drawing.Size(136, 29);
            this.txtUkupanPorez.TabIndex = 36;
            // 
            // txtUkupnoProdanihArtikala
            // 
            this.txtUkupnoProdanihArtikala.Enabled = false;
            this.txtUkupnoProdanihArtikala.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupnoProdanihArtikala.Location = new System.Drawing.Point(792, 260);
            this.txtUkupnoProdanihArtikala.Name = "txtUkupnoProdanihArtikala";
            this.txtUkupnoProdanihArtikala.Size = new System.Drawing.Size(136, 29);
            this.txtUkupnoProdanihArtikala.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.Location = new System.Drawing.Point(558, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ukupno prodanih artikala:";
            // 
            // FrmIzvjesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 742);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUkupnoProdanihArtikala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUkupanPorez);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUkupnoRacuna);
            this.Controls.Add(this.trenutnaFormaLbl);
            this.Controls.Add(this.txtUkupnaZarada);
            this.Controls.Add(this.btnGrupiraj);
            this.Controls.Add(this.cboGrupiraj);
            this.Controls.Add(this.btnObrisiRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "FrmIzvjesca";
            this.Text = "FrmIzvjesca";
            this.Load += new System.EventHandler(this.FrmIzvjesca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnObrisiRacun;
        private FontAwesome.Sharp.IconButton btnGrupiraj;
        private System.Windows.Forms.ComboBox cboGrupiraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupnoRacuna;
        private System.Windows.Forms.Label trenutnaFormaLbl;
        private System.Windows.Forms.TextBox txtUkupnaZarada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUkupanPorez;
        private System.Windows.Forms.TextBox txtUkupnoProdanihArtikala;
        private System.Windows.Forms.Label label7;
    }
}