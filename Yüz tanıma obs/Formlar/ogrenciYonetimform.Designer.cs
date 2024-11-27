namespace yoklamadenemesistem.Formlar
{
    partial class ogrenciYonetimform
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciYonetimform));
            tboxName = new TextBox();
            textBox3 = new TextBox();
            ogrenciDuzenleBut = new Button();
            ogrenciKaydetBut = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            dataGridView2 = new DataGridView();
            ogrenciIDtbox = new TextBox();
            panel1 = new Panel();
            ogrenciYoklamaBut = new Button();
            label9 = new Label();
            ogrenciSilBut = new Button();
            tboxSurname = new TextBox();
            panel5 = new Panel();
            passwordTbox = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tboxName
            // 
            tboxName.BackColor = Color.White;
            tboxName.BorderStyle = BorderStyle.FixedSingle;
            tboxName.Cursor = Cursors.Hand;
            tboxName.Location = new Point(119, 115);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(217, 30);
            tboxName.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.Hand;
            textBox3.Location = new Point(119, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 2;
            // 
            // ogrenciDuzenleBut
            // 
            ogrenciDuzenleBut.BackColor = Color.PaleTurquoise;
            ogrenciDuzenleBut.FlatAppearance.BorderColor = Color.White;
            ogrenciDuzenleBut.FlatStyle = FlatStyle.Flat;
            ogrenciDuzenleBut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ogrenciDuzenleBut.Location = new Point(232, 405);
            ogrenciDuzenleBut.Name = "ogrenciDuzenleBut";
            ogrenciDuzenleBut.Size = new Size(125, 53);
            ogrenciDuzenleBut.TabIndex = 7;
            ogrenciDuzenleBut.Text = "Düzenle";
            ogrenciDuzenleBut.UseVisualStyleBackColor = false;
            ogrenciDuzenleBut.Click += ogrenciDuzenleBut_Click;
            // 
            // ogrenciKaydetBut
            // 
            ogrenciKaydetBut.BackColor = Color.DarkSlateGray;
            ogrenciKaydetBut.FlatAppearance.BorderColor = Color.White;
            ogrenciKaydetBut.FlatStyle = FlatStyle.Flat;
            ogrenciKaydetBut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ogrenciKaydetBut.ForeColor = Color.White;
            ogrenciKaydetBut.Location = new Point(101, 405);
            ogrenciKaydetBut.Name = "ogrenciKaydetBut";
            ogrenciKaydetBut.Size = new Size(125, 52);
            ogrenciKaydetBut.TabIndex = 8;
            ogrenciKaydetBut.Text = "Ekle";
            ogrenciKaydetBut.UseVisualStyleBackColor = false;
            ogrenciKaydetBut.Click += ogrenciKaydetBut_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(ogrenciIDtbox);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(ogrenciYoklamaBut);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(ogrenciSilBut);
            panel2.Controls.Add(tboxSurname);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(passwordTbox);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(tboxName);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ogrenciKaydetBut);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ogrenciDuzenleBut);
            panel2.Controls.Add(textBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 599);
            panel2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(697, 32);
            label6.Name = "label6";
            label6.Size = new Size(88, 30);
            label6.TabIndex = 37;
            label6.Text = "Veriler:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(130, 44);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 36;
            label2.Text = "Öğrencileri Yönet";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateGray;
            panel6.Controls.Add(dataGridView2);
            panel6.Location = new Point(396, 65);
            panel6.Name = "panel6";
            panel6.Size = new Size(680, 452);
            panel6.TabIndex = 32;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(19, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(643, 412);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // ogrenciIDtbox
            // 
            ogrenciIDtbox.BackColor = Color.White;
            ogrenciIDtbox.BorderStyle = BorderStyle.FixedSingle;
            ogrenciIDtbox.Cursor = Cursors.Hand;
            ogrenciIDtbox.Location = new Point(119, 337);
            ogrenciIDtbox.Name = "ogrenciIDtbox";
            ogrenciIDtbox.Size = new Size(217, 30);
            ogrenciIDtbox.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(116, 334);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 34);
            panel1.TabIndex = 28;
            // 
            // ogrenciYoklamaBut
            // 
            ogrenciYoklamaBut.BackColor = Color.PaleTurquoise;
            ogrenciYoklamaBut.FlatAppearance.BorderColor = Color.White;
            ogrenciYoklamaBut.FlatStyle = FlatStyle.Flat;
            ogrenciYoklamaBut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ogrenciYoklamaBut.Location = new Point(101, 464);
            ogrenciYoklamaBut.Name = "ogrenciYoklamaBut";
            ogrenciYoklamaBut.Size = new Size(125, 53);
            ogrenciYoklamaBut.TabIndex = 26;
            ogrenciYoklamaBut.Text = "Yoklama";
            ogrenciYoklamaBut.UseVisualStyleBackColor = false;
            ogrenciYoklamaBut.Click += ogrenciYoklamaBut_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(116, 303);
            label9.Name = "label9";
            label9.Size = new Size(106, 23);
            label9.TabIndex = 25;
            label9.Text = "Öğrenci No:";
            // 
            // ogrenciSilBut
            // 
            ogrenciSilBut.BackColor = Color.DarkSlateGray;
            ogrenciSilBut.FlatAppearance.BorderColor = Color.White;
            ogrenciSilBut.FlatStyle = FlatStyle.Flat;
            ogrenciSilBut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ogrenciSilBut.ForeColor = Color.White;
            ogrenciSilBut.Location = new Point(232, 464);
            ogrenciSilBut.Name = "ogrenciSilBut";
            ogrenciSilBut.Size = new Size(125, 52);
            ogrenciSilBut.TabIndex = 22;
            ogrenciSilBut.Text = "Sil";
            ogrenciSilBut.UseVisualStyleBackColor = false;
            ogrenciSilBut.Click += ogrenciSilBut_Click;
            // 
            // tboxSurname
            // 
            tboxSurname.BackColor = Color.White;
            tboxSurname.BorderStyle = BorderStyle.FixedSingle;
            tboxSurname.Cursor = Cursors.Hand;
            tboxSurname.Location = new Point(119, 188);
            tboxSurname.Name = "tboxSurname";
            tboxSurname.Size = new Size(217, 30);
            tboxSurname.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Location = new Point(116, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 34);
            panel5.TabIndex = 17;
            // 
            // passwordTbox
            // 
            passwordTbox.BackColor = Color.White;
            passwordTbox.BorderStyle = BorderStyle.FixedSingle;
            passwordTbox.Cursor = Cursors.Hand;
            passwordTbox.Location = new Point(119, 263);
            passwordTbox.Name = "passwordTbox";
            passwordTbox.Size = new Size(217, 30);
            passwordTbox.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Location = new Point(116, 260);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 34);
            panel4.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Location = new Point(116, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 34);
            panel3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(119, 229);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 10;
            label5.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(119, 157);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 9;
            label4.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(119, 84);
            label3.Name = "label3";
            label3.Size = new Size(38, 23);
            label3.TabIndex = 8;
            label3.Text = "Ad:";
            // 
            // ogrenciYonetimform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 599);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ogrenciYonetimform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += ogrenciYonetimform_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tboxName;
        private TextBox textBox3;
        private Button ogrenciDuzenleBut;
        private Button ogrenciKaydetBut;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private TextBox tboxSurname;
        private Panel panel5;
        private TextBox passwordTbox;
        private Panel panel4;
        private Button ogrenciSilBut;
        private Label label9;
        private Button ogrenciYoklamaBut;
        private TextBox ogrenciIDtbox;
        private Panel panel1;
        private Panel panel6;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label2;
    }
}