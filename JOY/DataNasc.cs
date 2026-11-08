using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class DataNasc : Form
    {
        public DataNasc()
        {
            InitializeComponent();
        }

        private void DataNasc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Condição tela = new Condição();
            tela.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!dateTimePicker1.Checked)
            {
                DialogResult resultado = MessageBox.Show(
                    "Por favor, informe sua data de nascimento para continuar!",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                if (resultado == DialogResult.OK)
                {
                    dateTimePicker1.Focus();
                }
                return;
            }

            Condição tela = new Condição();
            tela.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            JOY tela = new JOY();
            tela.Show();
            this.Hide();
        }
    }
}