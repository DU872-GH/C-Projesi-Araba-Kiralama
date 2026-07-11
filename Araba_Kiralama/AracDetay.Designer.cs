namespace araba_kiralama
{
    partial class AracDetay
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
            lblAracIsmi = new Label();
            panel1 = new Panel();
            lblUcretGunluk = new Label();
            lblKm = new Label();
            lblYil = new Label();
            lblVites = new Label();
            lblTur = new Label();
            lblPlaka = new Label();
            tpAlmaGunu = new DateTimePicker();
            tpTeslimGunu = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            btnKirala = new Button();
            pictureBox1 = new PictureBox();
            btnKiralama = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAracIsmi
            // 
            lblAracIsmi.AutoSize = true;
            lblAracIsmi.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAracIsmi.Location = new Point(12, 9);
            lblAracIsmi.Name = "lblAracIsmi";
            lblAracIsmi.Size = new Size(230, 41);
            lblAracIsmi.TabIndex = 0;
            lblAracIsmi.Text = "Marka + Model";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUcretGunluk);
            panel1.Controls.Add(lblKm);
            panel1.Controls.Add(lblYil);
            panel1.Controls.Add(lblVites);
            panel1.Controls.Add(lblTur);
            panel1.Controls.Add(lblPlaka);
            panel1.Location = new Point(12, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 184);
            panel1.TabIndex = 1;
            // 
            // lblUcretGunluk
            // 
            lblUcretGunluk.AutoSize = true;
            lblUcretGunluk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUcretGunluk.Location = new Point(3, 149);
            lblUcretGunluk.Name = "lblUcretGunluk";
            lblUcretGunluk.Size = new Size(130, 28);
            lblUcretGunluk.TabIndex = 6;
            lblUcretGunluk.Text = "Günlük Ücret:";
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKm.Location = new Point(3, 121);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(45, 28);
            lblKm.TabIndex = 5;
            lblKm.Text = "Km:";
            // 
            // lblYil
            // 
            lblYil.AutoSize = true;
            lblYil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYil.Location = new Point(3, 93);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(37, 28);
            lblYil.TabIndex = 4;
            lblYil.Text = "Yıl:";
            // 
            // lblVites
            // 
            lblVites.AutoSize = true;
            lblVites.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblVites.Location = new Point(3, 65);
            lblVites.Name = "lblVites";
            lblVites.Size = new Size(58, 28);
            lblVites.TabIndex = 3;
            lblVites.Text = "Vites:";
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTur.Location = new Point(3, 37);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(44, 28);
            lblTur.TabIndex = 3;
            lblTur.Text = "Tür:";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPlaka.Location = new Point(3, 9);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(62, 28);
            lblPlaka.TabIndex = 2;
            lblPlaka.Text = "Plaka:";
            // 
            // tpAlmaGunu
            // 
            tpAlmaGunu.Location = new Point(221, 243);
            tpAlmaGunu.Name = "tpAlmaGunu";
            tpAlmaGunu.Size = new Size(230, 27);
            tpAlmaGunu.TabIndex = 2;
            // 
            // tpTeslimGunu
            // 
            tpTeslimGunu.Location = new Point(221, 276);
            tpTeslimGunu.Name = "tpTeslimGunu";
            tpTeslimGunu.Size = new Size(230, 27);
            tpTeslimGunu.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 243);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(186, 202);
            checkedListBox1.TabIndex = 4;
            // 
            // btnKirala
            // 
            btnKirala.Location = new Point(221, 320);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(230, 49);
            btnKirala.TabIndex = 5;
            btnKirala.Text = "Fiyat";
            btnKirala.UseVisualStyleBackColor = true;
            btnKirala.Click += btnKirala_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(537, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 202);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnKiralama
            // 
            btnKiralama.Location = new Point(221, 396);
            btnKiralama.Name = "btnKiralama";
            btnKiralama.Size = new Size(230, 49);
            btnKiralama.TabIndex = 7;
            btnKiralama.Text = "Kirala";
            btnKiralama.UseVisualStyleBackColor = false;
            btnKiralama.Click += btnKiralama_Click;
            // 
            // AracDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnKiralama);
            Controls.Add(pictureBox1);
            Controls.Add(btnKirala);
            Controls.Add(checkedListBox1);
            Controls.Add(tpTeslimGunu);
            Controls.Add(tpAlmaGunu);
            Controls.Add(panel1);
            Controls.Add(lblAracIsmi);
            Name = "AracDetay";
            Text = "AracDetay";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAracIsmi;
        private Panel panel1;
        private Label lblPlaka;
        private Label lblVites;
        private Label lblTur;
        private Label lblYil;
        private Label lblKm;
        private Label lblUcretGunluk;
        private DateTimePicker tpAlmaGunu;
        private DateTimePicker tpTeslimGunu;
        private CheckedListBox checkedListBox1;
        private Button btnKirala;
        private PictureBox pictureBox1;
        private Button btnKiralama;
    }
}