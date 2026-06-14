using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class KiralananAraclar : Form
    {
        public KiralananAraclar()
        {
            InitializeComponent();
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            AracTeslimEtme form = new AracTeslimEtme();
            form.Show();
        }
    }
}
