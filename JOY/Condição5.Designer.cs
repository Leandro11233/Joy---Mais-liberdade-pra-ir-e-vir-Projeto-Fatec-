namespace JOY
{
    partial class Condição5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condição5));
            button8 = new Button();
            button12 = new Button();
            txtDificuldade = new TextBox();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(12, 643);
            button8.Name = "button8";
            button8.Size = new Size(436, 58);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.FlatAppearance.BorderColor = Color.White;
            button12.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button12.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(21, 24);
            button12.Name = "button12";
            button12.Size = new Size(64, 56);
            button12.TabIndex = 10;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // txtDificuldade
            // 
            txtDificuldade.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDificuldade.Location = new Point(12, 343);
            txtDificuldade.Multiline = true;
            txtDificuldade.Name = "txtDificuldade";
            txtDificuldade.Size = new Size(436, 161);
            txtDificuldade.TabIndex = 11;
            txtDificuldade.TextChanged += txtDificuldade_TextChanged;
            // 
            // Condição5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(txtDificuldade);
            Controls.Add(button12);
            Controls.Add(button8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Condição5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Condição5";
            Load += Condição5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Button button12;
        private TextBox txtDificuldade;
    }
}