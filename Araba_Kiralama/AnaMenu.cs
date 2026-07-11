using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GirisKayit form = new GirisKayit(true);
            form.ShowDialog();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            GirisKayit form = new GirisKayit(false);
            form.ShowDialog();
        }

    }
}
