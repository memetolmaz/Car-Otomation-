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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araclar z = new Araclar();
            z.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler x = new Musteriler();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listeleme y = new Listeleme();
            y.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AracListe t = new AracListe();
            t.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Yellow;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.Yellow;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.Yellow;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            //this.button5.BackColor = System.Drawing.Color.Red;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            //this.button5.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
