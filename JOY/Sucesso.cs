using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JOY
{
    public partial class Sucesso : Form
    {
        public Sucesso()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.Close();
        }
    }
}
