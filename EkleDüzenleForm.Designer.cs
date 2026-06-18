namespace araba_kiralama
{
    partial class EkleDüzenleForm
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
            label1 = new Label();
            label2 = new Label();
            lbID = new Label();
            tbPlaka = new TextBox();
            tbTur = new TextBox();
            label3 = new Label();
            tbMarka = new TextBox();
            label4 = new Label();
            tbModel = new TextBox();
            label5 = new Label();
            tbYıl = new TextBox();
            label6 = new Label();
            btnKaydet = new Button();
            btnIptal = new Button();
            label7 = new Label();
            label8 = new Label();
            tbVites = new TextBox();
            tbKm = new TextBox();
            SuspendLayout();
            // 
            // lbBaslık
            // 
            lbBaslık.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbBaslık.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbBaslık.Location = new Point(11, 9);
            lbBaslık.Name = "lbBaslık";
            lbBaslık.Size = new Size(544, 55);
            lbBaslık.TabIndex = 0;
            lbBaslık.Text = "Araç Ekle";
            lbBaslık.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 99);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Araç ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 131);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "Plaka";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(225, 99);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 20);
            lbID.TabIndex = 3;
            // 
            // tbPlaka
            // 
            tbPlaka.Location = new Point(225, 131);
            tbPlaka.Name = "tbPlaka";
            tbPlaka.Size = new Size(262, 27);
            tbPlaka.TabIndex = 4;
            // 
            // tbTur
            // 
            tbTur.Location = new Point(225, 164);
            tbTur.Name = "tbTur";
            tbTur.Size = new Size(262, 27);
            tbTur.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 164);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 5;
            label3.Text = "Tür";
            // 
            // tbMarka
            // 
            tbMarka.Location = new Point(225, 197);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(262, 27);
            tbMarka.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 197);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Marka";
            // 
            // tbModel
            // 
            tbModel.Location = new Point(225, 229);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(262, 27);
            tbModel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 229);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 9;
            label5.Text = "Model";
            // 
            // tbYıl
            // 
            tbYıl.Location = new Point(225, 297);
            tbYıl.Name = "tbYıl";
            tbYıl.Size = new Size(262, 27);
            tbYıl.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 263);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 11;
            label6.Text = "Vites";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(225, 420);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(352, 420);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(94, 29);
            btnIptal.TabIndex = 14;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 297);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 15;
            label7.Text = "Üretim Yılı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 330);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 16;
            label8.Text = "Kilometre";
            // 
            // tbVites
            // 
            tbVites.Location = new Point(225, 263);
            tbVites.Name = "tbVites";
            tbVites.Size = new Size(262, 27);
            tbVites.TabIndex = 17;
            // 
            // tbKm
            // 
            tbKm.Location = new Point(225, 330);
            tbKm.Name = "tbKm";
            tbKm.Size = new Size(262, 27);
            tbKm.TabIndex = 18;
            // 
            // EkleDüzenleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 477);
            Controls.Add(tbKm);
            Controls.Add(tbVites);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(tbYıl);
            Controls.Add(label6);
            Controls.Add(tbModel);
            Controls.Add(label5);
            Controls.Add(tbMarka);
            Controls.Add(label4);
            Controls.Add(tbTur);
            Controls.Add(label3);
            Controls.Add(tbPlaka);
            Controls.Add(lbID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbBaslık);
            Cursor = Cursors.SizeAll;
            Name = "EkleDüzenleForm";
            Text = "Araç Ekle";
            Load += EkleDüzenleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBaslık;
        private Label label1;
        private Label label2;
        private Label lbID;
        private TextBox tbPlaka;
        private TextBox tbTur;
        private Label label3;
        private TextBox tbMarka;
        private Label label4;
        private TextBox tbModel;
        private Label label5;
        private TextBox tbYıl;
        private Label label6;
        private Button btnKaydet;
        private Button btnIptal;
        private Label label7;
        private Label label8;
        private TextBox tbVites;
        private TextBox tbKm;
    }
}