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
using yoklamadenemesistem.sqlvariables;
using System.ComponentModel.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yoklamadenemesistem.Formlar
{
    public partial class dersYonetim : Form
    {
        public dersYonetim()
        {
            InitializeComponent();
        }

        public void tabloYenile()//kodun içinde herhangi bir yerde çağırılarak tablo güncelleme metodu
        {
            try
            {
                SqlCommand tabloKomutu = new SqlCommand("Select * from DERS_PROGRAMI", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(tabloKomutu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Sütun isimleri değiştirilir daha estetik bir görünüm
                dt.Columns["Ogretmen_ID"].ColumnName = "Öğretmen No";
                dt.Columns["Ders_Gunu"].ColumnName = "Ders Günü";
                dt.Columns["Ders_Baslangic_Saati"].ColumnName = "Başlangıç Saati";
                dt.Columns["Ders_Bitis_Saati"].ColumnName = "Bitiş Saati";
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo yenileme sırasında bir hata oluştu:" + ex.Message);

            }

        }

        private void dersEklemeBut_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ekle = new SqlCommand("Insert into DERS_PROGRAMI(Ogretmen_ID,Ders_Gunu,Ders_Baslangic_Saati,Ders_Bitis_Saati) values (@pid,@pgun,@pbas,@pson)", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                ekle.Parameters.AddWithValue("@pid", Convert.ToInt32(tboxOgretmenID.Text));
                ekle.Parameters.AddWithValue("@pgun", tboxDersGun.Text);
                ekle.Parameters.AddWithValue("@pbas", TimeSpan.Parse(tboxBasSaat.Text));
                ekle.Parameters.AddWithValue("@pson", TimeSpan.Parse(tboxBitSaat.Text));
                ekle.ExecuteNonQuery();
                tabloYenile();
                //tablo yenilendikten sonra text boxlar boş bırakılır yeni ders eklemek için zemin hazırlanır
                tboxOgretmenID.Text = "";
                tboxDersGun.Text = "";
                tboxBasSaat.Text = "";
                tboxBitSaat.Text = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tarih veya saat formatı yanlış girildi: " + ex.Message);
            }
            catch (SqlException ex)
            {

                if (ex.Number == 547) //sql veritabanında öğretmen id nin bulunmaması ile alakalı hata kodu
                {
                    MessageBox.Show("Geçerli bir öğretmen id değeri giriniz!");
                }
                else
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void dersYonetim_Load(object sender, EventArgs e)
        {
            tabloYenile();//form açıldığında tablo direkt açılır
        }

        private void dersSilBut_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand silKomutu = new SqlCommand("Delete from DERS_PROGRAMI where Ogretmen_ID=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                silKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));//id benzersiz olduğundan id baz alınarak sillinir//seciliID değeri textboxta bulunur.
                silKomutu.ExecuteNonQuery();
                tabloYenile();
                tboxOgretmenID.Text = "";
                tboxDersGun.Text = "";
                tboxBasSaat.Text = "";
                tboxBitSaat.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders silme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private string seciliID;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {//hızlı bir şekilde silmek için tabloda seçilen dersin bilgiler textboxlara aktarılır bu sayede kolay bir şekilde güncelleme silme işlemi yapılır
                seciliID = (dataGridView1.CurrentRow.Cells["Öğretmen No"].Value).ToString();
                tboxOgretmenID.Text = seciliID.ToString();
                tboxDersGun.Text = (dataGridView1.CurrentRow.Cells["Ders Günü"].Value).ToString();
                tboxBasSaat.Text = (dataGridView1.CurrentRow.Cells["Başlangıç Saati"].Value).ToString();
                tboxBitSaat.Text = (dataGridView1.CurrentRow.Cells["Bitiş Saati"].Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders seçilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
