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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
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
            button7.Location = new Point(26, 517);
            button7.Name = "button7";
            button7.Size = new Size(129, 96);
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
            button3.Location = new Point(14, 643);
            button3.Name = "button3";
            button3.Size = new Size(424, 63);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // chkApe
            // 
            chkApe.AutoSize = true;
            chkApe.Location = new Point(38, 532);
            chkApe.Name = "chkApe";
            chkApe.Size = new Size(18, 17);
            chkApe.TabIndex = 14;
            chkApe.UseVisualStyleBackColor = true;
            chkApe.CheckedChanged += chkApe_CheckedChanged;
            // 
            // chkOnibus
            // 
            chkOnibus.AutoSize = true;
            chkOnibus.Location = new Point(178, 532);
            chkOnibus.Name = "chkOnibus";
            chkOnibus.Size = new Size(18, 17);
            chkOnibus.TabIndex = 15;
            chkOnibus.UseVisualStyleBackColor = true;
            chkOnibus.CheckedChanged += chkOnibus_CheckedChanged;
            // 
            // chkCarro
            // 
            chkCarro.AutoSize = true;
            chkCarro.Location = new Point(319, 532);
            chkCarro.Name = "chkCarro";
            chkCarro.Size = new Size(18, 17);
            chkCarro.TabIndex = 16;
            chkCarro.UseVisualStyleBackColor = true;
            chkCarro.CheckedChanged += chkCarro_CheckedChanged;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 112);
            webView21.Name = "webView21";
            webView21.Size = new Size(435, 349);
            webView21.TabIndex = 18;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 776);
            Controls.Add(webView21);
            Controls.Add(chkCarro);
            Controls.Add(chkOnibus);
            Controls.Add(chkApe);
            Controls.Add(button3);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button3;
        private CheckBox chkApe;
        private CheckBox chkOnibus;
        private CheckBox chkCarro;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}