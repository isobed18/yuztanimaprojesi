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
    public partial class ogrenciForm : Form
    {
        public SqlConnection connection;
        public string connectionString = "Data Source=yuztanima.database.windows.net;Initial Catalog=yuztanima;User ID=Yusuf;Password=P@ssw0rd!";
        private int Ogrenci_No;

        public ogrenciForm(int studentId, string connectionString)
        {
            InitializeComponent();

            this.Ogrenci_No = studentId;
            this.connectionString = connectionString;

            connection = new SqlConnection(connectionString);
        }
        private void ogrenciForm_Load(object sender, EventArgs e)
        {
            ShowAttendanceInfo();

            FillStudentInfo();
        }

        private void FillStudentInfo()
        {
            string query = "SELECT Ogrenci_Adi, Ogrenci_Soyadi, Ogrenci_No FROM OGRENCI WHERE Ogrenci_No = @studentId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@studentId", Ogrenci_No);

            try
            {
                //!bağlantı açıldı!
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ogrenci_isim.Text = reader["Ogrenci_Adi"].ToString();
                    ogrenci_soyad.Text = reader["Ogrenci_Soyadi"].ToString();
                    ogrenci_id.Text = reader["Ogrenci_No"].ToString();
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
        private void ShowAttendanceInfo()
        {
            // öğrencinin öğrenci id si ile eşleşen tüm yoklamalar gösteridli
            string query = @"
            SELECT o.Ders_Adi AS [Ders Adı], o.Ogretmen_Adi AS [Öğretmen Adı], o.Ogretmen_Soyadi AS [Öğretmen Soyadı], d.Mevcut, itd.Toplam AS Toplam
            FROM DEVAMSIZLIK d
            JOIN OGRETMEN o ON d.Ogretmen_ID = o.Ogretmen_ID
            JOIN ISLENEN_TOPLAM_DERS itd ON d.Ogretmen_ID = itd.Ogretmen_ID
            WHERE d.Ogrenci_No = @studentId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@studentId", Ogrenci_No);

            try
            {
                //!bağlantı açıldı!
                connection.Open();

                DataTable dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                dataGridViewyoklama.DataSource = dataTable;
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

        private void ogrenciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
