using araba_kiralama.Modüller;
using araba_kiralama.Repo;
using Microsoft.Data.SqlClient;
using System.Data;

namespace araba_kiralama
{

    public partial class AracListesi : Form
    {
        public AracListesi()
        {
            InitializeComponent();
            ReadArabalar();
            ReadMusteri();
        }

        private void ReadArabalar()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Plaka");
            dataTable.Columns.Add("Tür");
            dataTable.Columns.Add("Marka");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("Vites");
            dataTable.Columns.Add("Yıl");
            dataTable.Columns.Add("Kilometre");
            dataTable.Columns.Add("Günlük Ü.");
            dataTable.Columns.Add("Kirada");

            var repo = new Araba_repo();
            var arabalar = repo.GetAraba();

            foreach (var araba in arabalar)
            {
                var row = dataTable.NewRow();

                row["ID"]    = araba.id;
                row["Plaka"] = araba.plaka;
                row["Tür"]   = araba.turu;
                row["Marka"] = araba.marka;
                row["Model"] = araba.modeli;
                row["Vites"] = araba.vites;
                row["Yıl"]       = araba.yil;
                row["Kilometre"] = araba.km;
                row["Günlük Ü."] = araba.gunlukUcret;
                row["Kirada"]    = araba.kirada;

                dataTable.Rows.Add(row);
            }

            this.ArabaTablosu.DataSource = dataTable;
        }

        private void ReadMusteri()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Ad");
            dataTable.Columns.Add("Soyad");
            dataTable.Columns.Add("T.C. No:");
            dataTable.Columns.Add("Telefon No:");
            dataTable.Columns.Add("Email");

            var repo = new Musteri_repo();
            var musteriler = repo.GetMusteri();

            foreach (var musteri in musteriler)
            {
                var row = dataTable.NewRow();

                row["ID"] = musteri.id;
                row["Ad"] = musteri.ad;
                row["Soyad"] = musteri.soyad;
                row["T.C. No:"] = musteri.tc;
                row["Telefon No:"] = musteri.tel;
                row["Email"] = musteri.email;

                dataTable.Rows.Add(row);
            }

