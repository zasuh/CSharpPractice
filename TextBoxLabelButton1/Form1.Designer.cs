﻿namespace TextBoxLabelButton1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPovrni = new System.Windows.Forms.Button();
            this.btnPobrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesi besedilo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 66);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Lep pozdrav";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // btnPovrni
            // 
            this.btnPovrni.Location = new System.Drawing.Point(17, 159);
            this.btnPovrni.Name = "btnPovrni";
            this.btnPovrni.Size = new System.Drawing.Size(75, 23);
            this.btnPovrni.TabIndex = 2;
            this.btnPovrni.Text = "Povrni";
            this.btnPovrni.UseVisualStyleBackColor = true;
            this.btnPovrni.Click += new System.EventHandler(this.btnPovrni_Click);
            // 
            // btnPobrisi
            // 
            this.btnPobrisi.Location = new System.Drawing.Point(197, 159);
            this.btnPobrisi.Name = "btnPobrisi";
            this.btnPobrisi.Size = new System.Drawing.Size(75, 23);
            this.btnPobrisi.TabIndex = 3;
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
            this.Controls.Add(this.btnPovrni);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPovrni;
        private System.Windows.Forms.Button btnPobrisi;
    }
}

