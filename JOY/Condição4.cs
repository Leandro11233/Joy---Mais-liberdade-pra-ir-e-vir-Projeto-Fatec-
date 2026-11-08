using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Condição4 : Form
    {
        public Condição4()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!chkCaminharMuito.Checked &&
           !chkEscadas.Checked &&
           !chkVeiculos.Checked &&
           !chkOutraSituação3.Checked)
            {
                MessageBox.Show("Selecione pelo menos uma opção.",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (chkOutraSituação3.Checked)
            {
                Condição5 tela = new Condição5();
                tela.Show();
                this.Hide();
            }
            else if (!chkOutraSituação3.Checked)
            {

                Personalização tela = new Personalização();
                tela.Show();
                this.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Condição tela = new Condição();
            tela.Show();
            this.Hide();
        }

        private void Condição4_Load(object sender, EventArgs e)
        {

        }

        private void chkVeiculos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOutraSituação3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCaminharMuito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEscadas_Click(object sender, EventArgs e)
        {

        }
    }
}
