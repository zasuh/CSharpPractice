namespace DataGridView1
{
    partial class Form1
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPriimek = new System.Windows.Forms.TextBox();
            this.datumIzpita = new System.Windows.Forms.DateTimePicker();
            this.ocenaIzpita = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.colIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriimek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatumIzpita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOcenaIzpita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(22, 33);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPriimek
            // 
            this.txtPriimek.Location = new System.Drawing.Point(22, 81);
            this.txtPriimek.Name = "txtPriimek";
            this.txtPriimek.Size = new System.Drawing.Size(100, 20);
            this.txtPriimek.TabIndex = 1;
            this.txtPriimek.TextChanged += new System.EventHandler(this.txtPriimek_TextChanged);
            // 
            // datumIzpita
            // 
            this.datumIzpita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumIzpita.Location = new System.Drawing.Point(22, 137);
            this.datumIzpita.Name = "datumIzpita";
            this.datumIzpita.Size = new System.Drawing.Size(200, 20);
            this.datumIzpita.TabIndex = 2;
            // 
            // ocenaIzpita
            // 
            this.ocenaIzpita.Items.Add("nms");
            this.ocenaIzpita.Items.Add("2");
            this.ocenaIzpita.Items.Add("3");
            this.ocenaIzpita.Items.Add("4");
            this.ocenaIzpita.Items.Add("5");
            this.ocenaIzpita.Location = new System.Drawing.Point(22, 205);
            this.ocenaIzpita.Name = "ocenaIzpita";
            this.ocenaIzpita.ReadOnly = true;
            this.ocenaIzpita.Size = new System.Drawing.Size(120, 20);
            this.ocenaIzpita.TabIndex = 3;
            this.ocenaIzpita.Text = "nms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Priimek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum Izpita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ocena";
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIme,
            this.colPriimek,
            this.colDatumIzpita,
            this.colOcenaIzpita});
            this.tabela.Location = new System.Drawing.Point(237, 33);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.Size = new System.Drawing.Size(410, 201);
            this.tabela.TabIndex = 8;
            // 
            // colIme
            // 
            this.colIme.HeaderText = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.ReadOnly = true;
            // 
            // colPriimek
            // 
            this.colPriimek.HeaderText = "Priimek";
            this.colPriimek.Name = "colPriimek";
            this.colPriimek.ReadOnly = true;
            // 
            // colDatumIzpita
            // 
            this.colDatumIzpita.HeaderText = "Datum Izpita";
            this.colDatumIzpita.Name = "colDatumIzpita";
            this.colDatumIzpita.ReadOnly = true;
            // 
            // colOcenaIzpita
            // 
            this.colOcenaIzpita.HeaderText = "Ocena";
            this.colOcenaIzpita.Name = "colOcenaIzpita";
            this.colOcenaIzpita.ReadOnly = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(22, 250);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(115, 250);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 10;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 299);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ocenaIzpita);
            this.Controls.Add(this.datumIzpita);
            this.Controls.Add(this.txtPriimek);
            this.Controls.Add(this.txtIme);
            this.MinimumSize = new System.Drawing.Size(675, 338);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPriimek;
        private System.Windows.Forms.DateTimePicker datumIzpita;
        private System.Windows.Forms.DomainUpDown ocenaIzpita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriimek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumIzpita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOcenaIzpita;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnBrisi;
    }
}

