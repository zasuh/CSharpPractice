namespace MultiMenuForm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okno2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nemodalnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okno3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.okno2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.okno3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oprogramuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.oknoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izhodToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "&Datoteka";
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.izhodToolStripMenuItem.Text = "&Izhod";
            this.izhodToolStripMenuItem.Click += new System.EventHandler(this.izhodToolStripMenuItem_Click);
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelanoToolStripMenuItem,
            this.toolStripSeparator1,
            this.nemodalnoToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oknoToolStripMenuItem.Text = "&Okno";
            // 
            // modelanoToolStripMenuItem
            // 
            this.modelanoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno2ToolStripMenuItem});
            this.modelanoToolStripMenuItem.Name = "modelanoToolStripMenuItem";
            this.modelanoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.modelanoToolStripMenuItem.Text = "&Modelano";
            this.modelanoToolStripMenuItem.Click += new System.EventHandler(this.modelanoToolStripMenuItem_Click);
            // 
            // okno2ToolStripMenuItem
            // 
            this.okno2ToolStripMenuItem.Name = "okno2ToolStripMenuItem";
            this.okno2ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.okno2ToolStripMenuItem.Text = "Okno&2";
            this.okno2ToolStripMenuItem.Click += new System.EventHandler(this.okno2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // nemodalnoToolStripMenuItem
            // 
            this.nemodalnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno3ToolStripMenuItem});
            this.nemodalnoToolStripMenuItem.Name = "nemodalnoToolStripMenuItem";
            this.nemodalnoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.nemodalnoToolStripMenuItem.Text = "&Nemodalno";
            // 
            // okno3ToolStripMenuItem
            // 
            this.okno3ToolStripMenuItem.Name = "okno3ToolStripMenuItem";
            this.okno3ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.okno3ToolStripMenuItem.Text = "Okno&3";
            this.okno3ToolStripMenuItem.Click += new System.EventHandler(this.okno3ToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem.Text = "&O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno2ToolStripMenuItem1,
            this.okno3ToolStripMenuItem1,
            this.oprogramuToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // okno2ToolStripMenuItem1
            // 
            this.okno2ToolStripMenuItem1.Name = "okno2ToolStripMenuItem1";
            this.okno2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.okno2ToolStripMenuItem1.Text = "Okno&2";
            this.okno2ToolStripMenuItem1.Click += new System.EventHandler(this.okno2ToolStripMenuItem1_Click);
            // 
            // okno3ToolStripMenuItem1
            // 
            this.okno3ToolStripMenuItem1.Name = "okno3ToolStripMenuItem1";
            this.okno3ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.okno3ToolStripMenuItem1.Text = "Okno&3";
            this.okno3ToolStripMenuItem1.Click += new System.EventHandler(this.okno3ToolStripMenuItem1_Click);
            // 
            // oprogramuToolStripMenuItem1
            // 
            this.oprogramuToolStripMenuItem1.Name = "oprogramuToolStripMenuItem1";
            this.oprogramuToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.oprogramuToolStripMenuItem1.Text = "O &programu";
            this.oprogramuToolStripMenuItem1.Click += new System.EventHandler(this.oprogramuToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nemodalnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okno2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okno3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem okno2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem okno3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oprogramuToolStripMenuItem1;
    }
}

