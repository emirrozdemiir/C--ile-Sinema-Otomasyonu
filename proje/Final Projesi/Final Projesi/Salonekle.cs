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
    public partial class Salonekle : Form
    {
        public Salonekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRR\SQLEXPRESS;Initial Catalog=sinemaOtomasyonu;Integrated Security=True");
       
        private void anamenuuubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salonekle_Load(object sender, EventArgs e)
        {
            
        }
        //datagriddeki verileri textboxa taşıdım silme işlemi kolay olsun diye
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            salonaditxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
        //salon adı textini girmeden salon ekleme olsaın diye bool kullandım boş veri eklenmesini istemedim
        bool durum;
        private void saloneklebtn_Click(object sender, EventArgs e)
        {
            if (durum==false)
            {
                if (salonaditxt.Text=="")
                {
                    MessageBox.Show("Salon adını boş bırakamazsınız!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(" insert into SalonBilgileri (SalonAdi) values (@p1)", baglanti);
                    komut.Parameters.AddWithValue("@p1", salonaditxt.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Salon Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void yenile_Click(object sender, EventArgs e)
        {
            this.salonBilgileriTableAdapter.Fill(this.sinemaOtomasyonuDataSet1.SalonBilgileri);
        }
        //salon silme işlemi uygıladım
        private void sill_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From SalonBilgileri where SalonAdi=@s1", baglanti);
            sil.Parameters.AddWithValue("@s1", salonaditxt.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //temizleme için class kullanmak istemedim çünkü tek bir yer var silinicek

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            salonaditxt.Text = "";
            salonaditxt.Focus();
        }
    }
}
