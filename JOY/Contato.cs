using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Contato : Form
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string nome = txtNomeContato.Text.Trim();
            string telefone = txtTelefoneContato.Text.Trim();
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

                txtNomeContato.Focus();
                return;
            }
            DadosContato.Nome = nome;
            DadosContato.Telefone = telefone;

            Sucesso tela = new Sucesso();
            tela.Show();
            this.Hide();

        }

        private void Contato_Load(object sender, EventArgs e)
        {

        }

        private void buttom20_Click(object sender, EventArgs e)
        {
            Contato2 tela = new Contato2();
            tela.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Localização tela = new Localização();
            tela.Show();
            this.Hide();
        }

        private void txtTelefoneContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNomeContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter (e.KeyChar) &&
                !char.IsWhiteSpace (e.KeyChar) &&
                e.KeyChar!= '-' &&
                e.KeyChar != '\'' && 
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
