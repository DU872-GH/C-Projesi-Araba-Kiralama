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
            aracListesiButton = new Button();
            kiralananAracButton = new Button();
            picAraba1 = new PictureBox();
            picAraba2 = new PictureBox();
            picAraba3 = new PictureBox();
            picAraba4 = new PictureBox();
            girisKayitButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAraba1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAraba2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAraba3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAraba4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // aracListesiButton
            // 
            aracListesiButton.Cursor = Cursors.Hand;
            aracListesiButton.Location = new Point(261, 9);
            aracListesiButton.Margin = new Padding(3, 2, 3, 2);
            aracListesiButton.Name = "aracListesiButton";
            aracListesiButton.Size = new Size(153, 60);
            aracListesiButton.TabIndex = 0;
            aracListesiButton.Text = "Araç Listesi";
            aracListesiButton.UseVisualStyleBackColor = true;
            aracListesiButton.Click += button1_Click;
            // 
            // kiralananAracButton
            // 
            kiralananAracButton.Cursor = Cursors.Hand;
            kiralananAracButton.Location = new Point(261, 74);
            kiralananAracButton.Name = "kiralananAracButton";
            kiralananAracButton.Size = new Size(153, 59);
            kiralananAracButton.TabIndex = 1;
            kiralananAracButton.Text = "Kiraladığınız Araç Listesi";
            kiralananAracButton.UseVisualStyleBackColor = true;
            kiralananAracButton.Click += button2_Click;
            // 
            // picAraba1
            // 
            picAraba1.Location = new Point(238, 303);
            picAraba1.Name = "picAraba1";
            picAraba1.Size = new Size(222, 64);
            picAraba1.TabIndex = 2;
            picAraba1.TabStop = false;
            // 
            // picAraba2
            // 
            picAraba2.Location = new Point(466, 303);
            picAraba2.Name = "picAraba2";
            picAraba2.Size = new Size(222, 64);
            picAraba2.TabIndex = 3;
            picAraba2.TabStop = false;
            // 
            // picAraba3
            // 
            picAraba3.Location = new Point(10, 303);
            picAraba3.Name = "picAraba3";
            picAraba3.Size = new Size(222, 64);
            picAraba3.TabIndex = 4;
            picAraba3.TabStop = false;
            // 
            // picAraba4
            // 
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
            // pictureBox1
            // 
            using var _ =
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aracLogo.png;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 479);
            Controls.Add(pictureBox1);
            Controls.Add(girisKayitButton);
            Controls.Add(picAraba4);
            Controls.Add(picAraba3);
            Controls.Add(picAraba2);
            Controls.Add(picAraba1);
            Controls.Add(kiralananAracButton);
            Controls.Add(aracListesiButton);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)picAraba1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAraba2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAraba3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAraba4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button aracListesiButton;
        private Button kiralananAracButton;
        private PictureBox picAraba1;
        private PictureBox picAraba2;
        private PictureBox picAraba3;
        private PictureBox picAraba4;
        private Button girisKayitButton;
        private PictureBox pictureBox1;
    }
}