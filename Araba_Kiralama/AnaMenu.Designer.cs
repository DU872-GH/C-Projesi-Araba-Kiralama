namespace araba_kiralama
{
    partial class AnaMenu
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
            btnLogin = new Button();
            btnKaydol = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(510, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 49);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Giriş Yapın";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnKaydol
            // 
            btnKaydol.Location = new Point(652, 12);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(136, 49);
            btnKaydol.TabIndex = 1;
            btnKaydol.Text = "Kaydolun";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 639);
            Controls.Add(btnKaydol);
            Controls.Add(btnLogin);
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnKaydol;
    }
}