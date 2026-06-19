namespace araba_kiralama
{
    partial class KiralananAraclar
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
            KiraAraclar = new DataGridView();
            btnTeslim = new Button();
            ((System.ComponentModel.ISupportInitialize)KiraAraclar).BeginInit();
            SuspendLayout();
            // 
            // KiraAraclar
            // 
            KiraAraclar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KiraAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KiraAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KiraAraclar.Location = new Point(12, 32);
            KiraAraclar.MultiSelect = false;
            KiraAraclar.Name = "KiraAraclar";
            KiraAraclar.RowHeadersVisible = false;
            KiraAraclar.RowHeadersWidth = 51;
            KiraAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            KiraAraclar.Size = new Size(722, 191);
            KiraAraclar.TabIndex = 7;
            // 
            // btnTeslim
            // 
            btnTeslim.Location = new Point(320, 303);
            btnTeslim.Name = "btnTeslim";
            btnTeslim.Size = new Size(115, 38);
            btnTeslim.TabIndex = 8;
            btnTeslim.Text = "Araç Teslim";
            btnTeslim.UseVisualStyleBackColor = true;
            btnTeslim.Click += btnTeslim_Click;
            // 
            // KiralananAraclar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 443);
            Controls.Add(btnTeslim);
            Controls.Add(KiraAraclar);
            Name = "KiralananAraclar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiraladığınız Araç Listesi";
            ((System.ComponentModel.ISupportInitialize)KiraAraclar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView KiraAraclar;
        private Button btnTeslim;
    }
}