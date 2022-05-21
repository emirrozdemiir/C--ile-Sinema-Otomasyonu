using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filmekle_Click(object sender, EventArgs e)
        {
            FilmEkle filmekle = new FilmEkle();
            filmekle.ShowDialog();
            
        }

        private void biletkes_Click(object sender, EventArgs e)
        {
            biletkes biletkes = new biletkes();
            biletkes.ShowDialog();
        }

        private void seansekle_Click(object sender, EventArgs e)
        {
            seansekle seansekle = new seansekle();
            seansekle.ShowDialog();
        }

        private void saloneklebtn_Click(object sender, EventArgs e)
        {
            Salonekle salonekle = new Salonekle();
            salonekle.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

