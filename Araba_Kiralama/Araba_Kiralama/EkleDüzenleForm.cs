using araba_kiralama.Modüller;
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
    public partial class EkleDüzenleForm : Form
    {
        private int _id = 0;

        public EkleDüzenleForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
            this.Text = "Araç Ekle";
        }

        public EkleDüzenleForm(int id)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            this.Text = "Araç Düzenle";
            _id = id;

            var repo = new Araba_repo();
            var araba = repo.GetAraba(id);

            if (araba != null)
            {
                tbPlaka.Text = araba.plaka;
                tbTur.Text   = araba.turu;
                tbMarka.Text = araba.marka;
                tbModel.Text = araba.modeli;
                tbVites.Text = araba.vites;
                tbYıl.Text   = araba.yil.ToString();
                tbKm.Text    = araba.km.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPlaka.Text) ||
                string.IsNullOrWhiteSpace(tbTur.Text) ||
                string.IsNullOrWhiteSpace(tbMarka.Text) ||
                string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbVites.Text) ||
                string.IsNullOrWhiteSpace(tbYıl.Text) ||
                string.IsNullOrWhiteSpace(tbKm.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Arabalar arabalar1 = new Arabalar();
            arabalar1.id = _id;
            arabalar1.plaka = tbPlaka.Text;
            arabalar1.turu = tbTur.Text;
            arabalar1.marka = tbMarka.Text;
            arabalar1.modeli = tbModel.Text;
            arabalar1.vites = tbVites.Text;
            arabalar1.yil = Convert.ToInt32(tbYıl.Text);
            arabalar1.km = Convert.ToInt32(tbKm.Text);

            var repo = new Araba_repo();

            if (_id == 0)
                repo.ArabaEkle(arabalar1);
            else
                repo.UpdateAraba(arabalar1);

            this.DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EkleDüzenleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
