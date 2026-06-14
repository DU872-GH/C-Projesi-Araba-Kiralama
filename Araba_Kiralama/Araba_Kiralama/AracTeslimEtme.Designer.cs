namespace araba_kiralama
{
    partial class AracTeslimEtme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTc = new TextBox();
            txtPlaka = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnDogrulama = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnTeslim = new Button();
            txtCeza = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 4;
            label3.Text = "TC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(38, 150);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 5;
            label4.Text = "Plaka";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(147, 36);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(230, 23);
            txtAd.TabIndex = 18;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(147, 74);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(230, 23);
            txtSoyad.TabIndex = 19;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(147, 112);
            txtTc.Margin = new Padding(3, 2, 3, 2);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(230, 23);
            txtTc.TabIndex = 20;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(147, 150);
            txtPlaka.Margin = new Padding(3, 2, 3, 2);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(230, 23);
            txtPlaka.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(332, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(332, 323);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(184, 23);
            dateTimePicker2.TabIndex = 23;
            // 
            // btnDogrulama
            // 
            btnDogrulama.Location = new Point(223, 203);
            btnDogrulama.Name = "btnDogrulama";
            btnDogrulama.Size = new Size(75, 43);
            btnDogrulama.TabIndex = 24;
            btnDogrulama.Text = "Giriş";
            btnDogrulama.UseVisualStyleBackColor = true;
            btnDogrulama.Click += btnDogrulama_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(38, 269);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 25;
            label5.Text = "Teslim Edilen Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(38, 323);
            label6.Name = "label6";
            label6.Size = new Size(265, 28);
            label6.TabIndex = 26;
            label6.Text = "Teslim Edilmesi Gereken Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(38, 389);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 27;
            label7.Text = "Gecikme Cezası";
            // 
            // btnTeslim
            // 
            btnTeslim.Location = new Point(307, 467);
            btnTeslim.Name = "btnTeslim";
            btnTeslim.Size = new Size(154, 43);
            btnTeslim.TabIndex = 28;
            btnTeslim.Text = "Araç Teslim Et";
            btnTeslim.UseVisualStyleBackColor = true;
            btnTeslim.Click += btnTeslim_Click;
            // 
            // txtCeza
            // 
            txtCeza.Location = new Point(332, 394);
            txtCeza.Margin = new Padding(3, 2, 3, 2);
            txtCeza.Name = "txtCeza";
            txtCeza.Size = new Size(184, 23);
            txtCeza.TabIndex = 29;
            // 
            // AracTeslimEtme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 571);
            Controls.Add(txtCeza);
            Controls.Add(btnTeslim);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnDogrulama);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPlaka);
            Controls.Add(txtTc);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AracTeslimEtme";
            Text = "Araç Teslim Etme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTc;
        private TextBox txtPlaka;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnDogrulama;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnTeslim;
        private TextBox txtCeza;
    }
}