namespace Program_za_ugostiteljstvo.Forme
{
    partial class FrmBlagajna
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lable2 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUkupnoProdanihArtikala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUkupnoRacuna = new System.Windows.Forms.TextBox();
            this.trenutnaFormaLbl = new System.Windows.Forms.Label();
            this.txtUkupnaZarada = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(12, 9);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(152, 24);
            this.lable2.TabIndex = 21;
            this.lable2.Text = "Stanje blagajne";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(160, 9);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(66, 24);
            this.lblDatum.TabIndex = 22;
            this.lblDatum.Text = "datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Artikli računa";
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
            this.dgvArtikli.Location = new System.Drawing.Point(12, 326);
            this.dgvArtikli.Name = "dgvArtikli";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikli.Size = new System.Drawing.Size(531, 149);
            this.dgvArtikli.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Računi";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRacuni.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRacuni.EnableHeadersVisualStyles = false;
            this.dgvRacuni.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 74);
            this.dgvRacuni.Name = "dgvRacuni";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRacuni.Size = new System.Drawing.Size(639, 198);
            this.dgvRacuni.TabIndex = 25;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.DgvRacuni_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.Location = new System.Drawing.Point(573, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ukupno prodanih artikala:";
            // 
            // txtUkupnoProdanihArtikala
            // 
            this.txtUkupnoProdanihArtikala.Enabled = false;
            this.txtUkupnoProdanihArtikala.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupnoProdanihArtikala.Location = new System.Drawing.Point(799, 326);
            this.txtUkupnoProdanihArtikala.Name = "txtUkupnoProdanihArtikala";
            this.txtUkupnoProdanihArtikala.Size = new System.Drawing.Size(136, 29);
            this.txtUkupnoProdanihArtikala.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(937, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "kn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(653, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ukupno računa:";
            // 
            // txtUkupnoRacuna
            // 
            this.txtUkupnoRacuna.Enabled = false;
            this.txtUkupnoRacuna.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupnoRacuna.Location = new System.Drawing.Point(799, 246);
            this.txtUkupnoRacuna.Name = "txtUkupnoRacuna";
            this.txtUkupnoRacuna.Size = new System.Drawing.Size(136, 29);
            this.txtUkupnoRacuna.TabIndex = 43;
            // 
            // trenutnaFormaLbl
            // 
            this.trenutnaFormaLbl.AutoSize = true;
            this.trenutnaFormaLbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.trenutnaFormaLbl.Location = new System.Drawing.Point(654, 293);
            this.trenutnaFormaLbl.Name = "trenutnaFormaLbl";
            this.trenutnaFormaLbl.Size = new System.Drawing.Size(139, 22);
            this.trenutnaFormaLbl.TabIndex = 42;
            this.trenutnaFormaLbl.Text = "Ukupna zarada:";
            // 
            // txtUkupnaZarada
            // 
            this.txtUkupnaZarada.Enabled = false;
            this.txtUkupnaZarada.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtUkupnaZarada.Location = new System.Drawing.Point(799, 286);
            this.txtUkupnaZarada.Name = "txtUkupnaZarada";
            this.txtUkupnaZarada.Size = new System.Drawing.Size(136, 29);
            this.txtUkupnaZarada.TabIndex = 41;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 481);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Vrijeme";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(944, 249);
            this.chart1.TabIndex = 51;
            this.chart1.Text = "chart1";
            // 
            // FrmBlagajna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 742);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUkupnoProdanihArtikala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUkupnoRacuna);
            this.Controls.Add(this.trenutnaFormaLbl);
            this.Controls.Add(this.txtUkupnaZarada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lable2);
            this.Name = "FrmBlagajna";
            this.Text = "FrmBlagajna";
            this.Load += new System.EventHandler(this.FrmBlagajna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUkupnoProdanihArtikala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupnoRacuna;
        private System.Windows.Forms.Label trenutnaFormaLbl;
        private System.Windows.Forms.TextBox txtUkupnaZarada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}