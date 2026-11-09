using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trajeto tela = new Trajeto();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.openstreetmap.org/#map=13/-21.2089/-50.4328");
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
