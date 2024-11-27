namespace admin
{
    partial class ogrenciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciForm));
            ogrenci_isim = new TextBox();
            ogrenci_soyad = new TextBox();
            ogrenci_id = new TextBox();
            dataGridViewyoklama = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTitle = new Label();
            öğrenci_isim_label = new Label();
            öğrenci_soyad = new Label();
            öğrenci_kimlik = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewyoklama).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // ogrenci_isim
            // 
            ogrenci_isim.Location = new Point(3, 3);
            ogrenci_isim.Name = "ogrenci_isim";
            ogrenci_isim.ReadOnly = true;
            ogrenci_isim.Size = new Size(218, 27);
            ogrenci_isim.TabIndex = 0;
            // 
            // ogrenci_soyad
            // 
            ogrenci_soyad.Location = new Point(3, 3);
            ogrenci_soyad.Name = "ogrenci_soyad";
            ogrenci_soyad.ReadOnly = true;
            ogrenci_soyad.Size = new Size(218, 27);
            ogrenci_soyad.TabIndex = 1;
            // 
            // ogrenci_id
            // 
            ogrenci_id.Location = new Point(3, 3);
            ogrenci_id.Name = "ogrenci_id";
            ogrenci_id.ReadOnly = true;
            ogrenci_id.Size = new Size(218, 27);
            ogrenci_id.TabIndex = 2;
            // 
            // dataGridViewyoklama
            // 
            dataGridViewyoklama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewyoklama.Location = new Point(17, 20);
            dataGridViewyoklama.Name = "dataGridViewyoklama";
            dataGridViewyoklama.RowHeadersWidth = 51;
            dataGridViewyoklama.Size = new Size(664, 426);
            dataGridViewyoklama.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 599);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Resource_neconun_resimler.gazi_png;
            pictureBox2.Location = new Point(0, 492);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 87);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource_neconun_resimler.gazi_üniversitesi_logosu;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(199, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 87);
            panel2.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(459, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Öğrenci";
            // 
            // öğrenci_isim_label
            // 
            öğrenci_isim_label.AutoSize = true;
            öğrenci_isim_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            öğrenci_isim_label.Location = new Point(254, 223);
            öğrenci_isim_label.Name = "öğrenci_isim_label";
            öğrenci_isim_label.Size = new Size(122, 25);
            öğrenci_isim_label.TabIndex = 7;
            öğrenci_isim_label.Text = "Öğrenci Adı:";
            // 
            // öğrenci_soyad
            // 
            öğrenci_soyad.AutoSize = true;
            öğrenci_soyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            öğrenci_soyad.Location = new Point(254, 328);
            öğrenci_soyad.Name = "öğrenci_soyad";
            öğrenci_soyad.Size = new Size(152, 25);
            öğrenci_soyad.TabIndex = 8;
            öğrenci_soyad.Text = "Öğrenci Soyadı:";
            // 
            // öğrenci_kimlik
            // 
            öğrenci_kimlik.AutoSize = true;
            öğrenci_kimlik.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            öğrenci_kimlik.Location = new Point(254, 424);
            öğrenci_kimlik.Name = "öğrenci_kimlik";
            öğrenci_kimlik.Size = new Size(148, 25);
            öğrenci_kimlik.TabIndex = 9;
            öğrenci_kimlik.Text = "Öğrenci Kimlik:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(ogrenci_isim);
            panel4.Location = new Point(254, 251);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 34);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(ogrenci_soyad);
            panel5.Location = new Point(254, 356);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 34);
            panel5.TabIndex = 34;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateGray;
            panel6.Controls.Add(ogrenci_id);
            panel6.Location = new Point(254, 465);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 34);
            panel6.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(821, 90);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 41;
            label6.Text = "Veriler:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkSlateGray;
            panel7.Controls.Add(dataGridViewyoklama);
            panel7.Location = new Point(518, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(696, 462);
            panel7.TabIndex = 53;
            // 
            // ogrenciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 599);
            Controls.Add(panel7);
            Controls.Add(label6);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(öğrenci_kimlik);
            Controls.Add(öğrenci_soyad);
            Controls.Add(öğrenci_isim_label);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrenciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            FormClosing += ogrenciForm_FormClosing;
            Load += ogrenciForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewyoklama).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ogrenci_isim;
        private TextBox ogrenci_soyad;
        private TextBox ogrenci_id;
        private DataGridView dataGridViewyoklama;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblTitle;
        private Label öğrenci_isim_label;
        private Label öğrenci_soyad;
        private Label öğrenci_kimlik;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
    }
}