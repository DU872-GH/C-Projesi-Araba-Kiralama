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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            btnArabaDuzenle = new Button();
            btnArabaSil = new Button();
            ArabaTablosu = new DataGridView();
            arabalarBindingSource = new BindingSource(components);
            arabarepoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arabalarBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arabarepoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(620, 48);
            label1.TabIndex = 0;
            label1.Text = "Araç Listesi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(10, 64);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Araba Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnArabaDuzenle
            // 
            btnArabaDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnArabaDuzenle.Location = new Point(437, 64);
            btnArabaDuzenle.Margin = new Padding(3, 2, 3, 2);
            btnArabaDuzenle.Name = "btnArabaDuzenle";
            btnArabaDuzenle.Size = new Size(108, 22);
            btnArabaDuzenle.TabIndex = 2;
            btnArabaDuzenle.Text = "Araba Düzenle";
            btnArabaDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnArabaSil
            // 
            btnArabaSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnArabaSil.Location = new Point(550, 64);
            btnArabaSil.Margin = new Padding(3, 2, 3, 2);
            btnArabaSil.Name = "btnArabaSil";
            btnArabaSil.Size = new Size(82, 22);
            btnArabaSil.TabIndex = 3;
            btnArabaSil.Text = "Araba Sil";
            btnArabaSil.UseVisualStyleBackColor = true;
            // 
            // ArabaTablosu
            // 
            ArabaTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArabaTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArabaTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArabaTablosu.Location = new Point(10, 105);
            ArabaTablosu.Margin = new Padding(3, 2, 3, 2);
            ArabaTablosu.MultiSelect = false;
            ArabaTablosu.Name = "ArabaTablosu";
            ArabaTablosu.RowHeadersVisible = false;
            ArabaTablosu.RowHeadersWidth = 51;
            ArabaTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArabaTablosu.Size = new Size(620, 365);
            ArabaTablosu.TabIndex = 4;
            ArabaTablosu.CellContentClick += ArabaTablosu_CellContentClick;
            // 
            // arabalarBindingSource
            // 
            arabalarBindingSource.DataSource = typeof(Modüller.Arabalar);
            // 
            // arabarepoBindingSource
            // 
            arabarepoBindingSource.DataSource = typeof(Repo.Araba_repo);
            // 
            // btnArabaEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 479);
            Controls.Add(ArabaTablosu);
            Controls.Add(btnArabaSil);
            Controls.Add(btnArabaDuzenle);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "btnArabaEkle";
            Text = "Araç Listesi";
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).EndInit();
            ((System.ComponentModel.ISupportInitialize)arabalarBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)arabarepoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnArabaDuzenle;
        private Button btnArabaSil;
        private DataGridView ArabaTablosu;
        private BindingSource arabarepoBindingSource;
        private BindingSource arabalarBindingSource;
    }
}
