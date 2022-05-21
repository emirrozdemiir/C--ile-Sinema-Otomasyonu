
namespace Final_Projesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filmekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.seansekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.biletkes = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.saloneklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmekle
            // 
            this.filmekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.filmekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmekle.ImageIndex = 2;
            this.filmekle.ImageList = this.ımageList1;
            this.filmekle.Location = new System.Drawing.Point(39, 537);
            this.filmekle.Name = "filmekle";
            this.filmekle.Size = new System.Drawing.Size(150, 50);
            this.filmekle.TabIndex = 0;
            this.filmekle.Text = "       Film Ekle,Sil";
            this.filmekle.UseVisualStyleBackColor = false;
            this.filmekle.Click += new System.EventHandler(this.filmekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (3).jpg");
            this.ımageList1.Images.SetKeyName(1, "png-clipart-movie-logo-movie-logo-film-tape.png");
            this.ımageList1.Images.SetKeyName(2, "indir (1).jpg");
            this.ımageList1.Images.SetKeyName(3, "kisspng-push-button-scalable-vector-graphics-clip-art-red-power-button-symbol-ico" +
        "n-5ab09bf671c236.007803001521523702466.jpg");
            this.ımageList1.Images.SetKeyName(4, "sinema_16_9_1592306784_16_9_1611809828-670x371.jpg");
            this.ımageList1.Images.SetKeyName(5, "indir (10).jpg");
            // 
            // seansekle
            // 
            this.seansekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.seansekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seansekle.ImageIndex = 1;
            this.seansekle.ImageList = this.ımageList1;
            this.seansekle.Location = new System.Drawing.Point(281, 537);
            this.seansekle.Name = "seansekle";
            this.seansekle.Size = new System.Drawing.Size(150, 50);
            this.seansekle.TabIndex = 1;
            this.seansekle.Text = "         Seans Ekle,Sil";
            this.seansekle.UseVisualStyleBackColor = false;
            this.seansekle.Click += new System.EventHandler(this.seansekle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(827, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // biletkes
            // 
            this.biletkes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.biletkes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.biletkes.ImageIndex = 0;
            this.biletkes.ImageList = this.ımageList2;
            this.biletkes.Location = new System.Drawing.Point(259, 427);
            this.biletkes.Name = "biletkes";
            this.biletkes.Size = new System.Drawing.Size(484, 62);
            this.biletkes.TabIndex = 3;
            this.biletkes.Text = "Bilet Kes";
            this.biletkes.UseVisualStyleBackColor = false;
            this.biletkes.Click += new System.EventHandler(this.biletkes_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "indir (3).jpg");
            // 
            // saloneklebtn
            // 
            this.saloneklebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.saloneklebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saloneklebtn.ImageIndex = 5;
            this.saloneklebtn.ImageList = this.ımageList1;
            this.saloneklebtn.Location = new System.Drawing.Point(575, 537);
            this.saloneklebtn.Name = "saloneklebtn";
            this.saloneklebtn.Size = new System.Drawing.Size(150, 50);
            this.saloneklebtn.TabIndex = 4;
            this.saloneklebtn.Text = "       Salon Ekle,Sil";
            this.saloneklebtn.UseVisualStyleBackColor = false;
            this.saloneklebtn.Click += new System.EventHandler(this.saloneklebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Projesi.Properties.Resources.sinema_16_9_1592306784_16_9_1611809828_670x371;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 627);
            this.Controls.Add(this.saloneklebtn);
            this.Controls.Add(this.biletkes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seansekle);
            this.Controls.Add(this.filmekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filmekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button seansekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button biletkes;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button saloneklebtn;
    }
}

