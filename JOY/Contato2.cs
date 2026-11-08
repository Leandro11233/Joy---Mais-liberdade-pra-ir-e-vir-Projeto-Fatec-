using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Contato2 : Form
    {
        public Contato2()
        {
            InitializeComponent();
        }

        private void txtNomeContato1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeContato2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneContato2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            string nome = txtNomeContato2.Text.Trim();
            if (string.IsNullOrWhiteSpace(nome) ||
                nome.Equals("Nome", StringComparison.OrdinalIgnoreCase) ||
                !System.Text.RegularExpressions.Regex.IsMatch(
                    nome, @"^[\p{L}]+(?:['-][\p{L}]+)*$")
                )
            {
                MessageBox.Show("Digite um nome válido.",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNomeContato2.Focus();
                return;
            }

            Sucesso tela = new Sucesso();
            tela.Show();
            this.Hide();

        }

        private void txtTelefoneContato2_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }
    }
}