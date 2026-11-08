using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Onibus : Form
    {
        public Onibus()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selecionadas = 0;

            if (checkBox1.Checked) selecionadas++;
            if (checkBox2.Checked) selecionadas++;
            if (checkBox3.Checked) selecionadas++;

            if (selecionadas == 0)
            {
                MessageBox.Show("Erro! Selecione uma opção.");
                return;
            }

            if (selecionadas > 1)
            {
                MessageBox.Show("Erro! Selecione apenas uma opção.");
                return;
            }

            Mapa tela = new Mapa();
            tela.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
