using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Condição5 : Form
    {
        public Condição5()
        {
            InitializeComponent();
        }

        private void Condição5_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Condição tela = new Condição();
            tela.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Personalização tela = new Personalização();
            tela.Show();
            this.Hide();
        }

        private void txtDificuldade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
