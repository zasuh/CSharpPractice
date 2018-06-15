namespace LabelButton1
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
            this.spremeni = new System.Windows.Forms.Button();
            this.povrni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Originalen Napis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // spremeni
            // 
            this.spremeni.Location = new System.Drawing.Point(33, 91);
            this.spremeni.Name = "spremeni";
            this.spremeni.Size = new System.Drawing.Size(75, 23);
            this.spremeni.TabIndex = 1;
            this.spremeni.Text = "Spremeni";
            this.spremeni.UseVisualStyleBackColor = true;
            this.spremeni.Click += new System.EventHandler(this.spremeni_Click);
            // 
            // povrni
            // 
            this.povrni.Location = new System.Drawing.Point(168, 91);
            this.povrni.Name = "povrni";
            this.povrni.Size = new System.Drawing.Size(75, 23);
            this.povrni.TabIndex = 2;
            this.povrni.Text = "Povrni";
            this.povrni.UseVisualStyleBackColor = true;
            this.povrni.Click += new System.EventHandler(this.povrni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.povrni);
            this.Controls.Add(this.spremeni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spremeni;
        private System.Windows.Forms.Button povrni;
    }
}

