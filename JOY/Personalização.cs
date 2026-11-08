using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Personalização : Form
    {
        public Personalização()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Localização tela = new Localização();
            tela.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Condição tela = new Condição();
            tela.Show();
            this.Hide();
        }

        private void chkEvitarEscadas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOutrasPreferências_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAcessoFacilVeiculo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTrajCurto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
