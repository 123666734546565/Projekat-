namespace WindowsFormsApp41
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
            this.poreziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVlasnik = new System.Windows.Forms.ComboBox();
            this.tbPovrsinaVeca = new System.Windows.Forms.TextBox();
            this.btnNadji = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tbBrojObjekta = new System.Windows.Forms.TextBox();
            this.tbMaxPovrsina = new System.Windows.Forms.TextBox();
            this.nepokretnostDataSet = new WindowsFormsApp41.NepokretnostDataSet();
            this.objekatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objekatTableAdapter = new WindowsFormsApp41.NepokretnostDataSetTableAdapters.ObjekatTableAdapter();
            this.namenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namenaTableAdapter = new WindowsFormsApp41.NepokretnostDataSetTableAdapters.NamenaTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDObjekatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nepokretnostDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namenaBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poreziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // poreziToolStripMenuItem
            // 
            this.poreziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racuniToolStripMenuItem});
            this.poreziToolStripMenuItem.Name = "poreziToolStripMenuItem";
            this.poreziToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.poreziToolStripMenuItem.Text = "Porezi";
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.racuniToolStripMenuItem.Text = "Racuni";
            this.racuniToolStripMenuItem.Click += new System.EventHandler(this.racuniToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDObjekatDataGridViewTextBoxColumn,
            this.vlasnikDataGridViewTextBoxColumn,
            this.povrsinaDataGridViewTextBoxColumn,
            this.namenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.objekatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 123);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnNadji);
            this.groupBox1.Controls.Add(this.tbPovrsinaVeca);
            this.groupBox1.Controls.Add(this.cbVlasnik);
            this.groupBox1.Location = new System.Drawing.Point(70, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbVlasnik
            // 
            this.cbVlasnik.FormattingEnabled = true;
            this.cbVlasnik.Location = new System.Drawing.Point(23, 20);
            this.cbVlasnik.Name = "cbVlasnik";
            this.cbVlasnik.Size = new System.Drawing.Size(121, 21);
            this.cbVlasnik.TabIndex = 0;
            this.cbVlasnik.SelectedIndexChanged += new System.EventHandler(this.cbVlasnik_SelectedIndexChanged);
            // 
            // tbPovrsinaVeca
            // 
            this.tbPovrsinaVeca.Location = new System.Drawing.Point(7, 58);
            this.tbPovrsinaVeca.Name = "tbPovrsinaVeca";
            this.tbPovrsinaVeca.Size = new System.Drawing.Size(100, 20);
            this.tbPovrsinaVeca.TabIndex = 1;
            // 
            // btnNadji
            // 
            this.btnNadji.Location = new System.Drawing.Point(125, 55);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(75, 23);
            this.btnNadji.TabIndex = 2;
            this.btnNadji.Text = "Nadji";
            this.btnNadji.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox2.Controls.Add(this.tbMaxPovrsina);
            this.groupBox2.Controls.Add(this.tbBrojObjekta);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(453, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(18, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Stanovanje";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PomocniObjekat";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Garaza";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbBrojObjekta
            // 
            this.tbBrojObjekta.Location = new System.Drawing.Point(156, 20);
            this.tbBrojObjekta.Name = "tbBrojObjekta";
            this.tbBrojObjekta.Size = new System.Drawing.Size(100, 20);
            this.tbBrojObjekta.TabIndex = 1;
            // 
            // tbMaxPovrsina
            // 
            this.tbMaxPovrsina.Location = new System.Drawing.Point(156, 48);
            this.tbMaxPovrsina.Name = "tbMaxPovrsina";
            this.tbMaxPovrsina.Size = new System.Drawing.Size(100, 20);
            this.tbMaxPovrsina.TabIndex = 2;
            // 
            // nepokretnostDataSet
            // 
            this.nepokretnostDataSet.DataSetName = "NepokretnostDataSet";
            this.nepokretnostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objekatBindingSource
            // 
            this.objekatBindingSource.DataMember = "Objekat";
            this.objekatBindingSource.DataSource = this.nepokretnostDataSet;
            // 
            // objekatTableAdapter
            // 
            this.objekatTableAdapter.ClearBeforeFill = true;
            // 
            // namenaBindingSource
            // 
            this.namenaBindingSource.DataMember = "Namena";
            this.namenaBindingSource.DataSource = this.nepokretnostDataSet;
            // 
            // namenaTableAdapter
            // 
            this.namenaTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistikaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // iDObjekatDataGridViewTextBoxColumn
            // 
            this.iDObjekatDataGridViewTextBoxColumn.DataPropertyName = "IDObjekat";
            this.iDObjekatDataGridViewTextBoxColumn.HeaderText = "IDObjekat";
            this.iDObjekatDataGridViewTextBoxColumn.Name = "iDObjekatDataGridViewTextBoxColumn";
            // 
            // vlasnikDataGridViewTextBoxColumn
            // 
            this.vlasnikDataGridViewTextBoxColumn.DataPropertyName = "Vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.HeaderText = "Vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.Name = "vlasnikDataGridViewTextBoxColumn";
            // 
            // povrsinaDataGridViewTextBoxColumn
            // 
            this.povrsinaDataGridViewTextBoxColumn.DataPropertyName = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn.HeaderText = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn.Name = "povrsinaDataGridViewTextBoxColumn";
            // 
            // namenaDataGridViewTextBoxColumn
            // 
            this.namenaDataGridViewTextBoxColumn.DataPropertyName = "Namena";
            this.namenaDataGridViewTextBoxColumn.DataSource = this.namenaBindingSource;
            this.namenaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.namenaDataGridViewTextBoxColumn.HeaderText = "Namena";
            this.namenaDataGridViewTextBoxColumn.Name = "namenaDataGridViewTextBoxColumn";
            this.namenaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.namenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.namenaDataGridViewTextBoxColumn.ValueMember = "IDNamena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nepokretnostDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namenaBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem poreziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox tbPovrsinaVeca;
        private System.Windows.Forms.ComboBox cbVlasnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMaxPovrsina;
        private System.Windows.Forms.TextBox tbBrojObjekta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private NepokretnostDataSet nepokretnostDataSet;
        private System.Windows.Forms.BindingSource objekatBindingSource;
        private NepokretnostDataSetTableAdapters.ObjekatTableAdapter objekatTableAdapter;
        private System.Windows.Forms.BindingSource namenaBindingSource;
        private NepokretnostDataSetTableAdapters.NamenaTableAdapter namenaTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjekatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn namenaDataGridViewTextBoxColumn;
    }
}

