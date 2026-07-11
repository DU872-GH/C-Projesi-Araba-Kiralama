using araba_kiralama.Modüller;
using araba_kiralama.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

// Araçların label'ı ve textbox'u şifrenin label ve texbox'unun altında

namespace araba_kiralama
{
    public partial class GirisKayit : Form
    {
        private string _sifre = "123";
        private int _id = 0;
        public GirisKayit(bool login)
        {
            InitializeComponent();
            InitializePage(login);
        }

        public void InitializePage(bool login)
        {
            Control[] kayitOnlyControls = { lblAd, tbAd, lblSoyad, tbSoyad, lblTel, tbTel, lblMail, tbMail };

            foreach (var control in kayitOnlyControls)
            {
                control.Visible = !login;
            }

            if (login)
            {
                lblGiris.Text = "Giriş";
            }
            else
            {
                lblGiris.Text = "Kayıt";
            }

            lblSifre.Hide();
            tbSifre.Hide();

        }

        private void linkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InitializePage(false);
        }

        private void linkYonetici_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InitializePage(true);
            lblSifre.Show();
            tbSifre.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(!lblTel.Visible && !lblSifre.Visible) // Giriş
            {
                string TC = tbTC.Text;

                var repo = new Musteri_repo();
                var musteri = repo.GetMusteriTc(TC);

                if (musteri == null)
                {
                    MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AracKiraListesi form = new AracKiraListesi(TC);
                form.Show();
            }
            else if (!lblTel.Visible && lblSifre.Visible) // Yönetici Girişi
            {
                string TC = tbTC.Text;

                var repo = new Musteri_repo();
                var musteri = repo.GetMusteriTc(TC);

                if (musteri == null)
                {
                    MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbSifre.Text))
                {
                    MessageBox.Show("Şifre giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbSifre.Text == _sifre)
                {
                    AracListesi form = new AracListesi();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış şifre girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lblTel.Visible && !lblSifre.Visible) // Kayıt
            {   
                KayitEkle();
            }
        }

        private void KayitEkle()
        {
            if (string.IsNullOrWhiteSpace(tbTC.Text) ||
                string.IsNullOrWhiteSpace(tbAd.Text) ||
                string.IsNullOrWhiteSpace(tbSoyad.Text) ||
                string.IsNullOrWhiteSpace(tbTel.Text) ||
                string.IsNullOrWhiteSpace(tbMail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var repo = new Musteri_repo();
            if (repo.TcKontrol(tbTC.Text))
            {

                MessageBox.Show("Bu TC numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Musteriler musteri = new Musteriler();
            musteri.id = _id;
            musteri.ad = tbAd.Text;
            musteri.soyad = tbSoyad.Text;
            musteri.tc = tbTC.Text;
            musteri.tel = tbTel.Text;
            musteri.email = tbMail.Text;
             
            repo.MusteriEkle(musteri);

            MessageBox.Show("Kayıt başarılı!");
            this.DialogResult = DialogResult.OK;
        }
    }
}
