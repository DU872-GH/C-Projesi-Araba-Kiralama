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
        public EkleDüzenleForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Arabalar arabalar1 = new Arabalar();
            arabalar1.id = 0;
            arabalar1.plaka = this.tbPlaka.Text;
            arabalar1.tur = this.tbTur.Text;
            arabalar1.marka = this.tbMarka.Text;
            arabalar1.model = this.tbModel.Text;
            arabalar1.yil = this.tbYıl.Text;

            var repo = new Araba_repo();
            repo.ArabaEkle(arabalar1);

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
