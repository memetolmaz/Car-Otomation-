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
    public partial class Araclar : Form
    {
        SqlConnection baglanti1 = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
        public Araclar()
        {
            InitializeComponent();
        }
        

        private void Araclar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoKiralamaDataSet1.aracbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.aracbilgileriTableAdapter1.Fill(this.otoKiralamaDataSet1.aracbilgileri);
            // TODO: Bu kod satırı 'otoKiralamaDataSet.aracbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.aracbilgileriTableAdapter.Fill(this.otoKiralamaDataSet.aracbilgileri);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim() == "" || (textBox2.Text.Trim() == "") || (textBox3.Text.Trim() == "") || (textBox4.Text.Trim() == "") || (textBox5.Text.Trim()) == "") 
            {
                MessageBox.Show("Giriş Başarısız! Tüm Alanları Doldurunuz", "HATA",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kaydet = MessageBox.Show("Araç Kaydedilsin Mi ?", "Kaydetme Kontrolü", MessageBoxButtons.YesNo);
                if (kaydet == DialogResult.Yes)
                {
                    SqlCommand komut1 = new SqlCommand("insert into Arac (Müsteri_tc, Arac_plaka, Arac_marka, Arac_model, Gunluk, Kasa_tipi, Durum) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7)", baglanti1);

                    komut1.Parameters.AddWithValue("@P1", textBox7.Text);
                    komut1.Parameters.AddWithValue("@P2", textBox1.Text);
                    komut1.Parameters.AddWithValue("@P3", textBox2.Text);
                    komut1.Parameters.AddWithValue("@P4", textBox4.Text);
                    komut1.Parameters.AddWithValue("@P5", textBox6.Text);
                    komut1.Parameters.AddWithValue("@P6", textBox5.Text);
                    komut1.Parameters.AddWithValue("@P7", textBox3.Text);
                    baglanti1.Open();
                    komut1.ExecuteNonQuery();
                    baglanti1.Close();
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";

                    MessageBox.Show("ARAÇ KAYDEDİLMİŞTİR");


                }
                else
                {
                    MessageBox.Show("ARAÇ KAYDEDİLMEMİŞTİR");

                }
            }








        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaForm gigi = new AnaForm();
            gigi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracListe oba = new AracListe();
            oba.Show();
            this.Hide();
        }
    }
    }

