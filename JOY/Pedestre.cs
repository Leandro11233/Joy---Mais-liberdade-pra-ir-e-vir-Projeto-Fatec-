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
            Mapa tela = new Mapa();
            tela.Show();
            this.Hide();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }
    }
}
