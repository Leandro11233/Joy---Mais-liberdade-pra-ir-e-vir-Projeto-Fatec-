namespace JOY
{
    partial class Contato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contato));
            button18 = new Button();
            button19 = new Button();
            buttom20 = new Button();
            txtNomeContato = new TextBox();
            txtTelefoneContato = new TextBox();
            SuspendLayout();
            // 
            // button18
            // 
            button18.BackColor = Color.Transparent;
            button18.FlatAppearance.BorderColor = Color.White;
            button18.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button18.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Location = new Point(12, 25);
            button18.Name = "button18";
            button18.Size = new Size(64, 56);
            button18.TabIndex = 12;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Transparent;
            button19.FlatAppearance.BorderColor = Color.White;
            button19.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button19.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.Transparent;
            button19.Location = new Point(12, 621);
            button19.Name = "button19";
            button19.Size = new Size(436, 58);
            button19.TabIndex = 13;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // buttom20
            // 
            buttom20.BackColor = Color.Transparent;
            buttom20.FlatAppearance.BorderColor = Color.White;
            buttom20.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttom20.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttom20.FlatStyle = FlatStyle.Flat;
            buttom20.ForeColor = Color.Transparent;
            buttom20.Location = new Point(12, 511);
            buttom20.Name = "buttom20";
            buttom20.Size = new Size(436, 58);
            buttom20.TabIndex = 14;
            buttom20.UseVisualStyleBackColor = false;
            buttom20.Click += buttom20_Click;
            // 
            // txtNomeContato
            // 
            txtNomeContato.Font = new Font("Montserrat", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeContato.ForeColor = SystemColors.GrayText;
            txtNomeContato.Location = new Point(22, 359);
            txtNomeContato.Multiline = true;
            txtNomeContato.Name = "txtNomeContato";
            txtNomeContato.Size = new Size(416, 54);
            txtNomeContato.TabIndex = 15;
            txtNomeContato.Text = "Nome";
            txtNomeContato.TextChanged += txtNomeContato_TextChanged;
            txtNomeContato.KeyPress += txtNomeContato_KeyPress;
            // 
            // txtTelefoneContato
            // 
            txtTelefoneContato.Font = new Font("Montserrat", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefoneContato.ForeColor = SystemColors.GrayText;
            txtTelefoneContato.Location = new Point(22, 419);
            txtTelefoneContato.Multiline = true;
            txtTelefoneContato.Name = "txtTelefoneContato";
            txtTelefoneContato.Size = new Size(416, 58);
            txtTelefoneContato.TabIndex = 16;
            txtTelefoneContato.Text = "Telefone";
            txtTelefoneContato.TextChanged += txtTelefoneContato_TextChanged;
            txtTelefoneContato.KeyPress += txtTelefoneContato_KeyPress;
            // 
            // Contato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(txtTelefoneContato);
            Controls.Add(txtNomeContato);
            Controls.Add(buttom20);
            Controls.Add(button19);
            Controls.Add(button18);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contato";
            Load += Contato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button18;
        private Button button19;
        private Button buttom20;
        private TextBox txtNomeContato;
        private TextBox txtTelefoneContato;
    }
}