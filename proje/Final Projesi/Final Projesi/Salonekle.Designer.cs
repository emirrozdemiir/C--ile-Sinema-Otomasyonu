
namespace Final_Projesi
{
    partial class Salonekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salonekle));
            this.saloneklebtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.anamenuuubtn = new System.Windows.Forms.Button();
            this.salonaditxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salonAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaOtomasyonuDataSet1 = new Final_Projesi.sinemaOtomasyonuDataSet1();
            this.salonBilgileriTableAdapter = new Final_Projesi.sinemaOtomasyonuDataSet1TableAdapters.SalonBilgileriTableAdapter();
            this.yenile = new System.Windows.Forms.Button();
            this.sill = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // saloneklebtn
            // 
            this.saloneklebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.saloneklebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saloneklebtn.ImageIndex = 1;
            this.saloneklebtn.ImageList = this.ımageList1;
            this.saloneklebtn.Location = new System.Drawing.Point(12, 323);
            this.saloneklebtn.Name = "saloneklebtn";
            this.saloneklebtn.Size = new System.Drawing.Size(150, 50);
            this.saloneklebtn.TabIndex = 0;
            this.saloneklebtn.Text = "      Salon Ekle";
            this.saloneklebtn.UseVisualStyleBackColor = false;
            this.saloneklebtn.Click += new System.EventHandler(this.saloneklebtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "default+home+house+main+menu+icon-1320086046804091155.ico");
            this.ımageList1.Images.SetKeyName(1, "indir (1).jpg");
            this.ımageList1.Images.SetKeyName(2, "indir (4).jpg");
            this.ımageList1.Images.SetKeyName(3, "istockphoto-691856020-170667a.jpg");
            this.ımageList1.Images.SetKeyName(4, "png-transparent-computer-icons-refresh-free-others-text-monochrome-root.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salon Adı: ";
            // 
            // anamenuuubtn
            // 
            this.anamenuuubtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.anamenuuubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anamenuuubtn.ImageIndex = 0;
            this.anamenuuubtn.ImageList = this.ımageList1;
            this.anamenuuubtn.Location = new System.Drawing.Point(504, 323);
            this.anamenuuubtn.Name = "anamenuuubtn";
            this.anamenuuubtn.Size = new System.Drawing.Size(150, 50);
            this.anamenuuubtn.TabIndex = 2;
            this.anamenuuubtn.Text = "    Ana Menü";
            this.anamenuuubtn.UseVisualStyleBackColor = false;
            this.anamenuuubtn.Click += new System.EventHandler(this.anamenuuubtn_Click);
            // 
            // salonaditxt
            // 
            this.salonaditxt.Location = new System.Drawing.Point(230, 70);
            this.salonaditxt.Multiline = true;
            this.salonaditxt.Name = "salonaditxt";
            this.salonaditxt.Size = new System.Drawing.Size(233, 32);
            this.salonaditxt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salonAdiDataGridViewTextBoxColumn,
            this.salonIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salonBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // salonAdiDataGridViewTextBoxColumn
            // 
            this.salonAdiDataGridViewTextBoxColumn.DataPropertyName = "SalonAdi";
            this.salonAdiDataGridViewTextBoxColumn.HeaderText = "SalonAdi";
            this.salonAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salonAdiDataGridViewTextBoxColumn.Name = "salonAdiDataGridViewTextBoxColumn";
            this.salonAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // salonIdDataGridViewTextBoxColumn
            // 
            this.salonIdDataGridViewTextBoxColumn.DataPropertyName = "SalonId";
            this.salonIdDataGridViewTextBoxColumn.HeaderText = "SalonId";
            this.salonIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salonIdDataGridViewTextBoxColumn.Name = "salonIdDataGridViewTextBoxColumn";
            this.salonIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.salonIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // salonBilgileriBindingSource
            // 
            this.salonBilgileriBindingSource.DataMember = "SalonBilgileri";
            this.salonBilgileriBindingSource.DataSource = this.sinemaOtomasyonuDataSet1;
            // 
            // sinemaOtomasyonuDataSet1
            // 
            this.sinemaOtomasyonuDataSet1.DataSetName = "sinemaOtomasyonuDataSet1";
            this.sinemaOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonBilgileriTableAdapter
            // 
            this.salonBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.yenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yenile.ImageIndex = 4;
            this.yenile.ImageList = this.ımageList1;
            this.yenile.Location = new System.Drawing.Point(337, 323);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(150, 50);
            this.yenile.TabIndex = 5;
            this.yenile.Text = "       Listeyi Yenile";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // sill
            // 
            this.sill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sill.ImageIndex = 3;
            this.sill.ImageList = this.ımageList1;
            this.sill.Location = new System.Drawing.Point(168, 323);
            this.sill.Name = "sill";
            this.sill.Size = new System.Drawing.Size(150, 50);
            this.sill.TabIndex = 6;
            this.sill.Text = "    Salon Sil";
            this.sill.UseVisualStyleBackColor = false;
            this.sill.Click += new System.EventHandler(this.sill_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.temizlebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temizlebtn.ImageIndex = 2;
            this.temizlebtn.ImageList = this.ımageList1;
            this.temizlebtn.Location = new System.Drawing.Point(491, 189);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(150, 50);
            this.temizlebtn.TabIndex = 7;
            this.temizlebtn.Text = "  Temizle";
            this.temizlebtn.UseVisualStyleBackColor = false;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // Salonekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Projesi.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.temizlebtn);
            this.Controls.Add(this.sill);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.salonaditxt);
            this.Controls.Add(this.anamenuuubtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saloneklebtn);
            this.Name = "Salonekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Ekleme Paneli";
            this.Load += new System.EventHandler(this.Salonekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saloneklebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anamenuuubtn;
        private System.Windows.Forms.TextBox salonaditxt;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource salonBilgileriBindingSource;
        private sinemaOtomasyonuDataSet1TableAdapters.SalonBilgileriTableAdapter salonBilgileriTableAdapter;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button sill;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonIdDataGridViewTextBoxColumn;
    }
}