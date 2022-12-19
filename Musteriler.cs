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


namespace WindowsFormsApp1
{
    public partial class Musteriler : Form
    {
        SqlConnection baglanti1 = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
        //SqlCommand komut = new SqlCommand();

        public Musteriler()
        {
            InitializeComponent();
        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || (textBox2.Text.Trim() == "") || (textBox3.Text.Trim() == "") || (textBox4.Text.Trim() == "") || (textBox5.Text.Trim()) == "")
            {
                MessageBox.Show("Giriş Başarısız! Tüm Alanları Doldurunuz", "HATA",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kaydet = MessageBox.Show("Müşteri Kaydedilsin Mi ?", "Kaydetme Kontrolü", MessageBoxButtons.YesNo);
                if (kaydet == DialogResult.Yes)
                {
                    SqlCommand komut1 = new SqlCommand("insert into customers (musteri_adsoyad, musteri_tc, musteri_tel, musteri_mail, musteri_adres) values (@P1, @P2, @P3, @P4, @P5)",baglanti1);

                    komut1.Parameters.AddWithValue("@P1",textBox1.Text);
                    komut1.Parameters.AddWithValue("@P2",textBox2.Text);
                    komut1.Parameters.AddWithValue("@P3",textBox3.Text);
                    komut1.Parameters.AddWithValue("@P4",textBox4.Text);
                    komut1.Parameters.AddWithValue("@P5",textBox5.Text);
                    baglanti1.Open();
                    komut1.ExecuteNonQuery();
                    baglanti1.Close();
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";

                    MessageBox.Show("MÜŞTERİ KAYDEDİLMİŞTİR");


                }
                else
                {
                    MessageBox.Show("MÜŞTERİ KAYDEDİLMEMİŞTİR");

                }
            }

                    

            

           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaForm gigi = new AnaForm();
            gigi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listeleme git5 = new Listeleme();
            git5.Show();
            this.Hide();

        }
    }
}
