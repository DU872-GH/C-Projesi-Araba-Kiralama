namespace araba_kiralama
{
    partial class KayıtForm
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
            tcNoBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            adBox = new TextBox();
            soyadBox = new TextBox();
            telNoBox = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            girisKayitButton = new Button();
            mailBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 1;
            label1.Text = "KAYIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(38, 55);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 4;
            label2.Text = "T.C Kimlik Numarası";
            // 
            // tcNoBox
            // 
            tcNoBox.Location = new Point(229, 60);
            tcNoBox.MaxLength = 11;
            tcNoBox.Name = "tcNoBox";
            tcNoBox.PlaceholderText = "11 haneli T.C kimlik numaranız";
            tcNoBox.Size = new Size(196, 23);
            tcNoBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(38, 95);
            label3.Name = "label3";
            label3.Size = new Size(37, 28);
            label3.TabIndex = 6;
            label3.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(38, 135);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 7;
            label4.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 255);
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(38, 175);
            label5.Name = "label5";
            label5.Size = new Size(162, 28);
            label5.TabIndex = 8;
            label5.Text = "Telefon Numarası";
            // 
            // adBox
            // 
            adBox.Location = new Point(229, 100);
            adBox.MaxLength = 50;
            adBox.Name = "adBox";
            adBox.PlaceholderText = "Adınız";
            adBox.Size = new Size(196, 23);
            adBox.TabIndex = 9;
            // 
            // soyadBox
            // 
            soyadBox.Location = new Point(229, 140);
            soyadBox.MaxLength = 50;
            soyadBox.Name = "soyadBox";
            soyadBox.PlaceholderText = "Soyadınız";
            soyadBox.Size = new Size(196, 23);
            soyadBox.TabIndex = 10;
            // 
            // telNoBox
            // 
            telNoBox.Location = new Point(229, 180);
            telNoBox.MaxLength = 10;
            telNoBox.Name = "telNoBox";
            telNoBox.PlaceholderText = "'0' olmadan yazınız.";
            telNoBox.Size = new Size(196, 23);
            telNoBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 255);
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(38, 215);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 12;
            label6.Text = "E - Mail";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(girisKayitButton);
            panel1.Controls.Add(mailBox);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 451);
            panel1.TabIndex = 13;
            // 
            // girisKayitButton
            // 
            girisKayitButton.BackgroundImageLayout = ImageLayout.None;
            girisKayitButton.Cursor = Cursors.Hand;
            girisKayitButton.FlatAppearance.BorderSize = 0;
            girisKayitButton.ForeColor = Color.Black;
            girisKayitButton.Location = new Point(305, 280);
            girisKayitButton.Name = "girisKayitButton";
            girisKayitButton.Size = new Size(119, 39);
            girisKayitButton.TabIndex = 15;
            girisKayitButton.Text = "Kayıt Ol";
            girisKayitButton.UseVisualStyleBackColor = true;
            girisKayitButton.Click += girisKayitButton_Click;
            // 
            // mailBox
            // 
            mailBox.Location = new Point(228, 220);
            mailBox.MaxLength = 255;
            mailBox.Name = "mailBox";
            mailBox.PlaceholderText = "Mailiniz";
            mailBox.Size = new Size(196, 23);
            mailBox.TabIndex = 14;
            // 
            // KayıtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(telNoBox);
            Controls.Add(soyadBox);
            Controls.Add(adBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tcNoBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "KayıtForm";
            Text = "KayıtForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tcNoBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox adBox;
        private TextBox soyadBox;
        private TextBox telNoBox;
        private Label label6;
        private Panel panel1;
        private TextBox mailBox;
        private Button girisKayitButton;
    }
}