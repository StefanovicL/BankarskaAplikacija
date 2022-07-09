
namespace WindowsFormsApp2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbKlijenti = new System.Windows.Forms.GroupBox();
            this.gbObrada = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.lbPrikaz = new System.Windows.Forms.ListBox();
            this.tbStanjeVeceOd = new System.Windows.Forms.TextBox();
            this.tbRacuni = new System.Windows.Forms.TextBox();
            this.tbMaxNovca = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.gbRacun = new System.Windows.Forms.GroupBox();
            this.rbNamenski = new System.Windows.Forms.RadioButton();
            this.rbDevizni = new System.Windows.Forms.RadioButton();
            this.rbDinarski = new System.Windows.Forms.RadioButton();
            this.rbNenamenski = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.karticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaDataSet = new WindowsFormsApp2.BankaDataSet();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new WindowsFormsApp2.BankaDataSetTableAdapters.KlijentTableAdapter();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new WindowsFormsApp2.BankaDataSetTableAdapters.RacunTableAdapter();
            this.klijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbKlijenti.SuspendLayout();
            this.gbObrada.SuspendLayout();
            this.gbRacun.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klijentIDDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klijentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gbKlijenti
            // 
            this.gbKlijenti.Controls.Add(this.btnPretrazi);
            this.gbKlijenti.Controls.Add(this.tbStanjeVeceOd);
            this.gbKlijenti.Controls.Add(this.lbPrikaz);
            this.gbKlijenti.Controls.Add(this.cmbIme);
            this.gbKlijenti.Controls.Add(this.label5);
            this.gbKlijenti.Controls.Add(this.label4);
            this.gbKlijenti.Controls.Add(this.label1);
            this.gbKlijenti.Enabled = false;
            this.gbKlijenti.Location = new System.Drawing.Point(28, 300);
            this.gbKlijenti.Name = "gbKlijenti";
            this.gbKlijenti.Size = new System.Drawing.Size(755, 173);
            this.gbKlijenti.TabIndex = 1;
            this.gbKlijenti.TabStop = false;
            this.gbKlijenti.Text = "Klijenti";
            // 
            // gbObrada
            // 
            this.gbObrada.ContextMenuStrip = this.contextMenuStrip1;
            this.gbObrada.Controls.Add(this.gbRacun);
            this.gbObrada.Controls.Add(this.tbRacuni);
            this.gbObrada.Controls.Add(this.tbMaxNovca);
            this.gbObrada.Controls.Add(this.label3);
            this.gbObrada.Controls.Add(this.label2);
            this.gbObrada.Location = new System.Drawing.Point(28, 488);
            this.gbObrada.Name = "gbObrada";
            this.gbObrada.Size = new System.Drawing.Size(755, 151);
            this.gbObrada.TabIndex = 2;
            this.gbObrada.TabStop = false;
            this.gbObrada.Text = "Obrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj otvorenih racuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Racun sa najvise novcanih sredstava";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stanje na racunu vece od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prikaz podataka";
            // 
            // cmbIme
            // 
            this.cmbIme.DataSource = this.klijentBindingSource;
            this.cmbIme.DisplayMember = "ImePrezime";
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(17, 82);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(121, 24);
            this.cmbIme.TabIndex = 5;
            this.cmbIme.ValueMember = "KlijentID";
            this.cmbIme.SelectedIndexChanged += new System.EventHandler(this.cmbIme_SelectedIndexChanged);
            // 
            // lbPrikaz
            // 
            this.lbPrikaz.FormattingEnabled = true;
            this.lbPrikaz.ItemHeight = 16;
            this.lbPrikaz.Location = new System.Drawing.Point(172, 49);
            this.lbPrikaz.Name = "lbPrikaz";
            this.lbPrikaz.Size = new System.Drawing.Size(369, 116);
            this.lbPrikaz.TabIndex = 6;
            // 
            // tbStanjeVeceOd
            // 
            this.tbStanjeVeceOd.Location = new System.Drawing.Point(601, 82);
            this.tbStanjeVeceOd.Name = "tbStanjeVeceOd";
            this.tbStanjeVeceOd.Size = new System.Drawing.Size(100, 22);
            this.tbStanjeVeceOd.TabIndex = 7;
            // 
            // tbRacuni
            // 
            this.tbRacuni.Location = new System.Drawing.Point(519, 105);
            this.tbRacuni.Name = "tbRacuni";
            this.tbRacuni.Size = new System.Drawing.Size(116, 22);
            this.tbRacuni.TabIndex = 8;
            // 
            // tbMaxNovca
            // 
            this.tbMaxNovca.Location = new System.Drawing.Point(605, 49);
            this.tbMaxNovca.Name = "tbMaxNovca";
            this.tbMaxNovca.Size = new System.Drawing.Size(112, 22);
            this.tbMaxNovca.TabIndex = 9;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(613, 127);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 27);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // gbRacun
            // 
            this.gbRacun.Controls.Add(this.rbNenamenski);
            this.gbRacun.Controls.Add(this.rbDinarski);
            this.gbRacun.Controls.Add(this.rbDevizni);
            this.gbRacun.Controls.Add(this.rbNamenski);
            this.gbRacun.Enabled = false;
            this.gbRacun.Location = new System.Drawing.Point(47, 30);
            this.gbRacun.Name = "gbRacun";
            this.gbRacun.Size = new System.Drawing.Size(239, 100);
            this.gbRacun.TabIndex = 10;
            this.gbRacun.TabStop = false;
            this.gbRacun.Text = "Racun";
            // 
            // rbNamenski
            // 
            this.rbNamenski.AutoSize = true;
            this.rbNamenski.Location = new System.Drawing.Point(7, 33);
            this.rbNamenski.Name = "rbNamenski";
            this.rbNamenski.Size = new System.Drawing.Size(91, 21);
            this.rbNamenski.TabIndex = 0;
            this.rbNamenski.TabStop = true;
            this.rbNamenski.Text = "Namenski";
            this.rbNamenski.UseVisualStyleBackColor = true;
            this.rbNamenski.CheckedChanged += new System.EventHandler(this.rbNamenski_CheckedChanged);
            // 
            // rbDevizni
            // 
            this.rbDevizni.AutoSize = true;
            this.rbDevizni.Location = new System.Drawing.Point(123, 73);
            this.rbDevizni.Name = "rbDevizni";
            this.rbDevizni.Size = new System.Drawing.Size(75, 21);
            this.rbDevizni.TabIndex = 1;
            this.rbDevizni.TabStop = true;
            this.rbDevizni.Text = "Devizni";
            this.rbDevizni.UseVisualStyleBackColor = true;
            this.rbDevizni.CheckedChanged += new System.EventHandler(this.rbNamenski_CheckedChanged);
            // 
            // rbDinarski
            // 
            this.rbDinarski.AutoSize = true;
            this.rbDinarski.Location = new System.Drawing.Point(123, 33);
            this.rbDinarski.Name = "rbDinarski";
            this.rbDinarski.Size = new System.Drawing.Size(80, 21);
            this.rbDinarski.TabIndex = 2;
            this.rbDinarski.TabStop = true;
            this.rbDinarski.Text = "Dinarski";
            this.rbDinarski.UseVisualStyleBackColor = true;
            this.rbDinarski.CheckedChanged += new System.EventHandler(this.rbNamenski_CheckedChanged);
            // 
            // rbNenamenski
            // 
            this.rbNenamenski.AutoSize = true;
            this.rbNenamenski.Location = new System.Drawing.Point(7, 73);
            this.rbNenamenski.Name = "rbNenamenski";
            this.rbNenamenski.Size = new System.Drawing.Size(107, 21);
            this.rbNenamenski.TabIndex = 3;
            this.rbNenamenski.TabStop = true;
            this.rbNenamenski.Text = "Nenamenski";
            this.rbNenamenski.UseVisualStyleBackColor = true;
            this.rbNenamenski.CheckedChanged += new System.EventHandler(this.rbNamenski_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 28);
            // 
            // karticaToolStripMenuItem
            // 
            this.karticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem});
            this.karticaToolStripMenuItem.Name = "karticaToolStripMenuItem";
            this.karticaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.karticaToolStripMenuItem.Text = "Kartica";
            // 
            // bankaDataSet
            // 
            this.bankaDataSet.DataSetName = "BankaDataSet";
            this.bankaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.bankaDataSet;
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.bankaDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // klijentIDDataGridViewTextBoxColumn
            // 
            this.klijentIDDataGridViewTextBoxColumn.DataPropertyName = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.HeaderText = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.klijentIDDataGridViewTextBoxColumn.Name = "klijentIDDataGridViewTextBoxColumn";
            this.klijentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.DataSource = this.racunBindingSource;
            this.racunDataGridViewTextBoxColumn.DisplayMember = "Tip";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Racun";
            this.racunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.racunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.racunDataGridViewTextBoxColumn.ValueMember = "RacunID";
            this.racunDataGridViewTextBoxColumn.Width = 125;
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.obradaToolStripMenuItem.Text = "Obrada";
            this.obradaToolStripMenuItem.Click += new System.EventHandler(this.obradaToolStripMenuItem_Click);
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.klijentToolStripMenuItem.Text = "Klijent";
            this.klijentToolStripMenuItem.Click += new System.EventHandler(this.klijentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 651);
            this.Controls.Add(this.gbObrada);
            this.Controls.Add(this.gbKlijenti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbKlijenti.ResumeLayout(false);
            this.gbKlijenti.PerformLayout();
            this.gbObrada.ResumeLayout(false);
            this.gbObrada.PerformLayout();
            this.gbRacun.ResumeLayout(false);
            this.gbRacun.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbKlijenti;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox tbStanjeVeceOd;
        private System.Windows.Forms.ListBox lbPrikaz;
        private System.Windows.Forms.ComboBox cmbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbObrada;
        private System.Windows.Forms.GroupBox gbRacun;
        private System.Windows.Forms.RadioButton rbNenamenski;
        private System.Windows.Forms.RadioButton rbDinarski;
        private System.Windows.Forms.RadioButton rbDevizni;
        private System.Windows.Forms.RadioButton rbNamenski;
        private System.Windows.Forms.TextBox tbRacuni;
        private System.Windows.Forms.TextBox tbMaxNovca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karticaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BankaDataSet bankaDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private BankaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private BankaDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn racunDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
    }
}

