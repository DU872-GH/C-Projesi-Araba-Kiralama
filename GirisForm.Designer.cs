namespace araba_kiralama
{
    partial class GirisForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            girisKayitButton = new Button();
            yazıLabel = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(370, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 0;
            label1.Text = "GİRİŞ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(41, 52);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 3;
            label2.Text = "T.C Kimlik Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(41, 90);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 4;
            label3.Text = "Telefon Numarası";
            // 
            // girisKayitButton
            // 
            girisKayitButton.BackgroundImageLayout = ImageLayout.None;
            girisKayitButton.Cursor = Cursors.Hand;
            girisKayitButton.FlatAppearance.BorderSize = 0;
            girisKayitButton.ForeColor = Color.Black;
            girisKayitButton.Location = new Point(309, 145);
            girisKayitButton.Name = "girisKayitButton";
            girisKayitButton.Size = new Size(119, 39);
            girisKayitButton.TabIndex = 7;
            girisKayitButton.Text = "Giriş Yap";
            girisKayitButton.UseVisualStyleBackColor = true;
            // 
            // yazıLabel
            // 
            yazıLabel.AutoSize = true;
            yazıLabel.Location = new Point(31, 200);
            yazıLabel.Name = "yazıLabel";
            yazıLabel.Size = new Size(208, 15);
            yazıLabel.TabIndex = 8;
            yazıLabel.Text = "Eğer daha önceden kayıt olmadıysanız";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(236, 200);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "buraya";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 200);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 10;
            label4.Text = "tıklayarak kayıt olabilirsiniz.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(yazıLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(girisKayitButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(356, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 451);
            panel1.TabIndex = 14;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "GirisForm";
            Text = "Kayıt Ol / Giriş Yap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button girisKayitButton;
        private Label yazıLabel;
        private LinkLabel linkLabel1;
        private Label label4;
        private Panel panel1;
    }
}