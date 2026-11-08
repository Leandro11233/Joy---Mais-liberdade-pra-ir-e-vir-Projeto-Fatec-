namespace JOY
{
    partial class Condição4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condição4));
            button7 = new Button();
            button11 = new Button();
            chkCaminharMuito = new CheckBox();
            chkEscadas = new CheckBox();
            chkVeiculos = new CheckBox();
            chkOutraSituação3 = new CheckBox();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(12, 647);
            button7.Name = "button7";
            button7.Size = new Size(436, 76);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.FlatAppearance.BorderColor = Color.White;
            button11.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(12, 24);
            button11.Name = "button11";
            button11.Size = new Size(64, 56);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // chkCaminharMuito
            // 
            chkCaminharMuito.AutoSize = true;
            chkCaminharMuito.Location = new Point(44, 350);
            chkCaminharMuito.Name = "chkCaminharMuito";
            chkCaminharMuito.Size = new Size(18, 17);
            chkCaminharMuito.TabIndex = 11;
            chkCaminharMuito.UseVisualStyleBackColor = true;
            chkCaminharMuito.CheckedChanged += chkCaminharMuito_CheckedChanged;
            chkCaminharMuito.Click += chkCaminharMuito_CheckedChanged;
            // 
            // chkEscadas
            // 
            chkEscadas.AutoSize = true;
            chkEscadas.Location = new Point(44, 420);
            chkEscadas.Name = "chkEscadas";
            chkEscadas.Size = new Size(18, 17);
            chkEscadas.TabIndex = 12;
            chkEscadas.UseVisualStyleBackColor = true;
            chkEscadas.CheckedChanged += chkEscadas_Click;
            chkEscadas.Click += chkEscadas_Click;
            // 
            // chkVeiculos
            // 
            chkVeiculos.AutoSize = true;
            chkVeiculos.Location = new Point(44, 493);
            chkVeiculos.Name = "chkVeiculos";
            chkVeiculos.Size = new Size(18, 17);
            chkVeiculos.TabIndex = 13;
            chkVeiculos.UseVisualStyleBackColor = true;
            chkVeiculos.CheckedChanged += chkVeiculos_CheckedChanged;
            chkVeiculos.Click += chkVeiculos_CheckedChanged;
            // 
            // chkOutraSituação3
            // 
            chkOutraSituação3.AutoSize = true;
            chkOutraSituação3.Location = new Point(44, 558);
            chkOutraSituação3.Name = "chkOutraSituação3";
            chkOutraSituação3.Size = new Size(18, 17);
            chkOutraSituação3.TabIndex = 14;
            chkOutraSituação3.UseVisualStyleBackColor = true;
            chkOutraSituação3.CheckedChanged += chkOutraSituação3_CheckedChanged;
            chkOutraSituação3.Click += chkOutraSituação3_CheckedChanged;
            // 
            // Condição4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(chkOutraSituação3);
            Controls.Add(chkVeiculos);
            Controls.Add(chkEscadas);
            Controls.Add(chkCaminharMuito);
            Controls.Add(button11);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Condição4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Condição4";
            Load += Condição4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button11;
        private CheckBox chkCaminharMuito;
        private CheckBox chkEscadas;
        private CheckBox chkVeiculos;
        private CheckBox chkOutraSituação3;
    }
}