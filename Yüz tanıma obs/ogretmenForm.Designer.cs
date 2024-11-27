namespace admin
{
    partial class ogretmenForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox ogretmen_isim;
        private System.Windows.Forms.TextBox ogretmen_soyad;
        private System.Windows.Forms.TextBox ogretmen_id;
        private System.Windows.Forms.DataGridView dataGridViewogretmen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenForm));
            ogretmen_isim = new TextBox();
            ogretmen_soyad = new TextBox();
            ogretmen_id = new TextBox();
            dataGridViewogretmen = new DataGridView();
            panel7 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ogretmen_soyad_label = new Label();
            ogretmen_id_label = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewogretmen).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // ogretmen_isim
            // 
            ogretmen_isim.Location = new Point(3, 4);
            ogretmen_isim.Name = "ogretmen_isim";
            ogretmen_isim.ReadOnly = true;
            ogretmen_isim.Size = new Size(218, 27);
            ogretmen_isim.TabIndex = 3;
            // 
            // ogretmen_soyad
            // 
            ogretmen_soyad.Location = new Point(3, 3);
            ogretmen_soyad.Name = "ogretmen_soyad";
            ogretmen_soyad.ReadOnly = true;
            ogretmen_soyad.Size = new Size(218, 27);
            ogretmen_soyad.TabIndex = 4;
            // 
            // ogretmen_id
            // 
            ogretmen_id.Location = new Point(3, 4);
            ogretmen_id.Name = "ogretmen_id";
            ogretmen_id.ReadOnly = true;
            ogretmen_id.Size = new Size(218, 27);
            ogretmen_id.TabIndex = 5;
            // 
            // dataGridViewogretmen
            // 
            dataGridViewogretmen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewogretmen.Location = new Point(18, 20);
            dataGridViewogretmen.Name = "dataGridViewogretmen";
            dataGridViewogretmen.RowHeadersWidth = 51;
            dataGridViewogretmen.Size = new Size(703, 414);
            dataGridViewogretmen.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkSlateGray;
            panel7.Controls.Add(dataGridViewogretmen);
            panel7.Location = new Point(474, 137);
            panel7.Name = "panel7";
            panel7.Size = new Size(740, 450);
            panel7.TabIndex = 53;
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
            panel1.TabIndex = 54;
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
            panel2.TabIndex = 55;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(427, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Öğretmen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(237, 231);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 56;
            label1.Text = "Öğretmen Adı:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(ogretmen_isim);
            panel4.Location = new Point(224, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 34);
            panel4.TabIndex = 57;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(ogretmen_soyad);
            panel5.Location = new Point(224, 379);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 34);
            panel5.TabIndex = 58;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateGray;
            panel6.Controls.Add(ogretmen_id);
            panel6.Location = new Point(224, 482);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 34);
            panel6.TabIndex = 59;
            // 
            // ogretmen_soyad_label
            // 
            ogretmen_soyad_label.AutoSize = true;
            ogretmen_soyad_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ogretmen_soyad_label.Location = new Point(237, 351);
            ogretmen_soyad_label.Name = "ogretmen_soyad_label";
            ogretmen_soyad_label.Size = new Size(172, 25);
            ogretmen_soyad_label.TabIndex = 60;
            ogretmen_soyad_label.Text = "Öğretmen Soyadı:";
            // 
            // ogretmen_id_label
            // 
            ogretmen_id_label.AutoSize = true;
            ogretmen_id_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ogretmen_id_label.Location = new Point(237, 454);
            ogretmen_id_label.Name = "ogretmen_id_label";
            ogretmen_id_label.Size = new Size(132, 25);
            ogretmen_id_label.TabIndex = 61;
            ogretmen_id_label.Text = "Öğretmen ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(801, 102);
            label6.Name = "label6";
            label6.Size = new Size(96, 32);
            label6.TabIndex = 62;
            label6.Text = "Veriler:";
            // 
            // ogretmenForm
            // 
            ClientSize = new Size(1226, 599);
            Controls.Add(label6);
            Controls.Add(ogretmen_id_label);
            Controls.Add(ogretmen_soyad_label);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogretmenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            FormClosing += ogretmenForm_FormClosing;
            Load += ogretmenForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewogretmen).EndInit();
            panel7.ResumeLayout(false);
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
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel7;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblTitle;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label ogretmen_soyad_label;
        private Label ogretmen_id_label;
        private Label label6;
    }
}
