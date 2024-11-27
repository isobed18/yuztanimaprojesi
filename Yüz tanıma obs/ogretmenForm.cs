using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace admin
{
    public partial class ogretmenForm : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=yuztanima.database.windows.net;Initial Catalog=yuztanima;User ID=Yusuf;Password=P@ssw0rd!";
        private int Ogretmen_ID;

        public ogretmenForm(int lecturerId, string connectionString)
        {
            InitializeComponent();
            this.Ogretmen_ID = lecturerId;
            this.connectionString = connectionString;

            connection = new SqlConnection(connectionString);
        }



        private void FillLecturerInfo()
        {
            string query = "SELECT Ogretmen_Adi, Ogretmen_Soyadi, Ogretmen_ID FROM OGRETMEN WHERE Ogretmen_ID = @Ogretmen_ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ogretmen_ID", Ogretmen_ID);

            try
            {
                //!bağlantı açıldı!
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ogretmen_isim.Text = reader["Ogretmen_Adi"].ToString();
                    ogretmen_soyad.Text = reader["Ogretmen_Soyadi"].ToString();
                    ogretmen_id.Text = reader["Ogretmen_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                //!bağlantı kapatıldı!
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void InitializeDataGridView()
        {
            dataGridViewogretmen.Columns.Add("Ogrenci No", "Öğrenci No");
            dataGridViewogretmen.Columns.Add("Adi", "Adı");
            dataGridViewogretmen.Columns.Add("Soyadı", "Soyadı");
            dataGridViewogretmen.Columns.Add("Var", "Var");
            dataGridViewogretmen.Columns.Add("Toplam", "Toplam");
            dataGridViewogretmen.AllowUserToAddRows = false;
        }

        private void ShowAttendanceInfo()
        {
            // öğretmenin id si ile eşleşen tüm öğrencilerin yoklamasını göster
            string query = @"
                SELECT d.Ogrenci_No, o.Ogrenci_Adi, o.Ogrenci_Soyadi, d.Mevcut, itd.Toplam
                FROM DEVAMSIZLIK d
                INNER JOIN OGRENCI o ON d.Ogrenci_No = o.Ogrenci_No
                INNER JOIN ISLENEN_TOPLAM_DERS itd ON d.Ogretmen_ID = itd.Ogretmen_ID
                WHERE d.Ogretmen_ID = @Ogretmen_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ogretmen_ID", Ogretmen_ID);

            try
            {
                //!bağlantı açıldı!
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string studentId = reader["Ogrenci_No"].ToString();
                    string studentName = reader["Ogrenci_Adi"].ToString();
                    string studentSurname = reader["Ogrenci_Soyadi"].ToString();
                    int exist = Convert.ToInt32(reader["Mevcut"]);
                    int total = Convert.ToInt32(reader["Toplam"]);

                    dataGridViewogretmen.Rows.Add(studentId, studentName, studentSurname, exist, total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                MessageBox.Show("Hata detayları: " + ex.ToString());
            }
            finally
            {
                //!bağlantı kapatıldı!
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void ogretmenForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

            ShowAttendanceInfo();

            FillLecturerInfo();
        }

        private void ogretmenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
