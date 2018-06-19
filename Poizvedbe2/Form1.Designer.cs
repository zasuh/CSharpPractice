namespace Poizvedbe2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQL2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.northwindDataSet = new Poizvedbe2.NorthwindDataSet();
            this.sQL1TableAdapter = new Poizvedbe2.NorthwindDataSetTableAdapters.SQL1TableAdapter();
            this.tableAdapterManager = new Poizvedbe2.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.sQL1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sQL1DataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL1BindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL1DataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQL1ToolStripMenuItem,
            this.sQL2ToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // sQL1ToolStripMenuItem
            // 
            this.sQL1ToolStripMenuItem.Name = "sQL1ToolStripMenuItem";
            this.sQL1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sQL1ToolStripMenuItem.Text = "SQL&1";
            // 
            // sQL2ToolStripMenuItem
            // 
            this.sQL2ToolStripMenuItem.Name = "sQL2ToolStripMenuItem";
            this.sQL2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sQL2ToolStripMenuItem.Text = "SQL&2";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQL1TableAdapter
            // 
            this.sQL1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Poizvedbe2.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sQL1BindingNavigator
            // 
            this.sQL1BindingNavigator.AddNewItem = null;
            this.sQL1BindingNavigator.CountItem = null;
            this.sQL1BindingNavigator.DeleteItem = null;
            this.sQL1BindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.sQL1BindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.sQL1BindingNavigator.MoveFirstItem = null;
            this.sQL1BindingNavigator.MoveLastItem = null;
            this.sQL1BindingNavigator.MoveNextItem = null;
            this.sQL1BindingNavigator.MovePreviousItem = null;
            this.sQL1BindingNavigator.Name = "sQL1BindingNavigator";
            this.sQL1BindingNavigator.PositionItem = null;
            this.sQL1BindingNavigator.Size = new System.Drawing.Size(111, 25);
            this.sQL1BindingNavigator.TabIndex = 1;
            this.sQL1BindingNavigator.Text = "bindingNavigator1";
            // 
            // sQL1DataGridView
            // 
            this.sQL1DataGridView.AllowUserToAddRows = false;
            this.sQL1DataGridView.AllowUserToDeleteRows = false;
            this.sQL1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sQL1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sQL1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sQL1DataGridView.Location = new System.Drawing.Point(0, 24);
            this.sQL1DataGridView.Name = "sQL1DataGridView";
            this.sQL1DataGridView.ReadOnly = true;
            this.sQL1DataGridView.Size = new System.Drawing.Size(468, 370);
            this.sQL1DataGridView.TabIndex = 2;
            this.sQL1DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sQL1DataGridView_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(51, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(267, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Country";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton1.Text = "Show";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "Show All";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 394);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sQL1DataGridView);
            this.Controls.Add(this.sQL1BindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL1BindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQL1DataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQL1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQL2ToolStripMenuItem;
        private NorthwindDataSet northwindDataSet;
        private NorthwindDataSetTableAdapters.SQL1TableAdapter sQL1TableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sQL1BindingNavigator;
        private System.Windows.Forms.DataGridView sQL1DataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

