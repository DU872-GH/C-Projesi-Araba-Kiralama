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
            SuspendLayout();
            // 
            // lbBaslık
            // 
            lbBaslık.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbBaslık.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbBaslık.Location = new Point(10, 7);
            lbBaslık.Name = "lbBaslık";
            lbBaslık.Size = new Size(476, 41);
            lbBaslık.TabIndex = 0;
            lbBaslık.Text = "Araç Ekle";
            lbBaslık.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 74);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Araç ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 98);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Plaka";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(197, 74);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 15);
            lbID.TabIndex = 3;
            // 
            // tbPlaka
            // 
            tbPlaka.Location = new Point(197, 91);
            tbPlaka.Margin = new Padding(3, 2, 3, 2);
            tbPlaka.Name = "tbPlaka";
            tbPlaka.Size = new Size(230, 23);
            tbPlaka.TabIndex = 4;
            // 
            // tbTur
            // 
            tbTur.Location = new Point(197, 116);
            tbTur.Margin = new Padding(3, 2, 3, 2);
            tbTur.Name = "tbTur";
            tbTur.Size = new Size(230, 23);
            tbTur.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 123);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "Tür";
            // 
            // tbMarka
            // 
            tbMarka.Location = new Point(197, 141);
            tbMarka.Margin = new Padding(3, 2, 3, 2);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(230, 23);
            tbMarka.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 148);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Marka";
            // 
            // tbModel
            // 
            tbModel.Location = new Point(197, 165);
            tbModel.Margin = new Padding(3, 2, 3, 2);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(230, 23);
            tbModel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 172);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Model";
            // 
            // tbYıl
            // 
            tbYıl.Location = new Point(197, 190);
            tbYıl.Margin = new Padding(3, 2, 3, 2);
            tbYıl.Name = "tbYıl";
            tbYıl.Size = new Size(230, 23);
            tbYıl.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 197);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 11;
            label6.Text = "Üretim Yılı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(197, 229);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 22);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(309, 229);
            btnIptal.Margin = new Padding(3, 2, 3, 2);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(82, 22);
            btnIptal.TabIndex = 14;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // EkleDüzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 274);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}