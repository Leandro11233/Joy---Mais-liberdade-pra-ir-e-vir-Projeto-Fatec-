using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Localização : Form
    {
        public Localização()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Personalização tela = new Personalização();
            tela.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Contato tela = new Contato();
            tela.Show();
            this.Hide();
        }

        private void chkSim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSim.Checked)
            {
                chkNão.Checked = false;
            }
        }

        private void chkNão_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNão.Checked)
            {
                chkSim.Checked = false;
            }
        }
    }
}
