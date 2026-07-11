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
    public partial class AracDetay : Form
    {
        private int _GunlukUcret;
        private int _ucret;
        private int _ekstraUcret1;
        private int _id;
        private string _tc;
        private Arabalar _araba;

        public AracDetay(Arabalar araba, string tc)
        {
            InitializeComponent();
            ReadArac(araba);
            _GunlukUcret = araba.gunlukUcret;
            _tc = tc;
            _araba = araba;
        }

        public void ReadArac(Arabalar araba)
        {
            lblAracIsmi.Text = araba.marka + " " + araba.modeli;
            lblPlaka.Text = "Plaka: " + araba.plaka;
            lblTur.Text = "Türü: " + araba.turu;
            lblVites.Text = "Vites: " + araba.vites;
            lblYil.Text = "Üretim yılı: " + Convert.ToString(araba.yil);
            lblKm.Text = "Kilometre: " + Convert.ToString(araba.km);
            lblUcretGunluk.Text = "Günlük ücreti: " + Convert.ToString(araba.gunlukUcret);

            checkedListBox1.Items.Add("Bebek Koltuğu - 800TL");
            checkedListBox1.Items.Add("Yol Sigortası - 2000TL");
            checkedListBox1.Items.Add("Kar Lastiği - 1500TL");
            checkedListBox1.Items.Add("GPS - 600TL");
        }

        public int UcretHesapla(int gunlukUcret)
        {
            int ekstraUcret = 0;
            if (checkedListBox1.CheckedItems.Contains("Bebek Koltuğu - 800TL")) ekstraUcret += 800;
            if (checkedListBox1.CheckedItems.Contains("Yol Sigortası - 2000TL")) ekstraUcret += 2000;
            if (checkedListBox1.CheckedItems.Contains("Kar Lastiği - 1500TL")) ekstraUcret += 1500;
            if (checkedListBox1.CheckedItems.Contains("GPS - 600TL")) ekstraUcret += 600;
            _ekstraUcret1 = ekstraUcret;

            DateTime ilkGun = tpAlmaGunu.Value;
            DateTime sonGun = tpTeslimGunu.Value;
            TimeSpan sure = sonGun - ilkGun;
            int gunSayisi = sure.Days + 1;
            if (gunSayisi <= 0)
            {
                MessageBox.Show("Hata: Teslim etme gününüz teslim alma gününüzden sonra olmalıdır", "Kullanıcı hatası");
                return 0;
            }
            int toplamUcret = (gunSayisi * gunlukUcret) + ekstraUcret;

            return toplamUcret;
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            _ucret = UcretHesapla(_GunlukUcret);
            int gun = (_ucret - _ekstraUcret1) / _GunlukUcret;
            if (_ucret == 0)
            {
                btnKirala.Text = "Fiyat";
            }
            else
            {
                btnKirala.Text = gun.ToString() + " günlük fiyat: " + _ucret.ToString();
            }

        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            if (btnKirala.Text == "Fiyat")
            {
                MessageBox.Show("Hata: Önce fiyat hesaplayınız", "Kullanıcı hatası");
            }
            else
            {
                AracKirala(_tc);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AracKirala(string tc)
        {
            DateTime ilkGun = tpAlmaGunu.Value;
            DateTime sonGun = tpTeslimGunu.Value;

            Kiralama kira = new Kiralama();

            kira.id = _id;
            kira.plaka = _araba.plaka;
            kira.musteriTc = tc;
            kira.baslangicTarihi = ilkGun;
            kira.bitisTarihi = sonGun;

            var repo = new Kiralama_repo();
            repo.KiraEkle(kira);

            var repo1 = new Araba_repo();
            repo1.SetKirada2(_araba.plaka);
        }
    }
}