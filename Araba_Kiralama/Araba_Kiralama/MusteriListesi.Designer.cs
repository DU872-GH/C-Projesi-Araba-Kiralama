namespace araba_kiralama
{
    partial class MusteriListesi
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
            btnEkle = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            musteriTablosu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)musteriTablosu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(620, 48);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Listesi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(10, 64);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(82, 22);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Kayıt Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDuzenle.Location = new Point(437, 64);
            btnDuzenle.Margin = new Padding(3, 2, 3, 2);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(108, 22);
            btnDuzenle.TabIndex = 3;
            btnDuzenle.Text = "Kayıt Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSil.Location = new Point(550, 64);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(82, 22);
            btnSil.TabIndex = 4;
            btnSil.Text = "Kayıt Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // musteriTablosu
            // 
            musteriTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            musteriTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            musteriTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            musteriTablosu.Location = new Point(10, 105);
            musteriTablosu.Margin = new Padding(3, 2, 3, 2);
            musteriTablosu.MultiSelect = false;
            musteriTablosu.Name = "musteriTablosu";
            musteriTablosu.RowHeadersVisible = false;
            musteriTablosu.RowHeadersWidth = 51;
            musteriTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            musteriTablosu.Size = new Size(620, 365);
            musteriTablosu.TabIndex = 5;
            musteriTablosu.CellContentClick += MusteriTablosu_CellContentClick;
            // 
            // MusteriListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 479);
            Controls.Add(musteriTablosu);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Name = "MusteriListesi";
            Text = "Müşteri Listesi";
            ((System.ComponentModel.ISupportInitialize)musteriTablosu).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Label label1;
        private Button btnDuzenle;
        private Button btnSil;
        private DataGridView musteriTablosu;
        private Button btnEkle;
    }
}