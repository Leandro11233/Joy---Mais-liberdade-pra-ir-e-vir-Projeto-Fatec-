using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JOY
{
    public partial class Condição : Form
    {
        public Condição()
        {
            InitializeComponent();
        }

        private void chkBaixaVisao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaixaVisao.Checked)
            {
                chkNenhuma.Checked = false;

            }
        }

        private void Condição_Load(object sender, EventArgs e)
        {

        }

        private void chkMobilidade_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMobilidade.Checked)
            {
                chkNenhuma.Checked = false;
            }
        }

        private void chkNenhuma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNenhuma.Checked)
            {
                chkBaixaVisao.Checked = false;
                chkAudicao.Checked = false;
                chkMobilidade.Checked = false;
                chkOutra.Checked = false;

            }


        }

        private void chkOutra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOutra.Checked)
            {
                chkNenhuma.Checked = false;
            }
        }

        private void chkAudicao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAudicao.Checked)
            {
                chkNenhuma.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataNasc tela = new DataNasc();
            tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!chkBaixaVisao.Checked &&
               !chkAudicao.Checked &&
               !chkMobilidade.Checked &&
               !chkOutra.Checked &&
               !chkNenhuma.Checked)
            {
                MessageBox.Show(
                    "Selecione pelo menos uma opção.",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            if (chkBaixaVisao.Checked)
            {
                Condição2 tela = new Condição2();
                tela.Show();
                this.Hide();
            }
            else if (chkMobilidade.Checked) 
            {
                Condição4 tela = new Condição4();
                tela.Show();
                this.Hide();
            }
            else if (chkAudicao.Checked)
            {
                Condição3 tela = new Condição3 ();
                tela.Show ();
                this.Hide();    
            }
            else if (chkOutra.Checked) 
            {
                Condição5 tela = new Condição5 ();
                tela.Show();
                this.Hide ();
            }
            else if (chkNenhuma.Checked)
            {
                Personalização tela = new Personalização();
                tela.Show();
                this.Hide();
            }
        }
    }
}
