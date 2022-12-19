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
    public partial class AracListe : Form
    {
        SqlConnection bln = new SqlConnection(@"Data Source=DESKTOP-ORRRBQR\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
        public AracListe()
        {
            InitializeComponent();
        }

        private void Kasa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bln.State == ConnectionState.Closed)
                bln.Open();
            SqlDataAdapter da = new SqlDataAdapter("select  *  from Arac", bln);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bln.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Araclar zayn = new Araclar();
            zayn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Silme2 akp = new Silme2();
            akp.Show();
            this.Hide();
        }
    }
}
