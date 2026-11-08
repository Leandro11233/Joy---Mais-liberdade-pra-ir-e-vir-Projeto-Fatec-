namespace JOY
{
    partial class Sucesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucesso));
            button22 = new Button();
            SuspendLayout();
            // 
            // button22
            // 
            button22.BackColor = Color.Transparent;
            button22.FlatAppearance.BorderColor = Color.White;
            button22.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button22.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button22.FlatStyle = FlatStyle.Flat;
            button22.ForeColor = Color.Transparent;
            button22.Location = new Point(12, 600);
            button22.Name = "button22";
            button22.Size = new Size(436, 58);
            button22.TabIndex = 21;
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // Sucesso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 776);
            Controls.Add(button22);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sucesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sucesso";
            ResumeLayout(false);
        }

        #endregion

        private Button button22;
    }
}