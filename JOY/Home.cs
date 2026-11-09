using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkApe.Checked)
            {

                Trajeto tela = new Trajeto();
                tela.Show();
                this.Hide();
            }
            if (chkCarro.Checked)
            {

                Carro tela = new Carro();
                tela.Show();
                this.Hide();
            }
            if (chkOnibus.Checked)
            {
                Onibus tela = new Onibus();
                tela.Show();
                this.Hide();
            }

        }

        private void chkCarro_CheckedChanged(object sender, EventArgs e)
        {
            chkApe.Checked = false;
            chkOnibus.Checked = false;
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.openstreetmap.org/#map=13/-21.2089/-50.4328");
        }

        private void chkApe_CheckedChanged(object sender, EventArgs e)
        {
            chkCarro.Checked = false;
            chkOnibus.Checked = false;
        }

        private void chkOnibus_CheckedChanged(object sender, EventArgs e)
        {
            chkCarro.Checked = false;
            chkApe.Checked = false;
        }
    }
}
