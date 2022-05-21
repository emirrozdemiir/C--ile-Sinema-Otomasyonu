using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Projesi
{
    public partial class biletkes : Form
    {
        public biletkes()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRR\SQLEXPRESS;Initial Catalog=sinemaOtomasyonu;Integrated Security=True");
       
        int sayac = 0;
        //fiyat hesabı için değişkenleere değerlini atadım
        int mısır = 0, cola = 0, su = 0, cikolata=0, biskuvi = 0,fiyatm=0,fiyatc=0,fiyats=0,fiyatb=0,fiyatci=0;
        //paneli gizleme
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        //tek tek eklemek yerine dinamik diye adlandırılan buttonları kullandım
        private void koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button buton = new Button();
                    buton.Size = new Size(32, 32);
                    buton.BackColor = Color.Green;
                    buton.Location = new Point(j * 33 + 35, i * 35 + 35);
                    buton.Name = sayac.ToString();
                    buton.Text = sayac.ToString();
                    sayac++;
                    this.panel1.Controls.Add(buton);
                    buton.Click += buton_Click;
                }
            }
        }
        //afiş getirme metodu
        private void afisveucretgetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from FilmBilgileri where FilmAdi='" + adcombo.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["FilmAfisi"].ToString();
                fiyattxt.Text = read["FilmUcreti"].ToString();
            }
            baglanti.Close();
        }
        
        private void yeşiledöndür()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Green;
                }
            }
        }
        //veritabanındaki dolu koltukları gösterme
        private void sqldolukoltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Koltuklar where FilmAdi='"+adcombo.SelectedItem+"' and SalonAdi='"+saloncombo.SelectedItem+"' and Saat='"+seanscombo.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["KoltukNo"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }
        //doluları combodaya yazdırma
        private void comboboxdolular()
        {
            comboBox1.Items.Clear() ;
            
            
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        comboBox1.Items.Add(item.Text);
                    }
                }
            }
        }
        //tabloya koltuk kayıdı yapma fonksiyonu
        private void kayıt()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Koltuklar (KoltukNo,FilmAdi,SalonAdi,Saat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", koltuktxt.Text);
            komut.Parameters.AddWithValue("@p2", adcombo.Text);
            komut.Parameters.AddWithValue("@p3", saloncombo.Text);
            komut.Parameters.AddWithValue("@p4", seanscombo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void goster(ComboBox combo,string sql,string sql1)
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand(sql, baglanti);
            SqlDataReader read = getir.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql1].ToString());
            }
            baglanti.Close();
        }
        
        
        //comboboxlara veri tabanındaki değerleri distinct ile tekrarı önleyerek çektim
        private void biletkes_Load(object sender, EventArgs e)
        {
            
            koltuklar();
            goster(adcombo, "select distinct FilmAdi from filmBilgileri", "FilmAdi");
        }
        //butonların arkası yeşilse textboxa taşıma
        private void buton_Click(object sender,EventArgs e)
        {
            Button but = (Button)sender;
            if (but.BackColor==Color.Green)
            {
                koltuktxt.Text = but.Text;
            }
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        
        //temizleme metodu
        private void temizle()
        {
            adcombo.Text= "";
            seanscombo.Text = "";
            saloncombo.Text = "";
            fiyattxt.Text = "";
            koltuktxt.Text = "";
            pictureBox1.Image = null;
            label17.Text = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        //toplam fiyat hesaplama
        private void hesapla()
        {
            int biletfyt = Convert.ToInt32(fiyattxt.Text);
            int sonuc = fiyatm + fiyatc + fiyatb + fiyatci + fiyats + biletfyt;
            label17.Text = sonuc + " " + "TL";
        }    
        
        //seçilen filmin afişini getirme
        private void adcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            saloncombo.Items.Clear();
            yeşiledöndür();
            comboboxdolular();
            salongetir();
            afisveucretgetir();
        }
        private void temzile_Click(object sender, EventArgs e)
        {
            comboBox1.Text="";
            comboBox1.Items.Clear();
            yeşiledöndür();
            temizle();
        }   
        //öncelikle veri tabındaki dolu koltukları çağırdım sonrasında o koltuklaru combobaxa taşıdım sonrasında fiyat hesaplama classını çağırdım ve data 
        private void kesbtn_Click(object sender, EventArgs e)
        {
            sqldolukoltuklar();
            comboboxdolular();
            hesapla();
            if (koltuktxt.Text!="")
            {
            try
            {
                    kayıt();
                    
                    MessageBox.Show("Bilet kesildi.Ödenecek tutar:'"+label17.Text+"'","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
            catch (Exception)
            {
                    MessageBox.Show("hata");
            }
            }
            else
            {
            MessageBox.Show("koltuk seçimi yapmadınız", "Hata");
            }

            
            
        }
        //önce koltukları yeşile çevirdim çünkü eski seanstan kalan koltuklar kırmızı yanarsa karışırdı bu sebeten önce yeşile döndürdüm
        //sonrasında seçilen seansa ait veritabanındaki dolu koltukları gösterdim
        //son olarak o koltukları iptal işlemi olabilir diye combobaxa ekledim
        private void seanscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            yeşiledöndür();
            sqldolukoltuklar();
            comboboxdolular();
        }
        //parametrelere göre veritabanından değerleri silmek için class kullandım
        private void biletsil()
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From Koltuklar where KoltukNo=@p1 and FilmAdi=@p2 and SalonAdi=@p3 and Saat=@p4", baglanti);
            sil.Parameters.AddWithValue("@p1", comboBox1.Text);
            sil.Parameters.AddWithValue("@p2", adcombo.Text);
            sil.Parameters.AddWithValue("@p3", saloncombo.Text);
            sil.Parameters.AddWithValue("@p4", seanscombo.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        
        //seçilen film adına göre salon getirme
        private void salongetir()
        {
            saloncombo.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct SalonAdi from SeansBilgileri where FilmAdi='" + adcombo.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                saloncombo.Items.Add(read["SalonAdi"].ToString());
            }
            baglanti.Close();
        }
        //salon ismine göre seans getirme
        private void saloncombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            seanscombo.Items.Clear();
            seansgetir();
        }
        //Seansları direkt getirmedim hatalı bir gösterim olurdu seçilen filmin ve o filme ait salonlara göre seansları getirdim getirirkende distinct komutu kullandım tekrarı önlemek istedim
        private void seansgetir()
        {
            seanscombo.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct Saat from SeansBilgileri where FilmAdi='" + adcombo.SelectedItem + "'and SalonAdi='" + saloncombo.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                seanscombo.Items.Add(read["Saat"].ToString());
            }
            baglanti.Close();
        }
        //girilen parametrelere göre silme fonksiyonunu getirdim öncelikle
        private void iptalbtn_Click(object sender, EventArgs e)
        {
            biletsil();
            yeşiledöndür();
            sqldolukoltuklar();
            comboboxdolular();
            MessageBox.Show("Bilet iptal edildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        } 
        //miktar ve fiyat hesaplama
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //aşağı kısım tamamiyle abur cubur kısmı için 
        private void mısıreksi_Click(object sender, EventArgs e)
        {
            mısır--;
            fiyatm -= 6;
            textBox3.Text = mısır.ToString();
            textBox4.Text = fiyatm.ToString();
        }
        private void mısırartı_Click(object sender, EventArgs e)
        {
            
            mısır++;
            fiyatm += 6;
            textBox3.Text = mısır.ToString();
            textBox4.Text = fiyatm.ToString();
            
        }
        private void çikolataartı_Click(object sender, EventArgs e)
        {
            
            cikolata++;
            fiyatc += 2;
            textBox9.Text = cikolata.ToString();
            textBox10.Text = fiyatc.ToString();
        }
        private void çikolataeksi_Click(object sender, EventArgs e)
        {
            cikolata--;
            fiyatc -= 2;
            textBox9.Text = cikolata.ToString();
            textBox10.Text = fiyatc.ToString();
        }
        
        private void colaartı_Click(object sender, EventArgs e)
        {
            cola++;
            fiyatci += 4;
            textBox5.Text = cola.ToString();
            textBox6.Text = fiyatci.ToString();
        }
        private void colaeksi_Click(object sender, EventArgs e)
        {
            cola--;
            fiyatci -= 4;
            textBox5.Text = cola.ToString();
            textBox6.Text = fiyatci.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            su++;
            fiyats += 2;
            textBox7.Text = su.ToString();
            textBox8.Text = fiyats.ToString();
        }
        private void sueksi_Click(object sender, EventArgs e)
        {
            su--;
            fiyats -= 2;
            textBox7.Text = su.ToString();
            textBox8.Text = fiyats.ToString();
        }
        
        private void bisküviartı_Click(object sender, EventArgs e)
        {
            biskuvi++;
            fiyatb += 3;
            textBox11.Text = biskuvi.ToString();
            textBox12.Text = fiyatb.ToString();
        }
        private void bisküvieksi_Click(object sender, EventArgs e)
        {
            biskuvi--;
            fiyatb -= 3;
            textBox11.Text = biskuvi.ToString();
            textBox12.Text = fiyatb.ToString();
        }
    }
}
