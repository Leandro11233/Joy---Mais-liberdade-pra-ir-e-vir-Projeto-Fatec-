namespace JOY
{
    partial class Condição2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condição2));
            button4 = new Button();
            button5 = new Button();
            button9 = new Button();
            chkLer = new CheckBox();
            chkObstaculos = new CheckBox();
            chkVultos = new CheckBox();
            chkCegueira = new CheckBox();
            chkOutraSituação = new CheckBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(64, 56);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(12, 645);
            button5.Name = "button5";
            button5.Size = new Size(436, 76);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(12, 22);
            button9.Name = "button9";
            button9.Size = new Size(64, 56);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // chkLer
            // 
            chkLer.AutoSize = true;
            chkLer.Location = new Point(43, 327);
            chkLer.Name = "chkLer";
            chkLer.Size = new Size(18, 17);
            chkLer.TabIndex = 11;
            chkLer.UseVisualStyleBackColor = true;
            chkLer.CheckedChanged += chkLer_CheckedChanged;
            chkLer.Click += chkLer_CheckedChanged;
            // 
            // chkObstaculos
            // 
            chkObstaculos.AutoSize = true;
            chkObstaculos.Location = new Point(43, 392);
            chkObstaculos.Name = "chkObstaculos";
            chkObstaculos.Size = new Size(18, 17);
            chkObstaculos.TabIndex = 12;
            chkObstaculos.UseVisualStyleBackColor = true;
            chkObstaculos.CheckedChanged += chkObstaculos_CheckedChanged;
            chkObstaculos.Click += chkObstaculos_CheckedChanged;
            // 
            // chkVultos
            // 
            chkVultos.AutoSize = true;
            chkVultos.Location = new Point(43, 454);
            chkVultos.Name = "chkVultos";
            chkVultos.Size = new Size(18, 17);
            chkVultos.TabIndex = 13;
            chkVultos.UseVisualStyleBackColor = true;
            chkVultos.CheckedChanged += chkVultos_CheckedChanged;
            chkVultos.Click += chkVultos_CheckedChanged;
            // 
            // chkCegueira
            // 
            chkCegueira.AutoSize = true;
            chkCegueira.Location = new Point(43, 517);
            chkCegueira.Name = "chkCegueira";
            chkCegueira.Size = new Size(18, 17);
            chkCegueira.TabIndex = 14;
            chkCegueira.UseVisualStyleBackColor = true;
            chkCegueira.CheckedChanged += chkCegueira_CheckedChanged;
            chkCegueira.Click += chkCegueira_CheckedChanged;
            // 
            // chkOutraSituação
            // 
            chkOutraSituação.AutoSize = true;
            chkOutraSituação.Location = new Point(43, 576);
            chkOutraSituação.Name = "chkOutraSituação";
            chkOutraSituação.Size = new Size(18, 17);
            chkOutraSituação.TabIndex = 15;
            chkOutraSituação.UseVisualStyleBackColor = true;
            chkOutraSituação.CheckedChanged += chkOutraSituação_CheckedChanged;
            chkOutraSituação.Click += chkOutraSituação_CheckedChanged;
            // 
            // Condição2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(chkOutraSituação);
            Controls.Add(chkCegueira);
            Controls.Add(chkVultos);
            Controls.Add(chkObstaculos);
            Controls.Add(chkLer);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Condição2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Condição2";
            Load += Condição2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button5;
        private Button button9;
        private CheckBox chkLer;
        private CheckBox chkObstaculos;
        private CheckBox chkVultos;
        private CheckBox chkCegueira;
        private CheckBox chkOutraSituação;
    }
}