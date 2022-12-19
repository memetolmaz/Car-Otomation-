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
    public partial class Silme2 : Form
    {
        SqlConnection baglan2 = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
        public Silme2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracListe geri = new AracListe();
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
                DialogResult sil = MessageBox.Show("ARAÇ SİLİNSİN Mİ", "SİLME KONTROLÜ", MessageBoxButtons.YesNo);
                if (sil == DialogResult.Yes)
                {
                    if (baglan2.State == ConnectionState.Closed)
                        baglan2.Open();
                    SqlCommand komut2 = new SqlCommand("Delete From Arac where Müsteri_tc=@P1", baglan2);
                    komut2.Parameters.AddWithValue("@P1", textBox1.Text);
                    komut2.ExecuteNonQuery();
                    baglan2.Close();
                    textBox1.Text = " ";

                    MessageBox.Show("ARAÇ BAŞARIYLA  SİLİNMİŞTİR");



                }
                else
                {
                    MessageBox.Show("Araç Silinemedi");

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AracListe oba = new AracListe();
            oba.Show();
            this.Hide();
        }
    }
}
