namespace deneme1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbIller = new System.Windows.Forms.ComboBox();
            this.illerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new deneme1.HastaneDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odevDataSet = new deneme1.odevDataSet();
            this.biletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletlerTableAdapter = new deneme1.odevDataSetTableAdapters.BiletlerTableAdapter();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerTableAdapter = new deneme1.odevDataSetTableAdapters.SehirlerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHastaneler = new System.Windows.Forms.ComboBox();
            this.hastaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerTableAdapter = new deneme1.HastaneDataSetTableAdapters.illerTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.poliklinikTableAdapter = new deneme1.HastaneDataSetTableAdapters.PoliklinikTableAdapter();
            this.hastaneTableAdapter = new deneme1.HastaneDataSetTableAdapters.hastaneTableAdapter();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaTableAdapter = new deneme1.HastaneDataSetTableAdapters.HastaTableAdapter();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaneDataSet1 = new deneme1.HastaneDataSet();
            this.randevuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.randevuTableAdapter = new deneme1.HastaneDataSetTableAdapters.RandevuTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Randevu Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbIller
            // 
            this.cmbIller.DataSource = this.illerBindingSource1;
            this.cmbIller.DisplayMember = "sehiradi";
            this.cmbIller.FormattingEnabled = true;
            this.cmbIller.Location = new System.Drawing.Point(27, 38);
            this.cmbIller.Name = "cmbIller";
            this.cmbIller.Size = new System.Drawing.Size(121, 24);
            this.cmbIller.TabIndex = 2;
            this.cmbIller.ValueMember = "id";
            this.cmbIller.SelectedIndexChanged += new System.EventHandler(this.cmbIller_SelectedIndexChanged_1);
            // 
            // illerBindingSource1
            // 
            this.illerBindingSource1.DataMember = "iller";
            this.illerBindingSource1.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.sehirDataGridViewTextBoxColumn,
            this.hastaneDataGridViewTextBoxColumn,
            this.poliklinikDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevuBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(250, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 212);
            this.dataGridView1.TabIndex = 3;
            // 
            // randevuBindingSource1
            // 
            this.randevuBindingSource1.DataMember = "Randevu";
            this.randevuBindingSource1.DataSource = this.hastaneDataSet;
            // 
            // randevuBindingSource
            // 
            this.randevuBindingSource.DataMember = "Randevu";
            this.randevuBindingSource.DataSource = this.hastaneDataSet;
            // 
            // poliklinikBindingSource
            // 
            this.poliklinikBindingSource.DataMember = "Poliklinik";
            this.poliklinikBindingSource.DataSource = this.hastaneDataSet;
            // 
            // odevDataSet
            // 
            this.odevDataSet.DataSetName = "odevDataSet";
            this.odevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletlerBindingSource
            // 
            this.biletlerBindingSource.DataMember = "Biletler";
            this.biletlerBindingSource.DataSource = this.odevDataSet;
            // 
            // biletlerTableAdapter
            // 
            this.biletlerTableAdapter.ClearBeforeFill = true;
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.odevDataSet;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hastane";
            // 
            // cmbHastaneler
            // 
            this.cmbHastaneler.DataSource = this.hastaneBindingSource;
            this.cmbHastaneler.DisplayMember = "kurumadı";
            this.cmbHastaneler.FormattingEnabled = true;
            this.cmbHastaneler.Location = new System.Drawing.Point(27, 101);
            this.cmbHastaneler.Name = "cmbHastaneler";
            this.cmbHastaneler.Size = new System.Drawing.Size(217, 24);
            this.cmbHastaneler.TabIndex = 4;
            this.cmbHastaneler.ValueMember = "sehirid";
            this.cmbHastaneler.SelectedIndexChanged += new System.EventHandler(this.cmbHastaneler_SelectedIndexChanged);
            // 
            // hastaneBindingSource
            // 
            this.hastaneBindingSource.DataMember = "hastane";
            this.hastaneBindingSource.DataSource = this.hastaneDataSet;
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "iller";
            this.illerBindingSource.DataSource = this.hastaneDataSet;
            // 
            // illerTableAdapter
            // 
            this.illerTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Poliklinik";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DataSource = this.poliklinikBindingSource;
            this.cmbPoliklinik.DisplayMember = "PoliklinikAdı";
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(27, 157);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(121, 24);
            this.cmbPoliklinik.TabIndex = 6;
            this.cmbPoliklinik.ValueMember = "Poliklinikid";
            // 
            // poliklinikTableAdapter
            // 
            this.poliklinikTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneTableAdapter
            // 
            this.hastaneTableAdapter.ClearBeforeFill = true;
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(27, 218);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 8;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta TC";
            // 
            // hastaneDataSet1
            // 
            this.hastaneDataSet1.DataSetName = "HastaneDataSet";
            this.hastaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuBindingSource2
            // 
            this.randevuBindingSource2.DataMember = "Randevu";
            this.randevuBindingSource2.DataSource = this.hastaneDataSet1;
            // 
            // randevuTableAdapter
            // 
            this.randevuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HastaTC";
            this.dataGridViewTextBoxColumn1.HeaderText = "HastaTC";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaneDataGridViewTextBoxColumn
            // 
            this.hastaneDataGridViewTextBoxColumn.DataPropertyName = "Hastane";
            this.hastaneDataGridViewTextBoxColumn.HeaderText = "Hastane";
            this.hastaneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaneDataGridViewTextBoxColumn.Name = "hastaneDataGridViewTextBoxColumn";
            this.hastaneDataGridViewTextBoxColumn.Width = 125;
            // 
            // poliklinikDataGridViewTextBoxColumn
            // 
            this.poliklinikDataGridViewTextBoxColumn.DataPropertyName = "Poliklinik";
            this.poliklinikDataGridViewTextBoxColumn.HeaderText = "Poliklinik";
            this.poliklinikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poliklinikDataGridViewTextBoxColumn.Name = "poliklinikDataGridViewTextBoxColumn";
            this.poliklinikDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHastaneler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbIller);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "E-Nabız";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbIller;
        private System.Windows.Forms.DataGridView dataGridView1;
        private odevDataSet odevDataSet;
        private System.Windows.Forms.BindingSource biletlerBindingSource;
        private odevDataSetTableAdapters.BiletlerTableAdapter biletlerTableAdapter;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private odevDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHastaneler;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private HastaneDataSetTableAdapters.illerTableAdapter illerTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.BindingSource poliklinikBindingSource;
        private HastaneDataSetTableAdapters.PoliklinikTableAdapter poliklinikTableAdapter;
        private System.Windows.Forms.BindingSource hastaneBindingSource;
        private HastaneDataSetTableAdapters.hastaneTableAdapter hastaneTableAdapter;
        private System.Windows.Forms.BindingSource illerBindingSource1;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private HastaneDataSetTableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource randevuBindingSource;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource randevuBindingSource1;
        private HastaneDataSet hastaneDataSet1;
        private System.Windows.Forms.BindingSource randevuBindingSource2;
        private HastaneDataSetTableAdapters.RandevuTableAdapter randevuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}

