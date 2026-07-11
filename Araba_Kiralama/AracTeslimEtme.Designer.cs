namespace araba_kiralama
{
    partial class AracTeslimEtme
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
            lblAracAdi = new Label();
            lblMusteriAdi = new Label();
            lblTeslimGunu = new Label();
            lblBugun = new Label();
            button1 = new Button();
            lblGecikme = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblAracAdi
            // 
            lblAracAdi.Font = new Font("Segoe UI", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 162);
            lblAracAdi.Location = new Point(12, 9);
            lblAracAdi.Name = "lblAracAdi";
            lblAracAdi.Size = new Size(309, 70);
            lblAracAdi.TabIndex = 0;
            lblAracAdi.Text = "Araba Markası, Modeli";
            lblAracAdi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 162);
            lblMusteriAdi.Location = new Point(12, 79);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new Size(236, 61);
            lblMusteriAdi.TabIndex = 1;
            lblMusteriAdi.Text = "Müşeri Ad, Soyadı";
            lblMusteriAdi.TextAlign = ContentAlignment.MiddleLeft;
            lblMusteriAdi.Click += lblMusteriAdi_Click;
            // 
            // lblTeslimGunu
            // 
            lblTeslimGunu.BorderStyle = BorderStyle.FixedSingle;
            lblTeslimGunu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTeslimGunu.Location = new Point(16, 232);
            lblTeslimGunu.Name = "lblTeslimGunu";
            lblTeslimGunu.Size = new Size(165, 46);
            lblTeslimGunu.TabIndex = 2;
            lblTeslimGunu.Text = "Teslim Günü";
            lblTeslimGunu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBugun
            // 
            lblBugun.BorderStyle = BorderStyle.FixedSingle;
            lblBugun.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBugun.Location = new Point(200, 232);
            lblBugun.Name = "lblBugun";
            lblBugun.Size = new Size(165, 46);
            lblBugun.TabIndex = 3;
            lblBugun.Text = "Bugün";
            lblBugun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(200, 320);
            button1.Name = "button1";
            button1.Size = new Size(165, 46);
            button1.TabIndex = 4;
            button1.Text = "Teslim Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblGecikme
            // 
            lblGecikme.AutoSize = true;
            lblGecikme.BorderStyle = BorderStyle.Fixed3D;
            lblGecikme.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGecikme.Location = new Point(62, 320);
            lblGecikme.Name = "lblGecikme";
            lblGecikme.Size = new Size(65, 30);
            lblGecikme.TabIndex = 5;
            lblGecikme.Text = "label1";
            lblGecikme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(200, 186);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 6;
            label1.Text = "Bugün";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(16, 186);
            label2.Name = "label2";
            label2.Size = new Size(165, 46);
            label2.TabIndex = 7;
            label2.Text = "Teslim Günü";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AracTeslimEtme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGecikme);
            Controls.Add(button1);
            Controls.Add(lblBugun);
            Controls.Add(lblTeslimGunu);
            Controls.Add(lblMusteriAdi);
            Controls.Add(lblAracAdi);
            Name = "AracTeslimEtme";
            Text = "AracTeslimEtme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAracAdi;
        private Label lblMusteriAdi;
        private Label lblTeslimGunu;
        private Label lblBugun;
        private Button button1;
        private Label lblGecikme;
        private Label label1;
        private Label label2;
    }
}