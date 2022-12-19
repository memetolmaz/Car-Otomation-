using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        string a = "% ";

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            if ( sayac == 100)
            {
                timer1.Stop();
                Form1 b = new Form1();
                b.Show();
                this.Hide();


            }
            else
            {

            }
            progressBar1.Value = sayac;


            label3.Text = Convert.ToString(a           +      progressBar1.Value);
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
