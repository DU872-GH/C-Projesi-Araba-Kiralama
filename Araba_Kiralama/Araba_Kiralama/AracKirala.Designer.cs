namespace araba_kiralama
{
    partial class AracKirala
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
            araclar = new ComboBox();
            label1 = new Label();
            tcKontrol = new TextBox();
            btnKira = new Button();
            dtBas = new DateTimePicker();
            dtSon = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUcret = new TextBox();
            SuspendLayout();
            // 
            // araclar
            // 
            araclar.FormattingEnabled = true;
            araclar.Location = new Point(367, 127);
            araclar.Name = "araclar";
            araclar.Size = new Size(223, 23);
            araclar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 1;
            label1.Text = "TC numaranızı giriniz:";
            // 
            // tcKontrol
            // 
            tcKontrol.Location = new Point(367, 41);
            tcKontrol.Name = "tcKontrol";
            tcKontrol.Size = new Size(223, 23);
            tcKontrol.TabIndex = 2;
            // 
            // btnKira
            // 
            btnKira.Font = new Font("Segoe UI", 15F);
            btnKira.Location = new Point(215, 393);
            btnKira.Name = "btnKira";
            btnKira.Size = new Size(149, 45);
            btnKira.TabIndex = 3;
            btnKira.Text = "Onayla";
            btnKira.UseVisualStyleBackColor = true;
            // 
            // dtBas
            // 
            dtBas.Location = new Point(12, 260);
            dtBas.Name = "dtBas";
            dtBas.Size = new Size(200, 23);
            dtBas.TabIndex = 4;
            // 
            // dtSon
            // 
            dtSon.Location = new Point(367, 260);
            dtSon.Name = "dtSon";
            dtSon.Size = new Size(200, 23);
            dtSon.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 6;
            label2.Text = "Başlangıç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(367, 212);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 7;
            label3.Text = "Bitiş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(231, 36);
            label4.TabIndex = 8;
            label4.Text = "Araç seçimi yapınız";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(12, 328);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 9;
            label5.Text = "Tahmini ücret:";
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(367, 336);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(223, 23);
            txtUcret.TabIndex = 10;
            // 
            // AracKirala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 495);
            Controls.Add(txtUcret);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtSon);
            Controls.Add(dtBas);
            Controls.Add(btnKira);
            Controls.Add(tcKontrol);
            Controls.Add(label1);
            Controls.Add(araclar);
            Name = "AracKirala";
            Text = "AracKirala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox araclar;
        private Label label1;
        private TextBox tcKontrol;
        private Button btnKira;
        private DateTimePicker dtBas;
        private DateTimePicker dtSon;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUcret;
    }
}