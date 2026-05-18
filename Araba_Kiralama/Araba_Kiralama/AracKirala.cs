using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class AracKirala : Form
    {
        public AracKirala()
        {
            InitializeComponent();
            dtBas.MinDate = DateTime.Today;
            dtSon.MinDate = DateTime.Today.AddDays(1);
        }
    }
}
