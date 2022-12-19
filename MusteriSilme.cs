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
    public partial class MusteriSilme : Form
    {
        SqlConnection baglan2 = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
        public MusteriSilme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme geri = new Listeleme();
            geri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("SİLİNECEK KİŞİNİN TC'SİNİ GİRMEDİNİZ", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                DialogResult sil = MessageBox.Show("Müşteri SİLİNSİN Mİ", "SİLME KONTROLÜ", MessageBoxButtons.YesNo);
                if (sil == DialogResult.Yes)
                {
                    if (baglan2.State == ConnectionState.Closed)
                        baglan2.Open();
                    SqlCommand komut2 = new SqlCommand("Delete From customers where musteri_tc=@P1",baglan2);
                    komut2.Parameters.AddWithValue("@P1",textBox1.Text);
                    komut2.ExecuteNonQuery();
                    baglan2.Close();
                    textBox1.Text = " ";

                    MessageBox.Show("MÜŞTERİ BAŞARIYLA  SİLİNMİŞTİR");


                    
                }
                else
                {
                    MessageBox.Show("Müşteri Silinemedi");

                }
            }
        }
    }
}
