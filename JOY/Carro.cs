using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace JOY
{
    public partial class Carro : Form
    {
        public Carro()
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
    }
}
