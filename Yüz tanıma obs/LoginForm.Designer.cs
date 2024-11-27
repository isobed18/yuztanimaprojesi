namespace admin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            girisYapButonu = new Button();
            sifreTextBox = new TextBox();
            idTextBox = new TextBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 508);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 356);
            label2.Name = "label2";
            label2.Size = new Size(273, 28);
            label2.TabIndex = 2;
            label2.Text = "ÖĞRENCİ BİLGİ SİSTEMİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 307);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 1;
            label1.Text = "GAZİ ÜNİVERSİTESİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(girisYapButonu);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(296, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 508);
            panel2.TabIndex = 1;
            // 
            // girisYapButonu
            // 
            girisYapButonu.BackColor = Color.DarkSlateGray;
            girisYapButonu.Cursor = Cursors.Hand;
            girisYapButonu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            girisYapButonu.ForeColor = Color.White;
            girisYapButonu.Location = new Point(84, 382);
            girisYapButonu.Name = "girisYapButonu";
            girisYapButonu.Size = new Size(266, 65);
            girisYapButonu.TabIndex = 3;
            girisYapButonu.Text = "Giriş Yap";
            girisYapButonu.UseVisualStyleBackColor = false;
            girisYapButonu.Click += girisYapButonu_Click;
            // 
            // sifreTextBox
            // 
            sifreTextBox.BorderStyle = BorderStyle.None;
            sifreTextBox.Location = new Point(41, 8);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.PasswordChar = '*';
            sifreTextBox.Size = new Size(380, 20);
            sifreTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.None;
            idTextBox.Location = new Point(44, 8);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(378, 20);
            idTextBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 13.8F);
            comboBox1.ForeColor = Color.DarkSlateGray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Yönetici", "Öğretmen", "Öğrenci" });
            comboBox1.Location = new Point(84, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 37);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Giriş Yöntemi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(idTextBox);
            panel3.Location = new Point(0, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(433, 40);
            panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.account;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(sifreTextBox);
            panel4.Location = new Point(0, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(434, 40);
            panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._928417_access_lock_password_protect_safety_icon;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label3.Location = new Point(6, 172);
            label3.Name = "label3";
            label3.Size = new Size(121, 22);
            label3.TabIndex = 7;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label4.Location = new Point(6, 273);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 8;
            label4.Text = "Şifre";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 508);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox sifreTextBox;
        private TextBox idTextBox;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button girisYapButonu;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox3;
    }
}