using araba_kiralama.Repo;
using Microsoft.Data.SqlClient;
using System.Data;

namespace araba_kiralama
{

    public partial class btnArabaEkle : Form
    {
        public btnArabaEkle()
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
                row["Tür"] = araba.tur;
                row["Marka"] = araba.marka;
                row["Model"] = araba.model;
                row["Yıl"] = araba.yil;

                dataTable.Rows.Add(row);
            }

            this.ArabaTablosu.DataSource = dataTable;
        }

        private void ArabaTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkleDüzenleForm form = new EkleDüzenleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadArabalar();
            }
        }
    }
}
