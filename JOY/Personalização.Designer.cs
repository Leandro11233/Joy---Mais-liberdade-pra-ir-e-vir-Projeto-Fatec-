namespace JOY
{
    partial class Personalização
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personalização));
            button13 = new Button();
            button14 = new Button();
            chkTrajCurto = new CheckBox();
            chkEvitarEscadas = new CheckBox();
            chkAcessoFacilVeiculo = new CheckBox();
            chkOutrasPreferências = new CheckBox();
            SuspendLayout();
            // 
            // button13
            // 
            button13.BackColor = Color.Transparent;
            button13.FlatAppearance.BorderColor = Color.White;
            button13.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button13.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(12, 26);
            button13.Name = "button13";
            button13.Size = new Size(64, 56);
            button13.TabIndex = 11;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Transparent;
            button14.FlatAppearance.BorderColor = Color.White;
            button14.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button14.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.Transparent;
            button14.Location = new Point(12, 627);
            button14.Name = "button14";
            button14.Size = new Size(436, 76);
            button14.TabIndex = 12;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // chkTrajCurto
            // 
            chkTrajCurto.AutoSize = true;
            chkTrajCurto.Location = new Point(44, 371);
            chkTrajCurto.Name = "chkTrajCurto";
            chkTrajCurto.Size = new Size(18, 17);
            chkTrajCurto.TabIndex = 13;
            chkTrajCurto.UseVisualStyleBackColor = true;
            chkTrajCurto.CheckedChanged += chkTrajCurto_CheckedChanged;
            chkTrajCurto.Click += chkTrajCurto_CheckedChanged;
            // 
            // chkEvitarEscadas
            // 
            chkEvitarEscadas.AutoSize = true;
            chkEvitarEscadas.Location = new Point(44, 443);
            chkEvitarEscadas.Name = "chkEvitarEscadas";
            chkEvitarEscadas.Size = new Size(18, 17);
            chkEvitarEscadas.TabIndex = 14;
            chkEvitarEscadas.UseVisualStyleBackColor = true;
            chkEvitarEscadas.CheckedChanged += chkEvitarEscadas_CheckedChanged;
            chkEvitarEscadas.Click += chkEvitarEscadas_CheckedChanged;
            // 
            // chkAcessoFacilVeiculo
            // 
            chkAcessoFacilVeiculo.AutoSize = true;
            chkAcessoFacilVeiculo.Location = new Point(44, 513);
            chkAcessoFacilVeiculo.Name = "chkAcessoFacilVeiculo";
            chkAcessoFacilVeiculo.Size = new Size(18, 17);
            chkAcessoFacilVeiculo.TabIndex = 15;
            chkAcessoFacilVeiculo.UseVisualStyleBackColor = true;
            chkAcessoFacilVeiculo.CheckedChanged += chkAcessoFacilVeiculo_CheckedChanged;
            chkAcessoFacilVeiculo.Click += chkAcessoFacilVeiculo_CheckedChanged;
            // 
            // chkOutrasPreferências
            // 
            chkOutrasPreferências.AutoSize = true;
            chkOutrasPreferências.Location = new Point(44, 574);
            chkOutrasPreferências.Name = "chkOutrasPreferências";
            chkOutrasPreferências.Size = new Size(18, 17);
            chkOutrasPreferências.TabIndex = 16;
            chkOutrasPreferências.UseVisualStyleBackColor = true;
            chkOutrasPreferências.CheckedChanged += chkOutrasPreferências_CheckedChanged;
            chkOutrasPreferências.Click += chkOutrasPreferências_CheckedChanged;
            // 
            // Personalização
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(chkOutrasPreferências);
            Controls.Add(chkAcessoFacilVeiculo);
            Controls.Add(chkEvitarEscadas);
            Controls.Add(chkTrajCurto);
            Controls.Add(button14);
            Controls.Add(button13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Personalização";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personalização";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button13;
        private Button button14;
        private CheckBox chkTrajCurto;
        private CheckBox chkEvitarEscadas;
        private CheckBox chkAcessoFacilVeiculo;
        private CheckBox chkOutrasPreferências;
    }
}