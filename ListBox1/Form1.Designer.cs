namespace ListBox1
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
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.listSeznam = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnPobrisiVse = new System.Windows.Forms.Button();
            this.btnPobrisiIzbran = new System.Windows.Forms.Button();
            this.btnKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVnos
            // 
            this.txtVnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVnos.Location = new System.Drawing.Point(12, 12);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(100, 29);
            this.txtVnos.TabIndex = 0;
            // 
            // listSeznam
            // 
            this.listSeznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listSeznam.FormattingEnabled = true;
            this.listSeznam.ItemHeight = 24;
            this.listSeznam.Location = new System.Drawing.Point(12, 54);
            this.listSeznam.Name = "listSeznam";
            this.listSeznam.ScrollAlwaysVisible = true;
            this.listSeznam.Size = new System.Drawing.Size(120, 196);
            this.listSeznam.Sorted = true;
            this.listSeznam.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(159, 54);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(159, 93);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 3;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnPobrisiVse
            // 
            this.btnPobrisiVse.Location = new System.Drawing.Point(159, 137);
            this.btnPobrisiVse.Name = "btnPobrisiVse";
            this.btnPobrisiVse.Size = new System.Drawing.Size(75, 23);
            this.btnPobrisiVse.TabIndex = 4;
            this.btnPobrisiVse.Text = "Pobrisi Vse";
            this.btnPobrisiVse.UseVisualStyleBackColor = true;
            this.btnPobrisiVse.Click += new System.EventHandler(this.btnPobrisiVse_Click);
            // 
            // btnPobrisiIzbran
            // 
            this.btnPobrisiIzbran.Location = new System.Drawing.Point(159, 177);
            this.btnPobrisiIzbran.Name = "btnPobrisiIzbran";
            this.btnPobrisiIzbran.Size = new System.Drawing.Size(91, 23);
            this.btnPobrisiIzbran.TabIndex = 5;
            this.btnPobrisiIzbran.Text = "Pobriši Izbran";
            this.btnPobrisiIzbran.UseVisualStyleBackColor = true;
            this.btnPobrisiIzbran.Click += new System.EventHandler(this.btnPobrisiIzbran_Click);
            // 
            // btnKonec
            // 
            this.btnKonec.Location = new System.Drawing.Point(159, 215);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(75, 23);
            this.btnKonec.TabIndex = 6;
            this.btnKonec.Text = "Konec";
            this.btnKonec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.btnPobrisiIzbran);
            this.Controls.Add(this.btnPobrisiVse);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listSeznam);
            this.Controls.Add(this.txtVnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.ListBox listSeznam;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnPobrisiVse;
        private System.Windows.Forms.Button btnPobrisiIzbran;
        private System.Windows.Forms.Button btnKonec;
    }
}

