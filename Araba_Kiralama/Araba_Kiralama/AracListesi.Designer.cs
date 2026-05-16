namespace araba_kiralama
{
    partial class btnArabaEkle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            btnArabaDuzenle = new Button();
            btnArabaSil = new Button();
            ArabaTablosu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(708, 64);
            label1.TabIndex = 0;
            label1.Text = "Arabalar Listesi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Araba Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnArabaDuzenle
            // 
            btnArabaDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnArabaDuzenle.Location = new Point(499, 85);
            btnArabaDuzenle.Name = "btnArabaDuzenle";
            btnArabaDuzenle.Size = new Size(123, 29);
            btnArabaDuzenle.TabIndex = 2;
            btnArabaDuzenle.Text = "Araba Düzenle";
            btnArabaDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnArabaSil
            // 
            btnArabaSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnArabaSil.Location = new Point(628, 85);
            btnArabaSil.Name = "btnArabaSil";
            btnArabaSil.Size = new Size(94, 29);
            btnArabaSil.TabIndex = 3;
            btnArabaSil.Text = "Araba Sil";
            btnArabaSil.UseVisualStyleBackColor = true;
            // 
            // ArabaTablosu
            // 
            ArabaTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArabaTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArabaTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArabaTablosu.Location = new Point(12, 140);
            ArabaTablosu.MultiSelect = false;
            ArabaTablosu.Name = "ArabaTablosu";
            ArabaTablosu.RowHeadersVisible = false;
            ArabaTablosu.RowHeadersWidth = 51;
            ArabaTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArabaTablosu.Size = new Size(708, 487);
            ArabaTablosu.TabIndex = 4;
            ArabaTablosu.CellContentClick += ArabaTablosu_CellContentClick;
            // 
            // btnArabaEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 639);
            Controls.Add(ArabaTablosu);
            Controls.Add(btnArabaSil);
            Controls.Add(btnArabaDuzenle);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "btnArabaEkle";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnArabaDuzenle;
        private Button btnArabaSil;
        private DataGridView ArabaTablosu;
    }
}
