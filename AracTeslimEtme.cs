using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using araba_kiralama.Repo;

namespace araba_kiralama
{
    public partial class AracTeslimEtme : Form
    {
        public AracTeslimEtme()
        {
            InitializeComponent();
        }

        private void btnDogrulama_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTc.Text) ||
                string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var repo = new Kiralama_repo();
            var kiralama = repo.KiralamaTcPlaka(txtTc.Text, txtPlaka.Text);

            if (kiralama == null)
            {
                MessageBox.Show("Bu TC ve Plaka'ya ait kiralama kaydı bulunamadı.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dateTimePicker2.Value = kiralama.bitisTarihi.Date;
            dateTimePicker1.Value = DateTime.Today;

            DateTime teslimEdilmesiGerekenTarih = kiralama.bitisTarihi.Date;
            DateTime bugunTeslimTarihi = DateTime.Today;

            int gecikmeGunu = (bugunTeslimTarihi - teslimEdilmesiGerekenTarih).Days;

            if (gecikmeGunu <= 0)
            {
                txtCeza.Text = "0 TL (Gecikme yok)";
                MessageBox.Show(
                    $"Müşteri Bilgileri:\n" +
                    $"Ad Soyad: {txtAd.Text} {txtSoyad.Text}\n" +
                    $"TC: {txtTc.Text}\n" +
                    $"Plaka: {txtPlaka.Text}\n\n" +
                    $"Araç zamanında teslim edilmiştir. Gecikme cezası uygulanmayacaktır.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int cezaTutari = gecikmeGunu * 1000;
                txtCeza.Text = $"{cezaTutari} TL";

                MessageBox.Show(
                    $"Müşteri Bilgileri:\n" +
                    $"Ad Soyad: {txtAd.Text} {txtSoyad.Text}\n" +
                    $"TC: {txtTc.Text}\n" +
                    $"Plaka: {txtPlaka.Text}\n\n" +
                    $"Araç zamanında teslim edilmemiştir.Gecikme cezası uygulanacaktır.\n"+
                    $"Teslim Edilmesi Gereken Tarih: {teslimEdilmesiGerekenTarih:dd.MM.yyyy}\n" +
                    $"Teslim Edildiği Tarih: {bugunTeslimTarihi:dd.MM.yyyy}\n" +
                    $"Gecikme Süresi: {gecikmeGunu} gün\n",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


                private void btnTeslim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araç teslim edildi!", "Teslim Başarılı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    
    }
        

         
}