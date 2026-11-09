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
            button29 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button50 = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button29
            // 
            button29.BackColor = Color.Transparent;
            button29.FlatAppearance.BorderColor = Color.White;
            button29.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button29.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button29.FlatStyle = FlatStyle.Flat;
            button29.Location = new Point(14, 15);
            button29.Name = "button29";
            button29.Size = new Size(59, 55);
            button29.TabIndex = 15;
            button29.UseVisualStyleBackColor = false;
            button29.Click += button29_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(14, 187);
            webView21.Name = "webView21";
            webView21.Size = new Size(433, 428);
            webView21.TabIndex = 16;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // button3
            // 
            button50.BackColor = Color.Transparent;
            button50.FlatAppearance.BorderColor = Color.White;
            button50.FlatAppearance.BorderSize = 0;
            button50.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button50.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button50.FlatStyle = FlatStyle.Flat;
            button50.ForeColor = Color.Transparent;
            button50.Location = new Point(24, 638);
            button50.Name = "button50";
            button50.Size = new Size(411, 53);
            button50.TabIndex = 17;
            button50.UseVisualStyleBackColor = false;
            button50.Click += button50_Click;
            // 
            // Pedestre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 776);
            Controls.Add(button50);
            Controls.Add(webView21);
            Controls.Add(button29);
            Enabled = false;
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pedestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedestre";
            Load += Pedestre_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button29;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button50;
    }
}