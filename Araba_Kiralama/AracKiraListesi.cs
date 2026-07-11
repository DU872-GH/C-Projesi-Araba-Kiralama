using araba_kiralama.Modüller;
using araba_kiralama.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace araba_kiralama
{
    public partial class AracKiraListesi : Form
    {
        private string _tc;

        private Dictionary<Button, bool> _filtreDurumu = new Dictionary<Button, bool>();

        public AracKiraListesi(string tcNo)
        {
            InitializeComponent();
            _tc = tcNo;

            cmbSirala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSirala.SelectedIndexChanged += cmbSirala_SelectedIndexChanged;

            cmbSirala.Items.Add("Fiyat (Artan)");
            cmbSirala.Items.Add("Fiyat (Azalan)");
            cmbSirala.Items.Add("Yıl (Yeni-Eski)");
            cmbSirala.Items.Add("Km (Düşük-Yüksek)");

            _filtreDurumu[lblFiltreManuel] = false;
            _filtreDurumu[lblFiltreOtomatik] = false;
            _filtreDurumu[lblFiltreUcuz] = false;
            _filtreDurumu[lblFiltreElektrikli] = false;
            _filtreDurumu[lblFiltreMusait] = false;

            LoadAraclar();
        }

        private void Filtre_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || !_filtreDurumu.ContainsKey(btn)) return;

            _filtreDurumu[btn] = !_filtreDurumu[btn];
            btn.ForeColor = _filtreDurumu[btn] ? Color.Gray : Color.Black;

            LoadAraclar();
        }

        private void cmbSirala_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAraclar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KiralananAraclar form = new KiralananAraclar(_tc);
            form.Show();
        }

        private void LoadAraclar()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            var repo = new Araba_repo();
            var arabalar = repo.GetAraba();

            if (_filtreDurumu[lblFiltreManuel]) arabalar = arabalar.Where(a => a.vites == "Manuel").ToList();
            if (_filtreDurumu[lblFiltreOtomatik]) arabalar = arabalar.Where(a => a.vites == "Otomatik").ToList();
            if (_filtreDurumu[lblFiltreElektrikli]) arabalar = arabalar.Where(a => a.turu == "Elektrikli").ToList();
            if (_filtreDurumu[lblFiltreMusait]) arabalar = arabalar.Where(a => !a.kirada).ToList();
            if (_filtreDurumu[lblFiltreUcuz]) arabalar = arabalar.OrderBy(a => a.gunlukUcret).ToList();

            switch (cmbSirala.SelectedItem?.ToString())
            {
                case "Fiyat (Artan)":
                    arabalar = arabalar.OrderBy(a => a.gunlukUcret).ToList();
                    break;
                case "Fiyat (Azalan)":
                    arabalar = arabalar.OrderByDescending(a => a.gunlukUcret).ToList();
                    break;
                case "Yıl (Yeni-Eski)":
                    arabalar = arabalar.OrderByDescending(a => a.yil).ToList();
                    break;
                case "Km (Düşük-Yüksek)":
                    arabalar = arabalar.OrderBy(a => a.km).ToList();
                    break;
            }

            foreach (var araba in arabalar)
            {
                Panel card = new Panel();
                card.Size = new Size(flowLayoutPanel1.Width - 25, 80);

                if (araba.kirada)
                {
                    card.BackColor = Color.Gray;
                    card.Cursor = Cursors.No;
                }
                else
                {
                    card.BackColor = Color.White;
                    card.Cursor = Cursors.Hand;
                }
                card.Margin = new Padding(5);

                Label lbl = new Label();
                lbl.Text = $"{araba.marka} {araba.modeli} - {araba.plaka}\n" +
                           $"{araba.turu} | {araba.vites} | {araba.yil} | {araba.km} km\n" +
                           $"Günlük: {araba.gunlukUcret}₺  |  " +
                           (araba.kirada ? "Kirada" : "Müsait");
                lbl.Dock = DockStyle.Fill;
                lbl.Padding = new Padding(10);
                lbl.Font = new Font("Segoe UI", 9);

                if (!araba.kirada)
                {
                    card.Click += (s, e) => AracDetayAc(araba);
                    lbl.Click += (s, e) => AracDetayAc(araba);
                }

                card.Controls.Add(lbl);
                Panel border = new Panel();
                border.Size = new Size(flowLayoutPanel1.Width - 25, 82);
                border.BackColor = Color.Black;
                border.Margin = new Padding(5);
                border.Padding = new Padding(1);

                card.Size = new Size(border.Width - 2, border.Height - 2);
                card.Location = new Point(1, 1);

                border.Controls.Add(card);
                flowLayoutPanel1.Controls.Add(border);
            }
        }

        private void AracDetayAc(Arabalar araba)
        {
            AracDetay form = new AracDetay(araba, _tc);
            form.Show();
        }

        private void lblFiltreManuel_Click(object sender, EventArgs e)
        {

        }

        private void lblFiltreOtomatik_Click(object sender, EventArgs e)
        {

        }

        private void lblFiltreUcuz_Click(object sender, EventArgs e)
        {

        }

        private void lblFiltreElektrikli_Click(object sender, EventArgs e)
        {

        }

        private void lblFiltreMusait_Click(object sender, EventArgs e)
        {

        }
    }
}