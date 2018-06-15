namespace ShowHideTextBox2
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
            this.besedilo = new System.Windows.Forms.TextBox();
            this.pokazi = new System.Windows.Forms.Button();
            this.skrij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // besedilo
            // 
            this.besedilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.besedilo.Location = new System.Drawing.Point(33, 12);
            this.besedilo.Multiline = true;
            this.besedilo.Name = "besedilo";
            this.besedilo.ReadOnly = true;
            this.besedilo.Size = new System.Drawing.Size(203, 105);
            this.besedilo.TabIndex = 0;
            this.besedilo.TabStop = false;
            this.besedilo.TextChanged += new System.EventHandler(this.besedilo_TextChanged);
            // 
            // pokazi
            // 
            this.pokazi.Location = new System.Drawing.Point(33, 144);
            this.pokazi.Name = "pokazi";
            this.pokazi.Size = new System.Drawing.Size(75, 23);
            this.pokazi.TabIndex = 1;
            this.pokazi.Text = "Pokaži";
            this.pokazi.UseVisualStyleBackColor = true;
            this.pokazi.Click += new System.EventHandler(this.pokazi_Click);
            // 
            // skrij
            // 
            this.skrij.Location = new System.Drawing.Point(161, 144);
            this.skrij.Name = "skrij";
            this.skrij.Size = new System.Drawing.Size(75, 23);
            this.skrij.TabIndex = 2;
            this.skrij.Text = "Skrij";
            this.skrij.UseVisualStyleBackColor = true;
            this.skrij.Click += new System.EventHandler(this.skrij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.skrij);
            this.Controls.Add(this.pokazi);
            this.Controls.Add(this.besedilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox besedilo;
        private System.Windows.Forms.Button pokazi;
        private System.Windows.Forms.Button skrij;
    }
}