            this.MusteriTablosu.DataSource = dataTable;
        }

        private void ArabaTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            ArabaTablosu = new DataGridView();
            aracEkle = new Button();
            aracDuzenle = new Button();
            aracSil = new Button();
            label1 = new Label();
            label2 = new Label();
            MusteriTablosu = new DataGridView();
            musteriEkle = new Button();
            musteriDuzenle = new Button();
            musteriSil = new Button();
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MusteriTablosu).BeginInit();
            SuspendLayout();
            // 
            // ArabaTablosu
            // 
            ArabaTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArabaTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArabaTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArabaTablosu.Location = new Point(12, 98);
            ArabaTablosu.MultiSelect = false;
            ArabaTablosu.Name = "ArabaTablosu";
            ArabaTablosu.RowHeadersVisible = false;
            ArabaTablosu.RowHeadersWidth = 51;
            ArabaTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArabaTablosu.Size = new Size(722, 191);
            ArabaTablosu.TabIndex = 6;
            // 
            // aracEkle
            // 
            aracEkle.Location = new Point(12, 63);
            aracEkle.Name = "aracEkle";
            aracEkle.Size = new Size(106, 29);
            aracEkle.TabIndex = 7;
            aracEkle.Text = "Araç Ekle";
            aracEkle.UseVisualStyleBackColor = true;
            aracEkle.Click += aracEkle_Click;
            // 
            // aracDuzenle
            // 
            aracDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aracDuzenle.Location = new Point(504, 63);
            aracDuzenle.Name = "aracDuzenle";
            aracDuzenle.Size = new Size(130, 29);
            aracDuzenle.TabIndex = 8;
            aracDuzenle.Text = "Araç Düzenle";
            aracDuzenle.UseVisualStyleBackColor = true;
            aracDuzenle.Click += aracDuzenle_Click;
            // 
            // aracSil
            // 
            aracSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aracSil.Location = new Point(640, 63);
            aracSil.Name = "aracSil";
            aracSil.Size = new Size(94, 29);
            aracSil.TabIndex = 9;
            aracSil.Text = "Araç Sil";
            aracSil.UseVisualStyleBackColor = true;
            aracSil.Click += aracSil_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(709, 51);
            label1.TabIndex = 10;
            label1.Text = "Araç Listesi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(25, 292);
            label2.Name = "label2";
            label2.Size = new Size(709, 64);
            label2.TabIndex = 11;
            label2.Text = "Müşteri Listesi";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // MusteriTablosu
            // 
            MusteriTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MusteriTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MusteriTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MusteriTablosu.Location = new Point(12, 394);
            MusteriTablosu.MultiSelect = false;
            MusteriTablosu.Name = "MusteriTablosu";
            MusteriTablosu.RowHeadersVisible = false;
            MusteriTablosu.RowHeadersWidth = 51;
            MusteriTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MusteriTablosu.Size = new Size(722, 245);
            MusteriTablosu.TabIndex = 12;
            // 
            // musteriEkle
            // 
            musteriEkle.Location = new Point(12, 359);
            musteriEkle.Name = "musteriEkle";
            musteriEkle.Size = new Size(106, 29);
            musteriEkle.TabIndex = 13;
            musteriEkle.Text = "Müşteri Ekle";
            musteriEkle.UseVisualStyleBackColor = true;
            musteriEkle.Click += musteriEkle_Click;
            // 
            // musteriDuzenle
            // 
            musteriDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            musteriDuzenle.Location = new Point(504, 359);
            musteriDuzenle.Name = "musteriDuzenle";
            musteriDuzenle.Size = new Size(130, 29);
            musteriDuzenle.TabIndex = 14;
            musteriDuzenle.Text = "Müşteri Düzenle";
            musteriDuzenle.UseVisualStyleBackColor = true;
            musteriDuzenle.Click += musteriDuzenle_Click;
            // 
            // musteriSil
            // 
            musteriSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            musteriSil.Location = new Point(640, 359);
            musteriSil.Name = "musteriSil";
            musteriSil.Size = new Size(94, 29);
            musteriSil.TabIndex = 15;
            musteriSil.Text = "Müşteri Sil";
            musteriSil.UseVisualStyleBackColor = true;
            musteriSil.Click += musteriSil_Click;
            // 
            // AracListesi
            // 
            ClientSize = new Size(746, 651);
            Controls.Add(musteriSil);
            Controls.Add(musteriDuzenle);
            Controls.Add(musteriEkle);
            Controls.Add(MusteriTablosu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aracSil);
            Controls.Add(aracDuzenle);
            Controls.Add(aracEkle);
            Controls.Add(ArabaTablosu);
            Name = "AracListesi";
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).EndInit();
            ((System.ComponentModel.ISupportInitialize)MusteriTablosu).EndInit();
            ResumeLayout(false);

        }

        private DataGridView ArabaTablosu;
        private Button aracEkle;
        private Button aracDuzenle;
        private Button aracSil;
        private Label label2;
        private DataGridView MusteriTablosu;
        private Button musteriEkle;
        private Button musteriDuzenle;
        private Button musteriSil;
        private Label label1;

        private void aracEkle_Click(object sender, EventArgs e)
        {
            EkleDüzenleForm form = new EkleDüzenleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadArabalar();
            }
        }

        private void aracDuzenle_Click(object sender, EventArgs e)
        {
            if (ArabaTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek bir araç seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(ArabaTablosu.SelectedRows[0].Cells["ID"].Value);
            EkleDüzenleForm form = new EkleDüzenleForm(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadArabalar();
            }
        }

        private void aracSil_Click(object sender, EventArgs e)
        {
            if (ArabaTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir araç seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(ArabaTablosu.SelectedRows[0].Cells["ID"].Value);

            var onay = MessageBox.Show("Bu aracı silmek istediğinize emin misiniz?", "Silme Onayı",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                var repo = new Araba_repo();
                repo.ArabaSil(id);
                ReadArabalar();
            }
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle form = new MusteriEkle();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadMusteri();
            }
        }

        private void musteriDuzenle_Click(object sender, EventArgs e)
        {
            if (MusteriTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek bir müşteri seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(MusteriTablosu.SelectedRows[0].Cells["ID"].Value);
            MusteriEkle form = new MusteriEkle(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadMusteri();
            }
        }

        private void musteriSil_Click(object sender, EventArgs e)
        {
            if (MusteriTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(MusteriTablosu.SelectedRows[0].Cells["ID"].Value);

            var onay = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (onay == DialogResult.Yes)
            {
                var repo = new Musteri_repo();
                repo.MusteriSil(id);
                ReadMusteri();
            }
        }
    }
}
