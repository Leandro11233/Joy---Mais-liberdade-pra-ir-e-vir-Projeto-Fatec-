namespace JOY
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button7 = new Button();
            button3 = new Button();
            chkApe = new CheckBox();
            chkOnibus = new CheckBox();
            chkCarro = new CheckBox();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(23, 388);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(113, 72);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(12, 482);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(371, 47);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // chkApe
            // 
            chkApe.AutoSize = true;
            chkApe.Location = new Point(33, 399);
            chkApe.Margin = new Padding(3, 2, 3, 2);
            chkApe.Name = "chkApe";
            chkApe.Size = new Size(15, 14);
            chkApe.TabIndex = 14;
            chkApe.UseVisualStyleBackColor = true;
            // 
            // chkOnibus
            // 
            chkOnibus.AutoSize = true;
            chkOnibus.Location = new Point(156, 399);
            chkOnibus.Margin = new Padding(3, 2, 3, 2);
            chkOnibus.Name = "chkOnibus";
            chkOnibus.Size = new Size(15, 14);
            chkOnibus.TabIndex = 15;
            chkOnibus.UseVisualStyleBackColor = true;
            // 
            // chkCarro
            // 
            chkCarro.AutoSize = true;
            chkCarro.Location = new Point(279, 399);
            chkCarro.Margin = new Padding(3, 2, 3, 2);
            chkCarro.Name = "chkCarro";
            chkCarro.Size = new Size(15, 14);
            chkCarro.TabIndex = 16;
            chkCarro.UseVisualStyleBackColor = true;
            chkCarro.CheckedChanged += chkCarro_CheckedChanged;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(402, 582);
            Controls.Add(chkCarro);
            Controls.Add(chkOnibus);
            Controls.Add(chkApe);
            Controls.Add(button3);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button3;
        private CheckBox chkApe;
        private CheckBox chkOnibus;
        private CheckBox chkCarro;
    }
}