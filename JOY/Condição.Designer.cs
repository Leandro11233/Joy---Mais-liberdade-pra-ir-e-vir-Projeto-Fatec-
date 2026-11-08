namespace JOY
{
    partial class Condição
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condição));
            chkBaixaVisao = new CheckBox();
            chkAudicao = new CheckBox();
            chkMobilidade = new CheckBox();
            chkOutra = new CheckBox();
            chkNenhuma = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // chkBaixaVisao
            // 
            chkBaixaVisao.AutoSize = true;
            chkBaixaVisao.Location = new Point(42, 363);
            chkBaixaVisao.Name = "chkBaixaVisao";
            chkBaixaVisao.Size = new Size(18, 17);
            chkBaixaVisao.TabIndex = 0;
            chkBaixaVisao.UseVisualStyleBackColor = true;
            chkBaixaVisao.CheckedChanged += chkBaixaVisao_CheckedChanged;
            chkBaixaVisao.Click += chkBaixaVisao_CheckedChanged;
            // 
            // chkAudicao
            // 
            chkAudicao.AutoSize = true;
            chkAudicao.Location = new Point(42, 409);
            chkAudicao.Name = "chkAudicao";
            chkAudicao.Size = new Size(18, 17);
            chkAudicao.TabIndex = 1;
            chkAudicao.UseVisualStyleBackColor = true;
            chkAudicao.CheckedChanged += chkAudicao_CheckedChanged;
            chkAudicao.Click += chkAudicao_CheckedChanged;
            // 
            // chkMobilidade
            // 
            chkMobilidade.AutoSize = true;
            chkMobilidade.Location = new Point(42, 460);
            chkMobilidade.Name = "chkMobilidade";
            chkMobilidade.Size = new Size(18, 17);
            chkMobilidade.TabIndex = 2;
            chkMobilidade.UseVisualStyleBackColor = true;
            chkMobilidade.CheckedChanged += chkMobilidade_CheckedChanged;
            chkMobilidade.Click += chkMobilidade_CheckedChanged;
            // 
            // chkOutra
            // 
            chkOutra.AutoSize = true;
            chkOutra.Location = new Point(42, 508);
            chkOutra.Name = "chkOutra";
            chkOutra.Size = new Size(18, 17);
            chkOutra.TabIndex = 3;
            chkOutra.UseVisualStyleBackColor = true;
            chkOutra.CheckedChanged += chkOutra_CheckedChanged;
            chkOutra.Click += chkOutra_CheckedChanged;
            // 
            // chkNenhuma
            // 
            chkNenhuma.AutoSize = true;
            chkNenhuma.Location = new Point(42, 556);
            chkNenhuma.Name = "chkNenhuma";
            chkNenhuma.Size = new Size(18, 17);
            chkNenhuma.TabIndex = 4;
            chkNenhuma.UseVisualStyleBackColor = true;
            chkNenhuma.CheckedChanged += chkNenhuma_CheckedChanged;
            chkNenhuma.Click += chkNenhuma_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 21);
            button2.Name = "button2";
            button2.Size = new Size(64, 56);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(12, 626);
            button3.Name = "button3";
            button3.Size = new Size(436, 76);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Condição
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(chkNenhuma);
            Controls.Add(chkOutra);
            Controls.Add(chkMobilidade);
            Controls.Add(chkAudicao);
            Controls.Add(chkBaixaVisao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Condição";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Condição";
            Load += Condição_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkBaixaVisao;
        private CheckBox chkAudicao;
        private CheckBox chkMobilidade;
        private CheckBox chkOutra;
        private CheckBox chkNenhuma;
        private Button button2;
        private Button button3;
    }
}