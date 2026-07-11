namespace araba_kiralama
{
    partial class GirisKayit
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
            lblGiris = new Label();
            tbTC = new TextBox();
            tbAd = new TextBox();
            tbSoyad = new TextBox();
            tbTel = new TextBox();
            tbMail = new TextBox();
            tbSifre = new TextBox();
            lblTC = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblTel = new Label();
            lblMail = new Label();
            lblSifre = new Label();
            label7 = new Label();
            linkKaydol = new LinkLabel();
            linkYonetici = new LinkLabel();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // lblGiris
            // 
            lblGiris.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGiris.Location = new Point(12, 21);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(458, 40);
            lblGiris.TabIndex = 0;
            lblGiris.Text = "Giriş / Kayıt";
            lblGiris.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbTC
            // 
            tbTC.Location = new Point(220, 113);
            tbTC.Name = "tbTC";
            tbTC.Size = new Size(160, 27);
            tbTC.TabIndex = 5;
            // 
            // tbAd
            // 
            tbAd.Location = new Point(220, 146);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(160, 27);
            tbAd.TabIndex = 6;
            // 
            // tbSoyad
            // 
            tbSoyad.Location = new Point(220, 179);
            tbSoyad.Name = "tbSoyad";
            tbSoyad.Size = new Size(160, 27);
            tbSoyad.TabIndex = 7;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(220, 212);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(160, 27);
            tbTel.TabIndex = 8;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(220, 245);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(160, 27);
            tbMail.TabIndex = 9;
            // 
            // tbSifre
            // 
            tbSifre.Location = new Point(220, 146);
            tbSifre.Name = "tbSifre";
            tbSifre.Size = new Size(160, 27);
            tbSifre.TabIndex = 10;
            // 
            // lblTC
            // 
            lblTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTC.Location = new Point(64, 113);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(150, 27);
            lblTC.TabIndex = 11;
            lblTC.Text = "T.C. No:";
            // 
            // lblAd
            // 
            lblAd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAd.Location = new Point(64, 146);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(150, 27);
            lblAd.TabIndex = 12;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSoyad.Location = new Point(64, 179);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(150, 27);
            lblSoyad.TabIndex = 13;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTel
            // 
            lblTel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTel.Location = new Point(64, 212);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(156, 27);
            lblTel.TabIndex = 14;
            lblTel.Text = "Telefon Numarası:";
            // 
            // lblMail
            // 
            lblMail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(64, 245);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(150, 27);
            lblMail.TabIndex = 15;
            lblMail.Text = "E-Mail Adresi:";
            // 
            // lblSifre
            // 
            lblSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSifre.Location = new Point(64, 146);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(150, 27);
            lblSifre.TabIndex = 16;
            lblSifre.Text = "Şifre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(147, 343);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 17;
            label7.Text = "Üye değil misiniz ?";
            // 
            // linkKaydol
            // 
            linkKaydol.AutoSize = true;
            linkKaydol.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkKaydol.Location = new Point(177, 366);
            linkKaydol.Name = "linkKaydol";
            linkKaydol.Size = new Size(82, 23);
            linkKaydol.TabIndex = 18;
            linkKaydol.TabStop = true;
            linkKaydol.Text = "Kaydolun";
            linkKaydol.LinkClicked += linkKaydol_LinkClicked;
            // 
            // linkYonetici
            // 
            linkYonetici.AutoSize = true;
            linkYonetici.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkYonetici.Location = new Point(162, 400);
            linkYonetici.Name = "linkYonetici";
            linkYonetici.Size = new Size(111, 23);
            linkYonetici.TabIndex = 19;
            linkYonetici.TabStop = true;
            linkYonetici.Text = "Yönetici Girişi";
            linkYonetici.LinkClicked += linkYonetici_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(127, 290);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(190, 40);
            btnGiris.TabIndex = 20;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // GirisKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(btnGiris);
            Controls.Add(linkYonetici);
            Controls.Add(linkKaydol);
            Controls.Add(label7);
            Controls.Add(lblSifre);
            Controls.Add(lblMail);
            Controls.Add(lblTel);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(lblTC);
            Controls.Add(tbSifre);
            Controls.Add(tbMail);
            Controls.Add(tbTel);
            Controls.Add(tbSoyad);
            Controls.Add(tbAd);
            Controls.Add(tbTC);
            Controls.Add(lblGiris);
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "GirisKayit";
            Text = "GirisKayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGiris;
        private TextBox tbTC;
        private TextBox tbAd;
        private TextBox tbSoyad;
        private TextBox tbTel;
        private TextBox tbMail;
        private TextBox tbSifre;
        private Label lblTC;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblTel;
        private Label lblMail;
        private Label lblSifre;
        private Label label7;
        private LinkLabel linkKaydol;
        private LinkLabel linkYonetici;
        private Button btnGiris;
    }
}