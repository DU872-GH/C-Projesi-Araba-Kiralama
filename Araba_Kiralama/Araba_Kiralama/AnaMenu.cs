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

        private void button1_Click(object sender, EventArgs e)
        {
            btnArabaEkle form = new btnArabaEkle();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriListesi form = new MusteriListesi();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracKirala form = new AracKirala();
            form.Show();
        }
    }
}
