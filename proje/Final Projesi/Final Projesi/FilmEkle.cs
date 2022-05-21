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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRR\SQLEXPRESS;Initial Catalog=sinemaOtomasyonu;Integrated Security=True");
        //tekrarı önlemek için
        bool durum;
        void tekrar()
        {
            baglanti.Open();
            SqlCommand tekrarr = new SqlCommand("select * from FilmBilgileri where FilmAdi=@p1", baglanti);
            tekrarr.Parameters.AddWithValue("@p1", filmaditxt.Text);
            SqlDataReader dr = tekrarr.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }
        //temizleme metodu
        void temizleme()
        {
            filmaditxt.Text = "";
            filmtürücmb.Text = "";
            yönetmentxt.Text = "";
            süremskd.Text = "";
            ücrettxt.Text = "";
            pictureBox1.Image = null;
        }
        //boş alan yoksa kayıt yaptım
        private void filmeklemebtn_Click(object sender, EventArgs e)
        {
            tekrar();
            if (durum == true)
            {
                if (filmaditxt.Text == "" || filmtürücmb.Text == "" || yönetmentxt.Text == "" || süremskd.Text == "" || ücrettxt.Text == "" || afiş.Text == "")
                {
                    MessageBox.Show("Boş alan bırakamazsınız!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into FilmBilgileri (FilmAdi,FilmTuru,Yonetmen,FilmSuresi,FilmUcreti,FilmAfisi) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                    ekle.Parameters.AddWithValue("@p1", filmaditxt.Text);
                    ekle.Parameters.AddWithValue("@p2", filmtürücmb.Text);
                    ekle.Parameters.AddWithValue("@p3", yönetmentxt.Text);
                    ekle.Parameters.AddWithValue("@p4", süremskd.Text);
                    ekle.Parameters.AddWithValue("@p5", ücrettxt.Text);
                    ekle.Parameters.AddWithValue("@p6", afiş.Text);

                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Film Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilmEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet2.FilmBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }
        //verilerin panel açılınca gelmesini istemedim bu yüzden yenile butonuna basınca veriler gelicek
        private void yenilebtn_Click(object sender, EventArgs e)
        {
            this.filmBilgileriTableAdapter.Fill(this.sinemaOtomasyonuDataSet2.FilmBilgileri);
        }

        private void anamenübtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //datagridlerdeki değerleri araçlara taşıdım
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            filmaditxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            filmtürücmb.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yönetmentxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            süremskd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ücrettxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
        private void temizlebtn_Click(object sender, EventArgs e)
        {
            temizleme();
        }
        //delete komutu kullanarak verileri sildim
        private void filmsilbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From FilmBilgileri where FilmId=@s1", baglanti);
            sil.Parameters.AddWithValue("@s1", label7.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //afiş eklemek için öncelikle filedialog ekledim sonrasında açılan resimin dosya uzantısını afiş.text dosyasına yazdırdım
        private void afişeklebtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            afiş.Text = openFileDialog1.FileName;
        }
        private void idlbl_Click(object sender, EventArgs e)
        {

        }
        private void sinemaOtomasyonuDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


    }
}
