using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Condição2 : Form
    {
        public Condição2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Condição tela = new Condição();
            tela.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!chkLer.Checked &&
            !chkObstaculos.Checked &&
            !chkVultos.Checked &&
            !chkCegueira.Checked &&
            !chkOutraSituação.Checked)
            {
                MessageBox.Show("Selecione pelo menos uma opção.",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (chkOutraSituação.Checked)
            {
                Condição5 tela = new Condição5();
                tela.Show();
                this.Hide();
            }
            else if (!chkOutraSituação.Checked)
            {
                Personalização tela = new Personalização();
                tela.Show();
                this.Hide();
            }
        }
        private void chkVultos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutraSituação.Checked)
            {
                chkVultos.Checked = false;
            }
        }

        private void chkLer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutraSituação.Checked)
            {
                chkLer.Checked = false;
            }
        }

        private void chkObstaculos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutraSituação.Checked)
            {
                chkObstaculos.Checked = false;
            }
        }

        private void chkOutraSituação_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCegueira_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutraSituação.Checked)
            {
                chkCegueira.Checked = false;
            }
           
        }

        private void Condição2_Load(object sender, EventArgs e)
        {

        }
    }
}

