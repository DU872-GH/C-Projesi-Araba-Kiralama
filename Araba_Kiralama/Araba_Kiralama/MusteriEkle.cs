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
    public partial class MusteriEkle : Form
    {
        private int _musteriId = 0;
        public MusteriEkle()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            lbBaslık.Text = "Müşteri Düzenle";
        }
        public MusteriEkle(int id)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            _musteriId = id;
            lbBaslık.Text = "Müşteri Düzenle";

            var repo = new Musteri_repo();
            var musteri = repo.GetMusteri(id);
            if (musteri != null)
            {
                musAD.Text = musteri.ad;
                musSoyad.Text = musteri.soyad;
                musTc.Text = musteri.tc;
                musTel.Text = musteri.tel;
                musEmail.Text = musteri.email;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(musAD.Text) ||
                string.IsNullOrWhiteSpace(musSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(musTc.Text))
            {
                var repo = new Musteri_repo();
                if (repo.TcKontrol(musTc.Text, _musteriId))
                {
                    MessageBox.Show("Bu TC numarası zaten kayıtlı!");
                    musTc.Focus();
                    return;
                }
            }
            try
            {
                Musteriler musteriler1 = new Musteriler();
                musteriler1.id = _musteriId;
                musteriler1.ad = this.musAD.Text;
                musteriler1.soyad = this.musSoyad.Text;
                musteriler1.tc = this.musTc.Text;
                musteriler1.tel = this.musTel.Text;
                musteriler1.email = this.musEmail.Text;

                var repo = new Musteri_repo();
                if (_musteriId == 0)
                    repo.MusteriEkle(musteriler1);
                else
                    repo.UpdateMusteri(musteriler1);

                MessageBox.Show("Kayıt başarılı!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
