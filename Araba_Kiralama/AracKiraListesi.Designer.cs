namespace araba_kiralama
{
    partial class AracKiraListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKiralar = new Button();
            cmbSirala = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblFiltreManuel = new Button();
            lblFiltreOtomatik = new Button();
            lblFiltreUcuz = new Button();
            lblFiltreElektrikli = new Button();
            lblFiltreMusait = new Button();
            SuspendLayout();
            // 
            // btnKiralar
            // 
            btnKiralar.Location = new Point(653, 50);
            btnKiralar.Name = "btnKiralar";
            btnKiralar.Size = new Size(135, 50);
            btnKiralar.TabIndex = 0;
            btnKiralar.Text = "Kiraladıklarım";
            btnKiralar.UseVisualStyleBackColor = true;
            btnKiralar.Click += button1_Click;
            // 
            // cmbSirala
            // 
            cmbSirala.Location = new Point(637, 154);
            cmbSirala.Name = "cmbSirala";
            cmbSirala.Size = new Size(151, 28);
            cmbSirala.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 188);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 421);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // lblFiltreManuel
            // 
            lblFiltreManuel.Location = new Point(12, 153);
            lblFiltreManuel.Name = "lblFiltreManuel";
            lblFiltreManuel.Size = new Size(94, 29);
            lblFiltreManuel.TabIndex = 3;
            lblFiltreManuel.Text = "Manuel";
            lblFiltreManuel.UseVisualStyleBackColor = true;
            lblFiltreManuel.Click += lblFiltreManuel_Click;
            lblFiltreManuel.Click += Filtre_Click;
            // 
            // lblFiltreOtomatik
            // 
            lblFiltreOtomatik.Location = new Point(112, 153);
            lblFiltreOtomatik.Name = "lblFiltreOtomatik";
            lblFiltreOtomatik.Size = new Size(94, 29);
            lblFiltreOtomatik.TabIndex = 4;
            lblFiltreOtomatik.Text = "Otomatik";
            lblFiltreOtomatik.UseVisualStyleBackColor = true;
            lblFiltreOtomatik.Click += lblFiltreOtomatik_Click;
            lblFiltreOtomatik.Click += Filtre_Click;
            // 
            // lblFiltreUcuz
            // 
            lblFiltreUcuz.Location = new Point(212, 153);
            lblFiltreUcuz.Name = "lblFiltreUcuz";
            lblFiltreUcuz.Size = new Size(94, 29);
            lblFiltreUcuz.TabIndex = 5;
            lblFiltreUcuz.Text = "Ucuz";
            lblFiltreUcuz.UseVisualStyleBackColor = true;
            lblFiltreUcuz.Click += lblFiltreUcuz_Click;
            lblFiltreUcuz.Click += Filtre_Click;
            // 
            // lblFiltreElektrikli
            // 
            lblFiltreElektrikli.Location = new Point(312, 154);
            lblFiltreElektrikli.Name = "lblFiltreElektrikli";
            lblFiltreElektrikli.Size = new Size(94, 29);
            lblFiltreElektrikli.TabIndex = 6;
            lblFiltreElektrikli.Text = "Elektrikli";
            lblFiltreElektrikli.UseVisualStyleBackColor = true;
            lblFiltreElektrikli.Click += lblFiltreElektrikli_Click;
            lblFiltreElektrikli.Click += Filtre_Click;
            // 
            // lblFiltreMusait
            // 
            lblFiltreMusait.Location = new Point(412, 153);
            lblFiltreMusait.Name = "lblFiltreMusait";
            lblFiltreMusait.Size = new Size(94, 29);
            lblFiltreMusait.TabIndex = 7;
            lblFiltreMusait.Text = "Müsait";
            lblFiltreMusait.UseVisualStyleBackColor = true;
            lblFiltreMusait.Click += lblFiltreMusait_Click;
            lblFiltreMusait.Click += Filtre_Click;
            // 
            // AracKiraListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(lblFiltreMusait);
            Controls.Add(lblFiltreElektrikli);
            Controls.Add(lblFiltreUcuz);
            Controls.Add(lblFiltreOtomatik);
            Controls.Add(lblFiltreManuel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cmbSirala);
            Controls.Add(btnKiralar);
            Name = "AracKiraListesi";
            Text = "AracKiralama";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKiralar;
        private ComboBox cmbSirala;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button lblFiltreManuel;
        private Button lblFiltreOtomatik;
        private Button lblFiltreUcuz;
        private Button lblFiltreElektrikli;
        private Button lblFiltreMusait;
    }
}