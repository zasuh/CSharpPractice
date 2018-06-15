namespace ProgressBarTimer2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNalozi = new System.Windows.Forms.Button();
            this.btnUstavi = new System.Windows.Forms.Button();
            this.btnNadaljuj = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnNalozi
            // 
            this.btnNalozi.Location = new System.Drawing.Point(21, 130);
            this.btnNalozi.Name = "btnNalozi";
            this.btnNalozi.Size = new System.Drawing.Size(75, 23);
            this.btnNalozi.TabIndex = 1;
            this.btnNalozi.Text = "Naloži";
            this.btnNalozi.UseVisualStyleBackColor = true;
            this.btnNalozi.Click += new System.EventHandler(this.btnNalozi_Click);
            // 
            // btnUstavi
            // 
            this.btnUstavi.Location = new System.Drawing.Point(102, 130);
            this.btnUstavi.Name = "btnUstavi";
            this.btnUstavi.Size = new System.Drawing.Size(75, 23);
            this.btnUstavi.TabIndex = 2;
            this.btnUstavi.Text = "Ustavi";
            this.btnUstavi.UseVisualStyleBackColor = true;
            this.btnUstavi.Click += new System.EventHandler(this.btnUstavi_Click);
            // 
            // btnNadaljuj
            // 
            this.btnNadaljuj.Location = new System.Drawing.Point(183, 130);
            this.btnNadaljuj.Name = "btnNadaljuj";
            this.btnNadaljuj.Size = new System.Drawing.Size(75, 23);
            this.btnNadaljuj.TabIndex = 3;
            this.btnNadaljuj.Text = "Nadaljuj";
            this.btnNadaljuj.UseVisualStyleBackColor = true;
            this.btnNadaljuj.Click += new System.EventHandler(this.btnNadaljuj_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 207);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnNadaljuj);
            this.Controls.Add(this.btnUstavi);
            this.Controls.Add(this.btnNalozi);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNalozi;
        private System.Windows.Forms.Button btnUstavi;
        private System.Windows.Forms.Button btnNadaljuj;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

