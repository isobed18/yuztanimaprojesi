using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using yoklamadenemesistem;

namespace admin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void girisYapButonu_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=yuztanima.database.windows.net;Initial Catalog=yuztanima;User ID=Yusuf;Password=P@ssw0rd!";
            string yetki = comboBox1.SelectedItem?.ToString();
            string id = idTextBox.Text.Trim();
            string sifre = sifreTextBox.Text.Trim();

            //Yetki seçimi uyarısı
            if (string.IsNullOrEmpty(yetki))
            {
                MessageBox.Show("Lütfen bir yetki seçin.");
                return;
            }
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi girin.");
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();      //bağlantı açılır
                    string sql = "";
                    SqlParameter prm1 = new SqlParameter();
                    SqlParameter prm2 = new SqlParameter();




                    switch (yetki) // swtich case ile yetki kontrolü ve buna göre giriş
                    {
                        case "Yönetici":
                            sql = "SELECT * FROM ADMIN WHERE Admin_ID =@id AND Admin_Sifre = @sifre";
                            prm1 = new SqlParameter("id", idTextBox.Text.Trim());
                            prm2 = new SqlParameter("sifre", sifreTextBox.Text.Trim());
                            break;

                        case "Öğretmen":
                            sql = "SELECT * FROM OGRETMEN WHERE Ogretmen_ID = @id AND Ogretmen_Sifre = @sifre";
                            prm1 = new SqlParameter("@id", idTextBox.Text.Trim());
                            prm2 = new SqlParameter("@sifre", sifreTextBox.Text.Trim());
                            break;


                        case "Öğrenci":
                            sql = "SELECT * FROM OGRENCI WHERE Ogrenci_No = @id AND Ogrenci_Sifre = @sifre";
                            prm1 = new SqlParameter("id", idTextBox.Text.Trim());
                            prm2 = new SqlParameter("sifre", sifreTextBox.Text.Trim());
                            break;
                    }
                    using (SqlCommand cmd = new SqlCommand(sql, conn)) 
                    {
                        cmd.Parameters.Add(prm1);
                        cmd.Parameters.Add(prm2);

                        DataTable dt = new DataTable(); // data table oluşturumu ve gerekli uyum adaptörü
                        SqlDataAdapter da = new SqlDataAdapter(cmd); 
                        da.Fill(dt); 

                        if (dt.Rows.Count > 0) //doğru veri uyumunda giriş sağlamasıylan birlikte formların açılması
                        {
                            switch (yetki) //yetki kontrol
                            {
                                case "Yönetici":
                                   Form2 form2 = new Form2();
                                    form2.Show();
                                    break;

                                case "Öğretmen":
                                    ogretmenForm ogretmenForm = new ogretmenForm(Convert.ToInt32(id), "Data Source=yuztanima.database.windows.net;Initial Catalog=yuztanima;User ID=Yusuf;Password=P@ssw0rd!");
                                    ogretmenForm.Show();
                              
                                    break;

                                case "Öğrenci":
                                    ogrenciForm ogrenciForm = new ogrenciForm(Convert.ToInt32(id), "Data Source=yuztanima.database.windows.net;Initial Catalog=yuztanima;User ID=Yusuf;Password=P@ssw0rd!");
                                    ogrenciForm.Show();
                                    break;
                            }

                            this.Hide();
                        }
                        else //uyuşmama durumuna karşılık olaraktan haata mesajı
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                            idTextBox.Clear();
                            sifreTextBox.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }


    }
}
