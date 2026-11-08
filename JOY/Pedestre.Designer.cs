namespace JOY
{
    partial class Pedestre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedestre));
            button30 = new Button();
            button29 = new Button();
            SuspendLayout();
            // 
            // button30
            // 
            button30.BackColor = Color.Transparent;
            button30.FlatAppearance.BorderColor = Color.White;
            button30.FlatAppearance.BorderSize = 0;
            button30.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button30.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button30.FlatStyle = FlatStyle.Flat;
            button30.ForeColor = Color.Transparent;
            button30.Location = new Point(12, 475);
            button30.Margin = new Padding(3, 2, 3, 2);
            button30.Name = "button30";
            button30.Size = new Size(371, 47);
            button30.TabIndex = 14;
            button30.UseVisualStyleBackColor = false;
            button30.Click += button30_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.Transparent;
            button29.FlatAppearance.BorderColor = Color.White;
            button29.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button29.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button29.FlatStyle = FlatStyle.Flat;
            button29.Location = new Point(12, 11);
            button29.Margin = new Padding(3, 2, 3, 2);
            button29.Name = "button29";
            button29.Size = new Size(52, 41);
            button29.TabIndex = 15;
            button29.UseVisualStyleBackColor = false;
            button29.Click += button29_Click;
            // 
            // Pedestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(402, 582);
            Controls.Add(button29);
            Controls.Add(button30);
            Enabled = false;
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pedestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedestre";
            ResumeLayout(false);
        }

        #endregion

        private Button button30;
        private Button button29;
    }
}