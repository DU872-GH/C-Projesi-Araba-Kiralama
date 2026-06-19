using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayıtForm form = new KayıtForm();
            form.Show();
            this.Close();
        }

        private void girisKayitButton_Click(object sender, EventArgs e)
        {
            if (tcBox.Text == "admin" && telBox.Text == "admin123")
            {
                MessageBox.Show("Giriş başarılı bir şekilde tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YoneticiPanel form = new YoneticiPanel();
                form.Show();
                this.Close();
            }

            if (tcBox.Text == " " && telBox.Text == " ")
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}