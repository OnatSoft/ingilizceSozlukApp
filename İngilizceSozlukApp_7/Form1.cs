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

namespace İngilizceSozlukApp_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ONATSOFT\ONATSOFT;Initial Catalog=EngSozlukDB;Integrated Security=True");
        Random random = new Random();
        int sure = 100;
        int skor = 0;

        /*
         * NOT: Geliştirme: Form yüklendiğinde statik olarak veritabanından id ile rastgele çağırılan kelimeler, veritabanında ki kelime listesinin uzunluğuna göre
         * aynı şekilde id ile rastgele kelimeler çağrılacak.
         */

        void kelimegetir()
        {
            int sayi;
            sayi = random.Next(1, 314);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tblsozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblCevap.Text = dr[1].ToString();
                TxtTurkce.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }

            timer1.Start();
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimegetir();
            BtnTekrar.Visible = false;
        }

        private void Txtİngilizce_TextChanged(object sender, EventArgs e)
        {
            if (Txtİngilizce.Text == LblCevap.Text)
            {
                skor++;
                LblSkor.Text = skor.ToString();
                kelimegetir();
                Txtİngilizce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Süre Bitti!\nYaptığınız skor: "+skor, "Süre Bitti", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Txtİngilizce.Enabled = false;
                TxtTurkce.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                BtnTekrar.Visible = true;
                LblSkor.Text = "0";
                skor = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtTurkce.Enabled = true;
            Txtİngilizce.Enabled = true;
            Txtİngilizce.Clear();
            sure = 100;
            kelimegetir();
            BtnTekrar.Visible = false;
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Txtİngilizce.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Txtİngilizce.Enabled = false;
        }
    }
}
