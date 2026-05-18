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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
            ReadMusteriler();
        }

        private void ReadMusteriler()
        {
            try
            {
                DataTable musteriTable = new DataTable();

                musteriTable.Columns.Add("ID");
                musteriTable.Columns.Add("Ad");
                musteriTable.Columns.Add("Soyad");
                musteriTable.Columns.Add("TC");
                musteriTable.Columns.Add("Telefon");
                musteriTable.Columns.Add("E-mail");

                var repo = new Musteri_repo();
                var musteriler = repo.GetMusteri();

                foreach (var musteri in musteriler)
                {
                    var row = musteriTable.NewRow();

                    row["ID"] = musteri.id;
                    row["Ad"] = musteri.ad;
                    row["Soyad"] = musteri.soyad;
                    row["TC"] = musteri.tc;
                    row["Telefon"] = musteri.tel;
                    row["E-mail"] = musteri.email;

                    musteriTable.Rows.Add(row);
                }

                this.musteriTablosu.DataSource = musteriTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void MusteriTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle form = new MusteriEkle();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadMusteriler();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (musteriTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek müşteriyi seçin.");
                return;
            }
            int id = Convert.ToInt32(musteriTablosu.SelectedRows[0].Cells["ID"].Value);
            MusteriEkle form = new MusteriEkle(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadMusteriler();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (musteriTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi seçin.");
                return;
            }
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(musteriTablosu.SelectedRows[0].Cells["ID"].Value);
                var repo = new Musteri_repo();
                repo.MusteriSil(id);
                ReadMusteriler();
            }
        }
    }
}
