namespace yoklamadenemesistem.Formlar
{
    partial class dersYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dersYonetim));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            tboxOgretmenID = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            textBox4 = new TextBox();
            tboxDersGun = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            tboxBasSaat = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            textBox5 = new TextBox();
            tboxBitSaat = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            textBox7 = new TextBox();
            dersEklemeBut = new Button();
            dersSilBut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(324, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 476);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(604, 43);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 30;
            label1.Text = "Ders Düzenleme";
            // 
            // tboxOgretmenID
            // 
            tboxOgretmenID.BackColor = Color.White;
            tboxOgretmenID.BorderStyle = BorderStyle.FixedSingle;
            tboxOgretmenID.Cursor = Cursors.Hand;
            tboxOgretmenID.Location = new Point(78, 164);
            tboxOgretmenID.Name = "tboxOgretmenID";
            tboxOgretmenID.Size = new Size(217, 27);
            tboxOgretmenID.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Location = new Point(75, 161);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 34);
            panel5.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(78, 136);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 33;
            label4.Text = "Öğretmen ID:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Cursor = Cursors.Hand;
            textBox4.Location = new Point(78, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 20);
            textBox4.TabIndex = 32;
            // 
            // tboxDersGun
            // 
            tboxDersGun.BackColor = Color.White;
            tboxDersGun.BorderStyle = BorderStyle.FixedSingle;
            tboxDersGun.Cursor = Cursors.Hand;
            tboxDersGun.Location = new Point(78, 222);
            tboxDersGun.Name = "tboxDersGun";
            tboxDersGun.Size = new Size(217, 27);
            tboxDersGun.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(75, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 34);
            panel2.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 194);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 37;
            label2.Text = "Ders Günü:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Location = new Point(78, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 20);
            textBox2.TabIndex = 36;
            // 
            // tboxBasSaat
            // 
            tboxBasSaat.BackColor = Color.White;
            tboxBasSaat.BorderStyle = BorderStyle.FixedSingle;
            tboxBasSaat.Cursor = Cursors.Hand;
            tboxBasSaat.Location = new Point(78, 284);
            tboxBasSaat.Name = "tboxBasSaat";
            tboxBasSaat.Size = new Size(217, 27);
            tboxBasSaat.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Location = new Point(75, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 34);
            panel3.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(78, 256);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 41;
            label3.Text = "Başlangıç Saati:";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.Hand;
            textBox5.Location = new Point(78, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(217, 20);
            textBox5.TabIndex = 40;
            // 
            // tboxBitSaat
            // 
            tboxBitSaat.BackColor = Color.White;
            tboxBitSaat.BorderStyle = BorderStyle.FixedSingle;
            tboxBitSaat.Cursor = Cursors.Hand;
            tboxBitSaat.Location = new Point(78, 346);
            tboxBitSaat.Name = "tboxBitSaat";
            tboxBitSaat.Size = new Size(217, 27);
            tboxBitSaat.TabIndex = 46;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Location = new Point(75, 343);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 34);
            panel4.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(78, 318);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 45;
            label5.Text = "Bitiş Saati:";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Cursor = Cursors.Hand;
            textBox7.Location = new Point(78, 346);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(217, 20);
            textBox7.TabIndex = 44;
            // 
            // dersEklemeBut
            // 
            dersEklemeBut.BackColor = Color.DarkSlateGray;
            dersEklemeBut.FlatAppearance.BorderColor = Color.White;
            dersEklemeBut.FlatStyle = FlatStyle.Flat;
            dersEklemeBut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dersEklemeBut.ForeColor = Color.White;
            dersEklemeBut.Location = new Point(55, 427);
            dersEklemeBut.Name = "dersEklemeBut";
            dersEklemeBut.Size = new Size(125, 52);
            dersEklemeBut.TabIndex = 48;
            dersEklemeBut.Text = "Ekle";
            dersEklemeBut.UseVisualStyleBackColor = false;
            dersEklemeBut.Click += dersEklemeBut_Click;
            // 
            // dersSilBut
            // 
            dersSilBut.BackColor = Color.PaleTurquoise;
            dersSilBut.FlatAppearance.BorderColor = Color.White;
            dersSilBut.FlatStyle = FlatStyle.Flat;
            dersSilBut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dersSilBut.Location = new Point(186, 426);
            dersSilBut.Name = "dersSilBut";
            dersSilBut.Size = new Size(125, 53);
            dersSilBut.TabIndex = 49;
            dersSilBut.Text = "Sil";
            dersSilBut.UseVisualStyleBackColor = false;
            dersSilBut.Click += dersSilBut_Click;
            // 
            // dersYonetim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 599);
            Controls.Add(dersSilBut);
            Controls.Add(dersEklemeBut);
            Controls.Add(tboxBitSaat);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(textBox7);
            Controls.Add(tboxBasSaat);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(tboxDersGun);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(tboxOgretmenID);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dersYonetim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBS";
            Load += dersYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private TextBox tboxOgretmenID;
        private Panel panel5;
        private Label label4;
        private TextBox textBox4;
        private TextBox tboxDersGun;
        private Panel panel2;
        private Label label2;
        private TextBox textBox2;
        private TextBox tboxBasSaat;
        private Panel panel3;
        private Label label3;
        private TextBox textBox5;
        private TextBox tboxBitSaat;
        private Panel panel4;
        private Label label5;
        private TextBox textBox7;
        private Button dersEklemeBut;
        private Button dersSilBut;
    }
}