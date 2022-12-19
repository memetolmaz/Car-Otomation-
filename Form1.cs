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
    public partial class Form1 : Form
    {
        SqlCommand komut = new SqlCommand();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut = new SqlCommand("select * from giris where kullanici_adi=@kadi and sifre=@sifre", baglanti);
            komut.Parameters.AddWithValue("@kadi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                AnaForm git = new AnaForm();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre HATALI !!");
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
            baglanti.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";

            }
            else if (checkBox1.CheckState == CheckState.Unchecked)

            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";

            }
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || (textBox2.Text.Trim() == ""))
            {

                MessageBox.Show("Giriş Başarısız! Tüm Alanları Doldurunuz", "HATA",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult kaydet = MessageBox.Show("Yönetici Kaydedilsin mi?", "Kaydetme Kontrolü", MessageBoxButtons.YesNo);
                if (kaydet == DialogResult.Yes)
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    komut = new SqlCommand("insert into giris (kullanici_adi, sifre) values (@k1, @k2)",baglanti);

                    komut.Parameters.AddWithValue("@k1",textBox1.Text);
                    komut.Parameters.AddWithValue("@k2",textBox2.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yönetici Kaydedilmiştir");
                    

                }
                else
                {
                    MessageBox.Show("Yönetici Kaydedilmiştir");

                }

            }
            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
    
   

