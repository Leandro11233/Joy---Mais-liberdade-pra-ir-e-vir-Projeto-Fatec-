namespace JOY
{
    partial class Localização
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localização));
            button16 = new Button();
            button17 = new Button();
            chkSim = new CheckBox();
            chkNão = new CheckBox();
            SuspendLayout();
            // 
            // button16
            // 
            button16.BackColor = Color.Transparent;
            button16.FlatAppearance.BorderColor = Color.White;
            button16.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button16.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(12, 22);
            button16.Name = "button16";
            button16.Size = new Size(64, 56);
            button16.TabIndex = 11;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Transparent;
            button17.FlatAppearance.BorderColor = Color.White;
            button17.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button17.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.Transparent;
            button17.Location = new Point(12, 644);
            button17.Name = "button17";
            button17.Size = new Size(436, 58);
            button17.TabIndex = 12;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // chkSim
            // 
            chkSim.AutoSize = true;
            chkSim.Location = new Point(44, 385);
            chkSim.Name = "chkSim";
            chkSim.Size = new Size(18, 17);
            chkSim.TabIndex = 13;
            chkSim.UseVisualStyleBackColor = true;
            chkSim.CheckedChanged += chkSim_CheckedChanged;
            // 
            // chkNão
            // 
            chkNão.AutoSize = true;
            chkNão.Location = new Point(44, 464);
            chkNão.Name = "chkNão";
            chkNão.Size = new Size(18, 17);
            chkNão.TabIndex = 14;
            chkNão.UseVisualStyleBackColor = true;
            chkNão.CheckedChanged += chkNão_CheckedChanged;
            // 
            // Localização
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(chkNão);
            Controls.Add(chkSim);
            Controls.Add(button17);
            Controls.Add(button16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Localização";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localização";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button16;
        private Button button17;
        private CheckBox chkSim;
        private CheckBox chkNão;
    }
}