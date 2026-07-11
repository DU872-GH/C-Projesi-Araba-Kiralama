using araba_kiralama.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class KiralananAraclar : Form
    {
        private string _tc;
        public KiralananAraclar(string tcNo)
        {
            InitializeComponent();
            ReadKiralamalar();
            _tc = tcNo;
        }

        private void ReadKiralamalar()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Plaka");
            dataTable.Columns.Add("T.C.");
            dataTable.Columns.Add("Kiralama Günü");
            dataTable.Columns.Add("Teslim Günü");

            var repo = new Kiralama_repo();
            var kiralamalar = repo.GetKiraTC(_tc);

            foreach (var kira in kiralamalar)
            {
                var row = dataTable.NewRow();

                row["ID"] = kira.id;
                row["Plaka"] = kira.plaka;
                row["T.C."] = kira.musteriTc;
                row["Kiralama Günü"] = kira.baslangicTarihi;
                row["Teslim Günü"] = kira.bitisTarihi;

                dataTable.Rows.Add(row);
            }

            this.KiraAraclar.DataSource = dataTable;
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (KiraAraclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek bir kira seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string plakaNo = Convert.ToString(KiraAraclar.SelectedRows[0].Cells["Plaka"].Value);
            string tcNo = Convert.ToString(KiraAraclar.SelectedRows[0].Cells["T.C."].Value);

            if (!string.IsNullOrEmpty(plakaNo) && !string.IsNullOrEmpty(tcNo))
            {
                AracTeslimEtme form = new AracTeslimEtme(tcNo, plakaNo);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ReadKiralamalar();
                }
            }
        }
    }
}
