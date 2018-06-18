namespace VpogledneTabele2
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
            this.izposojaCDjevDataSet = new VpogledneTabele2.izposojaCDjevDataSet();
            this.cDjiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDjiTableAdapter = new VpogledneTabele2.izposojaCDjevDataSetTableAdapters.CDjiTableAdapter();
            this.tableAdapterManager = new VpogledneTabele2.izposojaCDjevDataSetTableAdapters.TableAdapterManager();
            this.cDjiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cDjiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cDjiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIJAKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIJAKITableAdapter = new VpogledneTabele2.izposojaCDjevDataSetTableAdapters.DIJAKITableAdapter();
            this.dIJAKIDataGridView = new System.Windows.Forms.DataGridView();
            this.iZPOSOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iZPOSOJATableAdapter = new VpogledneTabele2.izposojaCDjevDataSetTableAdapters.IZPOSOJATableAdapter();
            this.iZPOSOJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.izposojaCDjevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDjiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDjiBindingNavigator)).BeginInit();
            this.cDjiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDjiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // izposojaCDjevDataSet
            // 
            this.izposojaCDjevDataSet.DataSetName = "izposojaCDjevDataSet";
            this.izposojaCDjevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDjiBindingSource
            // 
            this.cDjiBindingSource.DataMember = "CDji";
            this.cDjiBindingSource.DataSource = this.izposojaCDjevDataSet;
            // 
            // cDjiTableAdapter
            // 
            this.cDjiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CDjiTableAdapter = this.cDjiTableAdapter;
            this.tableAdapterManager.DIJAKITableAdapter = this.dIJAKITableAdapter;
            this.tableAdapterManager.IZPOSOJATableAdapter = this.iZPOSOJATableAdapter;
            this.tableAdapterManager.UpdateOrder = VpogledneTabele2.izposojaCDjevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cDjiBindingNavigator
            // 
            this.cDjiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cDjiBindingNavigator.BindingSource = this.cDjiBindingSource;
            this.cDjiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cDjiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cDjiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cDjiBindingNavigatorSaveItem});
            this.cDjiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cDjiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cDjiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cDjiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cDjiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cDjiBindingNavigator.Name = "cDjiBindingNavigator";
            this.cDjiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cDjiBindingNavigator.Size = new System.Drawing.Size(1102, 25);
            this.cDjiBindingNavigator.TabIndex = 0;
            this.cDjiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cDjiBindingNavigatorSaveItem
            // 
            this.cDjiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cDjiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cDjiBindingNavigatorSaveItem.Image")));
            this.cDjiBindingNavigatorSaveItem.Name = "cDjiBindingNavigatorSaveItem";
            this.cDjiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cDjiBindingNavigatorSaveItem.Text = "Save Data";
            this.cDjiBindingNavigatorSaveItem.Click += new System.EventHandler(this.cDjiBindingNavigatorSaveItem_Click);
            // 
            // cDjiDataGridView
            // 
            this.cDjiDataGridView.AutoGenerateColumns = false;
            this.cDjiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDjiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.cDjiDataGridView.DataSource = this.cDjiBindingSource;
            this.cDjiDataGridView.Location = new System.Drawing.Point(76, 28);
            this.cDjiDataGridView.Name = "cDjiDataGridView";
            this.cDjiDataGridView.Size = new System.Drawing.Size(941, 220);
            this.cDjiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SIFRA";
            this.dataGridViewTextBoxColumn1.HeaderText = "SIFRA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NASLOV";
            this.dataGridViewTextBoxColumn2.HeaderText = "NASLOV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IZVAJALEC";
            this.dataGridViewTextBoxColumn3.HeaderText = "IZVAJALEC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ST_CDJEV";
            this.dataGridViewTextBoxColumn4.HeaderText = "ST_CDJEV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LETNICA";
            this.dataGridViewTextBoxColumn5.HeaderText = "LETNICA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ZALOZBA";
            this.dataGridViewTextBoxColumn6.HeaderText = "ZALOZBA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ZVRST";
            this.dataGridViewTextBoxColumn7.HeaderText = "ZVRST";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DATUM_PRIDOBITVE";
            this.dataGridViewTextBoxColumn8.HeaderText = "DATUM_PRIDOBITVE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "KOMENTAR";
            this.dataGridViewTextBoxColumn9.HeaderText = "KOMENTAR";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dIJAKIBindingSource
            // 
            this.dIJAKIBindingSource.DataMember = "DIJAKI";
            this.dIJAKIBindingSource.DataSource = this.izposojaCDjevDataSet;
            // 
            // dIJAKITableAdapter
            // 
            this.dIJAKITableAdapter.ClearBeforeFill = true;
            // 
            // dIJAKIDataGridView
            // 
            this.dIJAKIDataGridView.AutoGenerateColumns = false;
            this.dIJAKIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dIJAKIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dIJAKIDataGridView.DataSource = this.dIJAKIBindingSource;
            this.dIJAKIDataGridView.Location = new System.Drawing.Point(76, 275);
            this.dIJAKIDataGridView.Name = "dIJAKIDataGridView";
            this.dIJAKIDataGridView.Size = new System.Drawing.Size(942, 220);
            this.dIJAKIDataGridView.TabIndex = 2;
            // 
            // iZPOSOJABindingSource
            // 
            this.iZPOSOJABindingSource.DataMember = "IZPOSOJA";
            this.iZPOSOJABindingSource.DataSource = this.izposojaCDjevDataSet;
            // 
            // iZPOSOJATableAdapter
            // 
            this.iZPOSOJATableAdapter.ClearBeforeFill = true;
            // 
            // iZPOSOJADataGridView
            // 
            this.iZPOSOJADataGridView.AutoGenerateColumns = false;
            this.iZPOSOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iZPOSOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.iZPOSOJADataGridView.DataSource = this.iZPOSOJABindingSource;
            this.iZPOSOJADataGridView.Location = new System.Drawing.Point(76, 519);
            this.iZPOSOJADataGridView.Name = "iZPOSOJADataGridView";
            this.iZPOSOJADataGridView.Size = new System.Drawing.Size(544, 220);
            this.iZPOSOJADataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SIFRA";
            this.dataGridViewTextBoxColumn10.DataSource = this.dIJAKIBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "DIJAK";
            this.dataGridViewTextBoxColumn10.HeaderText = "DIJAK";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "SIFRA";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NASLOV";
            this.dataGridViewTextBoxColumn11.HeaderText = "NASLOV";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "POSTA";
            this.dataGridViewTextBoxColumn12.HeaderText = "POSTA";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "KRAJ";
            this.dataGridViewTextBoxColumn13.HeaderText = "KRAJ";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TELEFON";
            this.dataGridViewTextBoxColumn14.HeaderText = "TELEFON";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DATUM_R";
            this.dataGridViewTextBoxColumn15.HeaderText = "DATUM_R";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "SPOL";
            this.dataGridViewTextBoxColumn16.HeaderText = "SPOL";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "KOMENTAR";
            this.dataGridViewTextBoxColumn17.HeaderText = "KOMENTAR";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "DIJAK";
            this.dataGridViewTextBoxColumn18.HeaderText = "DIJAK";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "SIFRA_IZPOSOJE";
            this.dataGridViewTextBoxColumn19.HeaderText = "SIFRA_IZPOSOJE";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "SIFRA_DIJAKA";
            this.dataGridViewTextBoxColumn20.HeaderText = "SIFRA_DIJAKA";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SIFRA_CDJA";
            this.dataGridViewTextBoxColumn21.DataSource = this.cDjiBindingSource;
            this.dataGridViewTextBoxColumn21.DisplayMember = "NASLOV";
            this.dataGridViewTextBoxColumn21.HeaderText = "CD";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn21.ValueMember = "SIFRA";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "DATUM_IZPOSOJE";
            this.dataGridViewTextBoxColumn22.HeaderText = "DATUM_IZPOSOJE";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "DATUM_VRNITVE";
            this.dataGridViewTextBoxColumn23.HeaderText = "DATUM_VRNITVE";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 807);
            this.Controls.Add(this.iZPOSOJADataGridView);
            this.Controls.Add(this.dIJAKIDataGridView);
            this.Controls.Add(this.cDjiDataGridView);
            this.Controls.Add(this.cDjiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.izposojaCDjevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDjiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDjiBindingNavigator)).EndInit();
            this.cDjiBindingNavigator.ResumeLayout(false);
            this.cDjiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDjiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private izposojaCDjevDataSet izposojaCDjevDataSet;
        private System.Windows.Forms.BindingSource cDjiBindingSource;
        private izposojaCDjevDataSetTableAdapters.CDjiTableAdapter cDjiTableAdapter;
        private izposojaCDjevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cDjiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cDjiBindingNavigatorSaveItem;
        private izposojaCDjevDataSetTableAdapters.DIJAKITableAdapter dIJAKITableAdapter;
        private System.Windows.Forms.DataGridView cDjiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource dIJAKIBindingSource;
        private izposojaCDjevDataSetTableAdapters.IZPOSOJATableAdapter iZPOSOJATableAdapter;
        private System.Windows.Forms.DataGridView dIJAKIDataGridView;
        private System.Windows.Forms.BindingSource iZPOSOJABindingSource;
        private System.Windows.Forms.DataGridView iZPOSOJADataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}

