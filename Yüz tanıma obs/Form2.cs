using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoklamadenemesistem
{

    public partial class Form2 : Form
    {
        private Form guncelForm;

        public Form2()
        {
            InitializeComponent();
        }


        private void pencereFormu(Form kucukForm, object btnSender)
        {
            if (guncelForm != null)//ilgili formlar açıldığında güncel form olarak ayarlanır 29.satır eğer null değilse kapatılır
                guncelForm.Close();
            anasayfaGaziResim.Visible = false;//ana sayfadaki logo görünmez hale getirilir
            guncelForm = kucukForm;//parametre değeri güncel forma atanır bu sayede bir başka form açılacağı zaman varsayılan form kapatılır
            kucukForm.TopLevel = false;
            kucukForm.FormBorderStyle = FormBorderStyle.None;//form içinde gösterileceiği için border style none hale getirilir
            kucukForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(kucukForm);
            this.panelDesktopPane.Tag = kucukForm;
            kucukForm.BringToFront();
            kucukForm.Show();
            lblTitle.Text = "Yönetim";
        }

        private void ogrenciManagebut_Click(object sender, EventArgs e)
        {
            pencereFormu(new Formlar.ogrenciYonetimform(), sender);//pencere formunda açılır
        }

        private void ogretmenManageBut_Click(object sender, EventArgs e)
        {
            pencereFormu(new Formlar.ogretmenYonetimform(), sender);//pencere formunda açılır
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pencereFormu(new Formlar.dersYonetim(), sender);//pencere formunda açılır

        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//form 2 kapatıldığında uygulamada kapatılır
        }

        private void Form2_Load(object sender, EventArgs e)//tasarımın daha düzenli ve uygun gözükmesi için belirli boyutlarda ve konumda açılır
        {
            this.WindowState = FormWindowState.Normal; 
            this.Size = new Size(1480, 768);
            this.CenterToScreen();
        }
    }
}
