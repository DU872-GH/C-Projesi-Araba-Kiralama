namespace araba_kiralama
{
    partial class MusteriEkle
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
            lbBaslık = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            musEmail = new TextBox();
            musTel = new TextBox();
            musTc = new TextBox();
            musSoyad = new TextBox();
            musAD = new TextBox();
            btnIptal = new Button();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lbBaslık
            // 
            lbBaslık.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbBaslık.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbBaslık.Location = new Point(10, 7);
            lbBaslık.Name = "lbBaslık";
            lbBaslık.Size = new Size(476, 41);
            lbBaslık.TabIndex = 1;
            lbBaslık.Text = "Müşteri Kayıt";
            lbBaslık.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 197);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 16;
            label6.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 172);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 15;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 148);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 14;
            label4.Text = "TC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 123);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 98);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 12;
            label2.Text = "Ad";
            // 
            // musEmail
            // 
            musEmail.Location = new Point(197, 190);
            musEmail.Margin = new Padding(3, 2, 3, 2);
            musEmail.Name = "musEmail";
            musEmail.Size = new Size(230, 23);
            musEmail.TabIndex = 21;
            // 
            // musTel
            // 
            musTel.Location = new Point(197, 165);
            musTel.Margin = new Padding(3, 2, 3, 2);
            musTel.Name = "musTel";
            musTel.Size = new Size(230, 23);
            musTel.TabIndex = 20;
            // 
            // musTc
            // 
            musTc.Location = new Point(197, 141);
            musTc.Margin = new Padding(3, 2, 3, 2);
            musTc.Name = "musTc";
            musTc.Size = new Size(230, 23);
            musTc.TabIndex = 19;
            // 
            // musSoyad
            // 
            musSoyad.Location = new Point(197, 116);
            musSoyad.Margin = new Padding(3, 2, 3, 2);
            musSoyad.Name = "musSoyad";
            musSoyad.Size = new Size(230, 23);
            musSoyad.TabIndex = 18;
            // 
            // musAD
            // 
            musAD.Location = new Point(197, 91);
            musAD.Margin = new Padding(3, 2, 3, 2);
            musAD.Name = "musAD";
            musAD.Size = new Size(230, 23);
            musAD.TabIndex = 17;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(309, 229);
            btnIptal.Margin = new Padding(3, 2, 3, 2);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(82, 22);
            btnIptal.TabIndex = 23;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(197, 229);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 22);
            btnKaydet.TabIndex = 22;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 274);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(musEmail);
            Controls.Add(musTel);
            Controls.Add(musTc);
            Controls.Add(musSoyad);
            Controls.Add(musAD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbBaslık);
            Name = "MusteriEkle";
            Text = "Müşteri Ekle";
            Load += MusteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBaslık;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox musEmail;
        private TextBox musTel;
        private TextBox musTc;
        private TextBox musSoyad;
        private TextBox musAD;
        private Button btnIptal;
        private Button btnKaydet;
    }
}