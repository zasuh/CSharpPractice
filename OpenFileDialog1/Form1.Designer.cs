namespace OpenFileDialog1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdpri = new System.Windows.Forms.Button();
            this.btnRaztegni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOdpri
            // 
            this.btnOdpri.Location = new System.Drawing.Point(340, 53);
            this.btnOdpri.Name = "btnOdpri";
            this.btnOdpri.Size = new System.Drawing.Size(75, 23);
            this.btnOdpri.TabIndex = 1;
            this.btnOdpri.Text = "&Odpri sliko";
            this.btnOdpri.UseVisualStyleBackColor = true;
            this.btnOdpri.Click += new System.EventHandler(this.btnOdpri_Click);
            // 
            // btnRaztegni
            // 
            this.btnRaztegni.Location = new System.Drawing.Point(340, 101);
            this.btnRaztegni.Name = "btnRaztegni";
            this.btnRaztegni.Size = new System.Drawing.Size(95, 23);
            this.btnRaztegni.TabIndex = 2;
            this.btnRaztegni.Text = "&Raztegni/Skrči";
            this.btnRaztegni.UseVisualStyleBackColor = true;
            this.btnRaztegni.Click += new System.EventHandler(this.btnRaztegni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pot do slike:";
            // 
            // txtPot
            // 
            this.txtPot.Location = new System.Drawing.Point(148, 266);
            this.txtPot.Name = "txtPot";
            this.txtPot.ReadOnly = true;
            this.txtPot.Size = new System.Drawing.Size(232, 20);
            this.txtPot.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Slika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 321);
            this.Controls.Add(this.txtPot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRaztegni);
            this.Controls.Add(this.btnOdpri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Slika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdpri;
        private System.Windows.Forms.Button btnRaztegni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

