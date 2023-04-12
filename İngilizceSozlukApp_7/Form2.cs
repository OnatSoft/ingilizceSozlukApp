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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ONATSOFT\ONATSOFT;Initial Catalog=EngSozlukDB;Integrated Security=True");

        int[] sayi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] sayi2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Random rast = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Tblsozluk (english,turkish) values (@p1,@p2)", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtEnglish.Text);
            cmd.Parameters.AddWithValue("@p2", txtTurkish.Text);

            if (txtEnglish.Text != "" && txtTurkish.Text != "" && txtCaptcha.Text != "")
            {
                if (txtCaptcha.Text == label3.Text)
                {
                    MessageBox.Show("Kelime başarıyla listeye kaydedildi.", "İşlem Başarılı");
                    txtEnglish.Clear();
                    txtTurkish.Clear();
                    txtCaptcha.Clear();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Sayıların toplamı yanlış girildi, lütfen doğru girdiğinizden emin olunuz.", "Güvenlik Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCaptcha.Clear();
                    txtCaptcha.Focus();
                }
 
            }
            else
            {
                MessageBox.Show("Yeni kelime kaydedilemedi. Lütfen ilgili alanları eksiksiz doldurunuz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnglish.Clear();
                txtTurkish.Clear();
                txtCaptcha.Clear();
            }

            baglanti.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            int karakter1;
            int sembol1 = rast.Next(0, sayi1.Length);
            karakter1 = (sayi1[sembol1]);

            int karakter2;
            int sembol2 = rast.Next(0, sayi2.Length);
            karakter2 = (sayi2[sembol2]);
            int toplam = karakter1 + karakter2;
            lblCaptcha.Text = karakter1 + " + " + karakter2 + " =";
            label3.Text = toplam.ToString();
        }
    }
}
