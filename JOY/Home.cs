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
                Pedestre tela = new Pedestre();
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

        }
    }
}
