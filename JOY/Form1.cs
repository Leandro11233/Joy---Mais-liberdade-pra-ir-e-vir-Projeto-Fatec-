namespace JOY
{
    public partial class JOY : Form
    {
        public JOY()
        {
            InitializeComponent();
        }

        private void JOY_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DialogResult resultado = MessageBox.Show(
                    "Por favor, informe seu nome para continuar!",
                    "JOY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                if (resultado == DialogResult.OK)
                {
                    textBox1.Focus();
                }
                return;
            }

            DadosContato.NomeUsuario = textBox1.Text.Trim();

            DataNasc tela = new DataNasc();
            tela.Show();
            this.Hide();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar) &&
            e.KeyChar != '-' &&
            e.KeyChar != '\'' &&
            !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        
        }
    }
}
