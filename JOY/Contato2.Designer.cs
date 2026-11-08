namespace JOY
{
    partial class Contato2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contato2));
            txtNomeContato1 = new TextBox();
            txtTelefoneContato2 = new TextBox();
            txtNomeContato2 = new TextBox();
            button21 = new Button();
            SuspendLayout();
            // 
            // txtNomeContato1
            // 
            txtNomeContato1.Font = new Font("Montserrat", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeContato1.ForeColor = SystemColors.GrayText;
            txtNomeContato1.Location = new Point(47, 372);
            txtNomeContato1.Multiline = true;
            txtNomeContato1.Name = "txtNomeContato1";
            txtNomeContato1.Size = new Size(373, 37);
            txtNomeContato1.TabIndex = 16;
            txtNomeContato1.TextChanged += txtNomeContato1_TextChanged;
            // 
            // txtTelefoneContato2
            // 
            txtTelefoneContato2.Font = new Font("Montserrat", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefoneContato2.ForeColor = SystemColors.GrayText;
            txtTelefoneContato2.Location = new Point(21, 529);
            txtTelefoneContato2.Multiline = true;
            txtTelefoneContato2.Name = "txtTelefoneContato2";
            txtTelefoneContato2.Size = new Size(415, 40);
            txtTelefoneContato2.TabIndex = 18;
            txtTelefoneContato2.Text = "Telefone";
            txtTelefoneContato2.TextChanged += txtTelefoneContato2_TextChanged;
            txtTelefoneContato2.KeyPress += txtTelefoneContato2_KeyPress;
            // 
            // txtNomeContato2
            // 
            txtNomeContato2.Font = new Font("Montserrat", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeContato2.ForeColor = SystemColors.GrayText;
            txtNomeContato2.Location = new Point(21, 474);
            txtNomeContato2.Multiline = true;
            txtNomeContato2.Name = "txtNomeContato2";
            txtNomeContato2.Size = new Size(415, 40);
            txtNomeContato2.TabIndex = 19;
            txtNomeContato2.Text = "Nome";
            txtNomeContato2.TextChanged += txtNomeContato2_TextChanged;
            // 
            // button21
            // 
            button21.BackColor = Color.Transparent;
            button21.FlatAppearance.BorderColor = Color.White;
            button21.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button21.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button21.FlatStyle = FlatStyle.Flat;
            button21.ForeColor = Color.Transparent;
            button21.Location = new Point(12, 655);
            button21.Name = "button21";
            button21.Size = new Size(436, 58);
            button21.TabIndex = 20;
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // Contato2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(button21);
            Controls.Add(txtNomeContato2);
            Controls.Add(txtTelefoneContato2);
            Controls.Add(txtNomeContato1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contato2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contato2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeContato1;
        private TextBox txtTelefoneContato2;
        private TextBox txtNomeContato2;
        private Button button21;
    }
}