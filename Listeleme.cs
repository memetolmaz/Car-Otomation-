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
    public partial class Listeleme : Form
    {
        SqlConnection bln = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
        public Listeleme()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler zayn = new Musteriler();
            zayn.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriSilme git6 = new MusteriSilme();
            git6.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bln.State == ConnectionState.Closed)
                bln.Open();
             SqlDataAdapter da = new SqlDataAdapter("select  *  from customers",bln);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bln.Close();




        }
    }
}
