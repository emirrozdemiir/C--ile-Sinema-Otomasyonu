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
    public partial class seansekle : Form
    {
        public seansekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRR\SQLEXPRESS;Initial Catalog=sinemaOtomasyonu;Integrated Security=True");
        sinemaOtomasyonuDataSet1TableAdapters.SeansBilgileriTableAdapter flmseans = new sinemaOtomasyonuDataSet1TableAdapters.SeansBilgileriTableAdapter();
        
        private void menü_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //seans adında booş bir string değişken oluşturdum çünkü radiobuttondaki texti tutucak içinde veri tabanına bu sayede kolay bir ekleme yaptım
        string seans = "";
        private void radiobutonseçilimi()
        {
            if (radioButton1.Checked==true)
            {
                seans = radioButton1.Text;
            }
            else if (radioButton2.Checked==true)
            {
                seans = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                seans = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                seans = radioButton4.Text;
            }
            else if (radioButton5.Checked == true)
            {
                seans = radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                seans = radioButton6.Text;
            }
            else if (radioButton7.Checked == true)
            {
                seans = radioButton7.Text;
            }
            else if (radioButton8.Checked == true)
            {
                seans = radioButton8.Text;
            }
            else if (radioButton9.Checked == true)
            {
                seans = radioButton9.Text;
            }
            else if (radioButton10.Checked == true)
            {
                seans = radioButton10.Text;
            }
            else if (radioButton11.Checked == true)
            {
                seans = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                seans = radioButton12.Text;
            }
        }
        //veritabanındaki  film ve salonları comboboxlara taşıma fonksiyonu burda dataset kullandım daha kolay ve anlaşılır olucağını düşündüm
        private void flmslngoster(ComboBox combo,string sql, string sql1)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql1].ToString());
            }
            baglanti.Close();
        }

        private void temizle() {

            flmadicmbo.Text = "";
            slnadicmbo.Text = "";
            
        }


        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
        //yukarıda da yaptığım gibi dataset yardımıyla gerekli parametreleri vererek verileri çektim
        private void seansekle_Load(object sender, EventArgs e)
        {
            flmslngoster(flmadicmbo, "select*from FilmBilgileri", "FilmAdi");  
            flmslngoster(slnadicmbo, "select distinct SalonAdi from SalonBilgileri", "SalonAdi");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //burada dataset yardımıyla girilen filmm adı seans ve salon adını veritabanına güzelce kayıt ettim
                radiobutonseçilimi();
                flmseans.seansseklemee(flmadicmbo.Text, slnadicmbo.Text, seans);
                MessageBox.Show("Seans ekleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
        //satıra taşınan değeri veri tabanından sildim
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from SeansBilgileri where Saat=@p1 and FilmAdi=@p2",baglanti);
            sil.Parameters.AddWithValue("@p1", label4.Text);
            sil.Parameters.AddWithValue("@p2", label5.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //veri tabanındaki değerleri istediğimiz satıra taşıdım
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            label5.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
        //datagriddeki değerleri yenile butonuna basınca araçlara taşımayı tercih ettim
        private void button3_Click(object sender, EventArgs e)
        {
            this.seansBilgileriTableAdapter.SeansListesi(this.sinemaOtomasyonuDataSet1.SeansBilgileri);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void flmadicmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
