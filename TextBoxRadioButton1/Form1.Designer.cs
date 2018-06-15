namespace TextBoxRadioButton1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vnos1 = new System.Windows.Forms.TextBox();
            this.vnos2 = new System.Windows.Forms.TextBox();
            this.izPrvega = new System.Windows.Forms.RadioButton();
            this.izDrugega = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKopiraj = new System.Windows.Forms.Button();
            this.btnPobrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polje 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(194, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polje 2";
            // 
            // vnos1
            // 
            this.vnos1.Location = new System.Drawing.Point(12, 47);
            this.vnos1.Name = "vnos1";
            this.vnos1.Size = new System.Drawing.Size(100, 20);
            this.vnos1.TabIndex = 2;
            // 
            // vnos2
            // 
            this.vnos2.Location = new System.Drawing.Point(172, 47);
            this.vnos2.Name = "vnos2";
            this.vnos2.Size = new System.Drawing.Size(100, 20);
            this.vnos2.TabIndex = 3;
            // 
            // izPrvega
            // 
            this.izPrvega.AutoSize = true;
            this.izPrvega.Checked = true;
            this.izPrvega.Location = new System.Drawing.Point(15, 30);
            this.izPrvega.Name = "izPrvega";
            this.izPrvega.Size = new System.Drawing.Size(69, 17);
            this.izPrvega.TabIndex = 4;
            this.izPrvega.TabStop = true;
            this.izPrvega.Text = "Iz prvega";
            this.izPrvega.UseVisualStyleBackColor = true;
            // 
            // izDrugega
            // 
            this.izDrugega.AutoSize = true;
            this.izDrugega.Location = new System.Drawing.Point(15, 53);
            this.izDrugega.Name = "izDrugega";
            this.izDrugega.Size = new System.Drawing.Size(75, 17);
            this.izDrugega.TabIndex = 5;
            this.izDrugega.Text = "Iz drugega";
            this.izDrugega.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iz polja 1 v polje 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iz polja 2 v polje 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.izPrvega);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.izDrugega);
            this.groupBox1.Location = new System.Drawing.Point(32, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smer Kopiranja";
            // 
            // btnKopiraj
            // 
            this.btnKopiraj.Location = new System.Drawing.Point(12, 213);
            this.btnKopiraj.Name = "btnKopiraj";
            this.btnKopiraj.Size = new System.Drawing.Size(75, 23);
            this.btnKopiraj.TabIndex = 9;
            this.btnKopiraj.Text = "Kopiraj";
            this.btnKopiraj.UseVisualStyleBackColor = true;
            this.btnKopiraj.Click += new System.EventHandler(this.btnKopiraj_Click);
            // 
            // btnPobrisi
            // 
            this.btnPobrisi.Location = new System.Drawing.Point(197, 213);
            this.btnPobrisi.Name = "btnPobrisi";
            this.btnPobrisi.Size = new System.Drawing.Size(75, 23);
            this.btnPobrisi.TabIndex = 10;
            this.btnPobrisi.Text = "Pobriši";
            this.btnPobrisi.UseVisualStyleBackColor = true;
            this.btnPobrisi.Click += new System.EventHandler(this.btnPobrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPobrisi);
            this.Controls.Add(this.btnKopiraj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vnos2);
            this.Controls.Add(this.vnos1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vnos1;
        private System.Windows.Forms.TextBox vnos2;
        private System.Windows.Forms.RadioButton izPrvega;
        private System.Windows.Forms.RadioButton izDrugega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKopiraj;
        private System.Windows.Forms.Button btnPobrisi;
    }
}

