
namespace KorisnickiInterfejs
{
    partial class frmDodajEmisiju
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pickerVremeZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.pickerVremePocetka = new System.Windows.Forms.DateTimePicker();
            this.cmbVoditelj = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVrstaAngazovanja = new System.Windows.Forms.ComboBox();
            this.cmbRadnik = new System.Windows.Forms.ComboBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            this.btnDodajAngazovanje = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickerVremeZavrsetka);
            this.groupBox1.Controls.Add(this.pickerVremePocetka);
            this.groupBox1.Controls.Add(this.cmbVoditelj);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(305, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emisija";
            // 
            // pickerVremeZavrsetka
            // 
            this.pickerVremeZavrsetka.Location = new System.Drawing.Point(140, 92);
            this.pickerVremeZavrsetka.Name = "pickerVremeZavrsetka";
            this.pickerVremeZavrsetka.Size = new System.Drawing.Size(200, 20);
            this.pickerVremeZavrsetka.TabIndex = 10;
            // 
            // pickerVremePocetka
            // 
            this.pickerVremePocetka.Location = new System.Drawing.Point(140, 64);
            this.pickerVremePocetka.Name = "pickerVremePocetka";
            this.pickerVremePocetka.Size = new System.Drawing.Size(200, 20);
            this.pickerVremePocetka.TabIndex = 9;
            // 
            // cmbVoditelj
            // 
            this.cmbVoditelj.FormattingEnabled = true;
            this.cmbVoditelj.Location = new System.Drawing.Point(140, 129);
            this.cmbVoditelj.Name = "cmbVoditelj";
            this.cmbVoditelj.Size = new System.Drawing.Size(100, 21);
            this.cmbVoditelj.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(140, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Voditelj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vreme Zavrsetka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vreme Pocetka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajAngazovanje);
            this.groupBox2.Controls.Add(this.cmbVrstaAngazovanja);
            this.groupBox2.Controls.Add(this.cmbRadnik);
            this.groupBox2.Controls.Add(this.txtTrajanje);
            this.groupBox2.Controls.Add(this.txtOpis);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(67, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 200);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angazovanje";
            // 
            // cmbVrstaAngazovanja
            // 
            this.cmbVrstaAngazovanja.FormattingEnabled = true;
            this.cmbVrstaAngazovanja.Location = new System.Drawing.Point(140, 26);
            this.cmbVrstaAngazovanja.Name = "cmbVrstaAngazovanja";
            this.cmbVrstaAngazovanja.Size = new System.Drawing.Size(100, 21);
            this.cmbVrstaAngazovanja.TabIndex = 9;
            // 
            // cmbRadnik
            // 
            this.cmbRadnik.FormattingEnabled = true;
            this.cmbRadnik.Location = new System.Drawing.Point(140, 129);
            this.cmbRadnik.Name = "cmbRadnik";
            this.cmbRadnik.Size = new System.Drawing.Size(100, 21);
            this.cmbRadnik.TabIndex = 8;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(140, 92);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtTrajanje.TabIndex = 7;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(140, 61);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 20);
            this.txtOpis.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Radnik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Trajanje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "OpisPosla";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vrsta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(434, 468);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj Emisiju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.AllowUserToAddRows = false;
            this.dgvAngazovanja.AllowUserToDeleteRows = false;
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Location = new System.Drawing.Point(375, 219);
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.ReadOnly = true;
            this.dgvAngazovanja.Size = new System.Drawing.Size(492, 200);
            this.dgvAngazovanja.TabIndex = 11;
            // 
            // btnDodajAngazovanje
            // 
            this.btnDodajAngazovanje.Location = new System.Drawing.Point(78, 171);
            this.btnDodajAngazovanje.Name = "btnDodajAngazovanje";
            this.btnDodajAngazovanje.Size = new System.Drawing.Size(113, 23);
            this.btnDodajAngazovanje.TabIndex = 12;
            this.btnDodajAngazovanje.Text = "Dodaj Angazovanje";
            this.btnDodajAngazovanje.UseVisualStyleBackColor = true;
            this.btnDodajAngazovanje.Click += new System.EventHandler(this.btnDodajAngazovanje_Click);
            // 
            // frmDodajEmisiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 513);
            this.Controls.Add(this.dgvAngazovanja);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodajEmisiju";
            this.Text = "Dodaj Emisiju";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbVoditelj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVrstaAngazovanja;
        private System.Windows.Forms.ComboBox cmbRadnik;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker pickerVremeZavrsetka;
        private System.Windows.Forms.DateTimePicker pickerVremePocetka;
        private System.Windows.Forms.Button btnDodajAngazovanje;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
    }
}