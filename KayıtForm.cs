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
            long tcNo = long.Parse(tcNoBox.Text);
            string ad = adBox.Text;
            string soyad = soyadBox.Text;
            long telNo = long.Parse(telNoBox.Text);
            string eMail = mailBox.Text;

            if (tcNoBox.Text == "") {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", caption: "Uyarı", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            else if (adBox.Text == "")
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", caption: "Uyarı", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            else if (soyadBox.Text == "")
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", caption: "Uyarı", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            else if (telNoBox.Text == "")
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", caption: "Uyarı", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            else if (mailBox.Text == "")
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", caption: "Uyarı", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Kayıt başarılı bir şekilde tamamlandı!", caption: "Bilgi", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                this.Close();
                GirisForm girisForm = new GirisForm();
                girisForm.Show();
            }
        }
    }
}
