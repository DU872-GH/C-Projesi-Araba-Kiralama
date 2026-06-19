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
            picAraba1 = new PictureBox();
            picAraba2 = new PictureBox();
            picAraba3 = new PictureBox();
            picAraba4 = new PictureBox();
            girisKayitButton = new Button();
            picLogo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picAraba1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAraba2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAraba3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAraba4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picAraba1
            // 
            picAraba1.BorderStyle = BorderStyle.FixedSingle;
            picAraba1.Location = new Point(238, 303);
            picAraba1.Name = "picAraba1";
            picAraba1.Size = new Size(222, 64);
            picAraba1.TabIndex = 2;
            picAraba1.TabStop = false;
            // 
            // picAraba2
            // 
            picAraba2.BorderStyle = BorderStyle.FixedSingle;
            picAraba2.Location = new Point(466, 303);
            picAraba2.Name = "picAraba2";
            picAraba2.Size = new Size(222, 64);
            picAraba2.TabIndex = 3;
            picAraba2.TabStop = false;
            // 
            // picAraba3
            // 
            picAraba3.BorderStyle = BorderStyle.FixedSingle;
            picAraba3.Location = new Point(10, 303);
            picAraba3.Name = "picAraba3";
            picAraba3.Size = new Size(222, 64);
            picAraba3.TabIndex = 4;
            picAraba3.TabStop = false;
            // 
            // picAraba4
            // 
            picAraba4.BorderStyle = BorderStyle.FixedSingle;
            picAraba4.Location = new Point(10, 373);
            picAraba4.Name = "picAraba4";
            picAraba4.Size = new Size(678, 94);
            picAraba4.TabIndex = 5;
            picAraba4.TabStop = false;
            // 
            // girisKayitButton
            // 
            girisKayitButton.BackgroundImageLayout = ImageLayout.None;
            girisKayitButton.Cursor = Cursors.Hand;
            girisKayitButton.FlatAppearance.BorderColor = Color.Black;
            girisKayitButton.FlatAppearance.BorderSize = 0;
            girisKayitButton.FlatAppearance.MouseDownBackColor = Color.White;
            girisKayitButton.FlatAppearance.MouseOverBackColor = Color.White;
            girisKayitButton.FlatStyle = FlatStyle.Flat;
            girisKayitButton.ForeColor = Color.Black;
            girisKayitButton.Location = new Point(569, 12);
            girisKayitButton.Name = "girisKayitButton";
            girisKayitButton.Size = new Size(119, 39);
            girisKayitButton.TabIndex = 6;
            girisKayitButton.Text = "Kayıt Ol / Giriş Yap";
            girisKayitButton.UseVisualStyleBackColor = true;
            girisKayitButton.Click += girisKayitButton_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(10, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(155, 61);
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 394);
            label1.Name = "label1";
            label1.Size = new Size(317, 45);
            label1.TabIndex = 7;
            label1.Text = "buraya araba fotoğrafları gelecek fakat resource içerisine \r\nkoyup çekmeye çalışınca hata alıyorum her bir picture box \r\niçin aynı mevzu geçerli\r\n";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 479);
            Controls.Add(label1);
            Controls.Add(picLogo);
            Controls.Add(girisKayitButton);
            Controls.Add(picAraba4);
            Controls.Add(picAraba3);
            Controls.Add(picAraba2);
            Controls.Add(picAraba1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)picAraba1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAraba2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAraba3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAraba4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picAraba1;
        private PictureBox picAraba2;
        private PictureBox picAraba3;
        private PictureBox picAraba4;
        private Button girisKayitButton;
        private PictureBox picLogo;
        private Label label1;
    }
}