using araba_kiralama.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class AracTeslimEtme : Form
    {
        private string _tcNo;
        private string _plaka;
        public AracTeslimEtme(string tcNo, string plakaNo)
        {
            InitializeComponent();
            _tcNo = tcNo;
            _plaka = plakaNo;
            ReadKira1(tcNo, plakaNo);
            CezaHesapla(plakaNo);
            lblBugun.Text = DateTime.Now.ToShortDateString();
        }

        public void ReadKira1(string tcNo, string plakaNo)
        {
            var repo = new Kiralama_repo();
            var (isim, model, marka) = repo.GetKiralamaDetay(tcNo, plakaNo);
            string tarih = repo.GetTarih(plakaNo);

            lblTeslimGunu.Text = tarih;
            lblMusteriAdi.Text = isim;
            lblAracAdi.Text = marka + model;
        }

        private void CezaHesapla(string plakaNo)
        {
            var repo = new Kiralama_repo();
            string tarih = repo.GetTarih(plakaNo);
            DateTime sonGun = Convert.ToDateTime(tarih);

            var arabaRepo = new Araba_repo();
            int gunlukUcret = arabaRepo.GetGunlukUcret(plakaNo);

            TimeSpan gunFarki = DateTime.Now - sonGun;

            if (gunFarki.Days > 0)
            {
                lblGecikme.BackColor = Color.Red;
                int ceza = gunFarki.Days * gunlukUcret;
                lblGecikme.Text = "Geciktiniz !\n" +
                                  "Cezanız: " + ceza + "TL";
            }
            else
            {
                lblGecikme.BackColor = Color.LimeGreen;
                lblGecikme.Text = "Gecikme Yok !";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new Kiralama_repo();
            repo.KiraSil(_tcNo, _plaka);
            var arabarepo = new Araba_repo();
            arabarepo.SetKirada(_plaka);

            MessageBox.Show("Araç başarıyla teslim alındı!");
            this.DialogResult = DialogResult.OK;
        }

        private void lblMusteriAdi_Click(object sender, EventArgs e)
        {

        }
    }
}