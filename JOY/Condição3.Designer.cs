namespace JOY
{
    partial class Condição3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condição3));
            button6 = new Button();
            button10 = new Button();
            chkEntender = new CheckBox();
            chkMovimento = new CheckBox();
            chkSurdo = new CheckBox();
            chkOutraSituação2 = new CheckBox();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(12, 628);
            button6.Name = "button6";
            button6.Size = new Size(436, 76);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.FlatAppearance.BorderColor = Color.White;
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(12, 21);
            button10.Name = "button10";
            button10.Size = new Size(64, 56);
            button10.TabIndex = 10;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // chkEntender
            // 
            chkEntender.AutoSize = true;
            chkEntender.Location = new Point(44, 332);
            chkEntender.Name = "chkEntender";
            chkEntender.Size = new Size(18, 17);
            chkEntender.TabIndex = 11;
            chkEntender.UseVisualStyleBackColor = true;
            chkEntender.CheckedChanged += chkEntender_CheckedChanged;
            chkEntender.Click += chkEntender_CheckedChanged;
            // 
            // chkMovimento
            // 
            chkMovimento.AutoSize = true;
            chkMovimento.Location = new Point(44, 400);
            chkMovimento.Name = "chkMovimento";
            chkMovimento.Size = new Size(18, 17);
            chkMovimento.TabIndex = 12;
            chkMovimento.UseVisualStyleBackColor = true;
            chkMovimento.CheckedChanged += chkMovimento_CheckedChanged;
            chkMovimento.Click += chkMovimento_CheckedChanged;
            // 
            // chkSurdo
            // 
            chkSurdo.AutoSize = true;
            chkSurdo.Location = new Point(44, 461);
            chkSurdo.Name = "chkSurdo";
            chkSurdo.Size = new Size(18, 17);
            chkSurdo.TabIndex = 13;
            chkSurdo.UseVisualStyleBackColor = true;
            chkSurdo.CheckedChanged += chkSurdo_CheckedChanged;
            chkSurdo.Click += chkSurdo_CheckedChanged;
            // 
            // chkOutraSituação2
            // 
            chkOutraSituação2.AutoSize = true;
            chkOutraSituação2.Location = new Point(44, 520);
            chkOutraSituação2.Name = "chkOutraSituação2";
            chkOutraSituação2.Size = new Size(18, 17);
            chkOutraSituação2.TabIndex = 14;
            chkOutraSituação2.UseVisualStyleBackColor = true;
            chkOutraSituação2.CheckedChanged += chkOutraSituação2_CheckedChanged;
            chkOutraSituação2.Click += chkOutraSituação2_CheckedChanged;
            // 
            // Condição3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(chkOutraSituação2);
            Controls.Add(chkSurdo);
            Controls.Add(chkMovimento);
            Controls.Add(chkEntender);
            Controls.Add(button10);
            Controls.Add(button6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Condição3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Condição3";
            Load += Condição3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button10;
        private CheckBox chkEntender;
        private CheckBox chkMovimento;
        private CheckBox chkSurdo;
        private CheckBox chkOutraSituação2;
    }
}