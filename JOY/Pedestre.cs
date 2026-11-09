using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Pedestre : Form
    {
        public Pedestre()
        {
            InitializeComponent();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Trajeto tela = new Trajeto();
            tela.Show();
            this.Hide();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Pedestre_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.openstreetmap.org/#map=13/-21.2089/-50.4328");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Trajeto tela = new Trajeto();
            tela.Show();
            this.Hide();
                 
        }
    }
}
