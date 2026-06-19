using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace araba_kiralama
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiPanel form = new YoneticiPanel();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KiralananAraclar form = new KiralananAraclar();
            form.Show();
        }

        private void girisKayitButton_Click(object sender, EventArgs e)
        {
            GirisForm form = new GirisForm();
            form.Show();
        }
    }
}