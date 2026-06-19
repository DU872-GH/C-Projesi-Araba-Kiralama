using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
        }

        private void girisKayitButton_Click(object sender, EventArgs e)
        {
            string tcNoText = tcNoBox.Text;
            string ad = adBox.Text;
            string soyad = soyadBox.Text;
            string telNoText = telNoBox.Text;
            string eMail = mailBox.Text;

            if (string.IsNullOrWhiteSpace(tcNoText) ||
                string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(soyad) ||
                string.IsNullOrWhiteSpace(telNoText) ||
                string.IsNullOrWhiteSpace(eMail))
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(tcNoText, out long tcNo))
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik Numarası giriniz (Sadece rakam).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(telNoText, out long telNo))
            {
                MessageBox.Show("Lütfen geçerli bir Telefon Numarası giriniz (Sadece rakam).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Kayıt başarılı bir şekilde tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisForm form = new GirisForm();
            form.Show();
            this.Close();
        }
    }
}
