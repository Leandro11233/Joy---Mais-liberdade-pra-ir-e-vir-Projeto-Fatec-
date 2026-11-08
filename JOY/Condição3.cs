using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Condição3 : Form
    {
        public Condição3()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Condição tela = new Condição();
            tela.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!chkEntender.Checked &&
            !chkMovimento.Checked &&
            !chkSurdo.Checked &&
            !chkOutraSituação2.Checked)
            {
                MessageBox.Show("Selecione pelo menos uma opção.",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            if (chkOutraSituação2.Checked)
            {
                Condição5 tela = new Condição5();
                tela.Show();
                this.Hide();
            }
            else if (!chkOutraSituação2.Checked)
            {

                Personalização tela = new Personalização();
                tela.Show();
                this.Hide();
            }
        }
        private void Condição3_Load(object sender, EventArgs e)
        {

        }

        private void chkEntender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSurdo.Checked)
            {
                chkEntender.Checked = false;
            }
            else if (chkOutraSituação2.Checked)
            {
                chkEntender.Checked = false;

            }

        }
        private void chkSurdo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSurdo.Checked)
            {
                chkEntender.Checked = false;
                chkMovimento.Checked = false;
                chkOutraSituação2.Checked = false;

            }
        }

        private void chkMovimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSurdo.Checked)
            {
                chkMovimento.Checked = false;
            }
            else if (chkOutraSituação2.Checked)
            {
                chkMovimento.Checked = false;

            }

        }

        private void chkOutraSituação2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSurdo.Checked)
            {
                chkOutraSituação2.Checked = false;

            }
            else if (chkOutraSituação2.Checked)
            {
                chkEntender.Checked = false;

            }
        }
    }
}

