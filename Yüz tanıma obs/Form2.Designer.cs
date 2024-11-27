namespace yoklamadenemesistem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panelMenu = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ogretmenManageBut = new Button();
            ogrenciManagebut = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            anasayfaGaziResim = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anasayfaGaziResim).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(ogretmenManageBut);
            panelMenu.Controls.Add(ogrenciManagebut);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 599);
            panelMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = admin.Resource_neconun_resimler.gazi_png;
            pictureBox2.Location = new Point(0, 492);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 200);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(220, 60);
            button1.TabIndex = 3;
            button1.Text = "Ders Yönetimi";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ogretmenManageBut
            // 
            ogretmenManageBut.Dock = DockStyle.Top;
            ogretmenManageBut.FlatAppearance.BorderSize = 0;
            ogretmenManageBut.FlatStyle = FlatStyle.Flat;
            ogretmenManageBut.ForeColor = Color.White;
            ogretmenManageBut.Image = (Image)resources.GetObject("ogretmenManageBut.Image");
            ogretmenManageBut.ImageAlign = ContentAlignment.MiddleLeft;
            ogretmenManageBut.Location = new Point(0, 140);
            ogretmenManageBut.Name = "ogretmenManageBut";
            ogretmenManageBut.Padding = new Padding(12, 0, 0, 0);
            ogretmenManageBut.Size = new Size(220, 60);
            ogretmenManageBut.TabIndex = 2;
            ogretmenManageBut.Text = "Öğretmen Yönetimi";
            ogretmenManageBut.TextImageRelation = TextImageRelation.ImageBeforeText;
            ogretmenManageBut.UseVisualStyleBackColor = true;
            ogretmenManageBut.Click += ogretmenManageBut_Click;
            // 
            // ogrenciManagebut
            // 
            ogrenciManagebut.Dock = DockStyle.Top;
            ogrenciManagebut.FlatAppearance.BorderSize = 0;
            ogrenciManagebut.FlatStyle = FlatStyle.Flat;
            ogrenciManagebut.ForeColor = Color.White;
            ogrenciManagebut.Image = (Image)resources.GetObject("ogrenciManagebut.Image");
            ogrenciManagebut.ImageAlign = ContentAlignment.MiddleLeft;
            ogrenciManagebut.Location = new Point(0, 80);
            ogrenciManagebut.Name = "ogrenciManagebut";
            ogrenciManagebut.Padding = new Padding(12, 0, 0, 0);
            ogrenciManagebut.Size = new Size(220, 60);
            ogrenciManagebut.TabIndex = 1;
            ogrenciManagebut.Text = "Öğrenci Yönetimi";
            ogrenciManagebut.TextImageRelation = TextImageRelation.ImageBeforeText;
            ogrenciManagebut.UseVisualStyleBackColor = true;
            ogrenciManagebut.Click += ogrenciManagebut_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.DarkSlateGray;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1006, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(409, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ana Sayfa";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.AutoSize = true;
            panelDesktopPane.Controls.Add(anasayfaGaziResim);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1006, 519);
            panelDesktopPane.TabIndex = 2;
            // 
            // anasayfaGaziResim
            // 
            anasayfaGaziResim.Anchor = AnchorStyles.None;
            anasayfaGaziResim.Image = admin.Resource_neconun_resimler.gazi_png;
            anasayfaGaziResim.Location = new Point(0, 0);
            anasayfaGaziResim.Name = "anasayfaGaziResim";
            anasayfaGaziResim.Size = new Size(1006, 519);
            anasayfaGaziResim.SizeMode = PictureBoxSizeMode.StretchImage;
            anasayfaGaziResim.TabIndex = 5;
            anasayfaGaziResim.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1226, 599);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)anasayfaGaziResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button ogrenciManagebut;
        private Panel panelLogo;
        private Button ogretmenManageBut;
        private Panel panelTitleBar;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Panel panelDesktopPane;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox anasayfaGaziResim;
    }
}