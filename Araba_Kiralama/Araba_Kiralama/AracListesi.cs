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
        }

        private void ReadArabalar()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Plaka");
            dataTable.Columns.Add("Tür");
            dataTable.Columns.Add("Marka");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("Yıl");

            var repo = new Araba_repo();
            var arabalar = repo.GetAraba();

            foreach (var araba in arabalar)
            {
                var row = dataTable.NewRow();

                row["ID"] = araba.id;
                row["Plaka"] = araba.plaka;
                row["Tür"] = araba.turu;
                row["Marka"] = araba.marka;
                row["Model"] = araba.modeli;
                row["Yıl"] = araba.yil;

                dataTable.Rows.Add(row);
            }

            this.ArabaTablosu.DataSource = dataTable;
        }

        private void ArabaTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            ArabaTablosu = new DataGridView();
            button_1 = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).BeginInit();
            SuspendLayout();
            // 
            // ArabaTablosu
            // 
            ArabaTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArabaTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArabaTablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArabaTablosu.Location = new Point(12, 149);
            ArabaTablosu.MultiSelect = false;
            ArabaTablosu.Name = "ArabaTablosu";
            ArabaTablosu.RowHeadersVisible = false;
            ArabaTablosu.RowHeadersWidth = 51;
            ArabaTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArabaTablosu.Size = new Size(722, 490);
            ArabaTablosu.TabIndex = 6;
            // 
            // button_1
            // 
            button_1.Location = new Point(12, 96);
            button_1.Name = "button_1";
            button_1.Size = new Size(94, 29);
            button_1.TabIndex = 7;
            button_1.Text = "Araç Ekle";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDuzenle.Location = new Point(511, 96);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(123, 29);
            btnDuzenle.TabIndex = 8;
            btnDuzenle.Text = "Araç Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSil.Location = new Point(640, 96);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "Araç Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(709, 64);
            label1.TabIndex = 10;
            label1.Text = "Araç Listesi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AracListesi
            // 
            ClientSize = new Size(746, 651);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(button_1);
            Controls.Add(ArabaTablosu);
            Name = "AracListesi";
            ((System.ComponentModel.ISupportInitialize)ArabaTablosu).EndInit();
            ResumeLayout(false);

        }

        private DataGridView ArabaTablosu;
        private Button button_1;
        private Button btnDuzenle;
        private Button btnSil;
        private Label label1;

        private void button_1_Click(object sender, EventArgs e)
        {
            EkleDüzenleForm form = new EkleDüzenleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadArabalar();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (ArabaTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek bir araç seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(ArabaTablosu.SelectedRows[0].Cells["ID"].Value);
            EkleDüzenleForm form = new EkleDüzenleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadArabalar();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
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
    }
}
