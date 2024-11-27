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

namespace yoklamadenemesistem.Formlar
{
    public partial class ogrenciYonetimform : Form
    {
        public ogrenciYonetimform()
        {
            InitializeComponent();
        }

        public void tabloYenileme()
        {
            try
            {
                SqlCommand tabloGetirKomutu = new SqlCommand("Select * from OGRENCI", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(tabloGetirKomutu);
                DataTable dt = new DataTable();
                da.Fill(dt);//tablo yenileme ve ayarları
                dt.Columns["Ogrenci_No"].ColumnName = "Öğrenci No";
                dt.Columns["Ogrenci_Adi"].ColumnName = "Öğrenci Adı";
                dt.Columns["Ogrenci_Soyadi"].ColumnName = "Öğrenci Soyadı";
                dt.Columns["Ogrenci_Sifre"].ColumnName = "Öğrenci Şifresi";

                dataGridView2.DataSource = dt;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo yenileme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void ogrenciKaydetBut_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand idKontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM OGRENCI WHERE Ogrenci_No = @pid", sqlvariable.baglanti);
                idKontrolKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(ogrenciIDtbox.Text));
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                int kayitSayisi = (int)idKontrolKomutu.ExecuteScalar();//sorgu sonucu değer alınır
                if (kayitSayisi > 0)
                {
                    throw new Exception("Öğrenci No bir başka öğrenci ile aynı!");
                }//eşleşen satırların sayısı döndürülür eğer 0 dan büyük ise eşleşen id ler vardır.
                SqlCommand ekleKomutu = new SqlCommand("Insert into OGRENCI(Ogrenci_No,Ogrenci_Adi,Ogrenci_Soyadi,Ogrenci_Sifre) values (@pid,@pad,@psoyad,@ppassword)", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                ekleKomutu.Parameters.AddWithValue("@pad", tboxName.Text);
                ekleKomutu.Parameters.AddWithValue("@psoyad", tboxSurname.Text);
                ekleKomutu.Parameters.AddWithValue("@ppassword", passwordTbox.Text);
                ekleKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(ogrenciIDtbox.Text));
                ekleKomutu.ExecuteNonQuery();
                tabloYenileme();
                tboxName.Text = "";
                tboxSurname.Text = "";
                passwordTbox.Text = "";
                ogrenciIDtbox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci kayıt sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void ogrenciDuzenleBut_Click(object sender, EventArgs e)
        {
            try
            {//öğrenci id bilgisi ile düzenleme işlemi
                SqlCommand duzenleKomutu = new SqlCommand("Update OGRENCI set Ogrenci_No=@pidd , Ogrenci_Adi=@pad , Ogrenci_Soyadi=@psoyad , Ogrenci_Sifre=@ppassword where Ogrenci_No=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                duzenleKomutu.Parameters.AddWithValue("@pidd", ogrenciIDtbox.Text);
                duzenleKomutu.Parameters.AddWithValue("@pad", tboxName.Text);
                duzenleKomutu.Parameters.AddWithValue("@psoyad", tboxSurname.Text);
                duzenleKomutu.Parameters.AddWithValue("@ppassword", passwordTbox.Text);
                duzenleKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));
                duzenleKomutu.ExecuteNonQuery();
                tabloYenileme();
                tboxName.Text = "";
                tboxSurname.Text = "";
                passwordTbox.Text = "";
                ogrenciIDtbox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci düzenleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void ogrenciSilBut_Click(object sender, EventArgs e)
        {
            try
            {//yine aynı şekilde öğrenci id benzersiz olduğundan baz alınarak silme işlemi
                SqlCommand silKomutu = new SqlCommand("Delete from OGRENCI where Ogrenci_No=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                silKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));//seciliID değeri öğrenci id textbox ile aynı
                silKomutu.ExecuteNonQuery();
                tabloYenileme();
                tboxName.Text = "";
                tboxSurname.Text = "";
                passwordTbox.Text = "";
                ogrenciIDtbox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci silme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        string seciliID;

        private void ogrenciYonetimform_Load(object sender, EventArgs e)
        {
            tabloYenileme();//sayfa yüklendiğinde tabloyu yükler
        }

        private void ogrenciYoklamaBut_Click(object sender, EventArgs e)
        {
            ogrenciYoklama yoklamaForm = new ogrenciYoklama(seciliID);//tablodan seçtiğimiz öğrencinin yoklama bilgilerini id baz alınarak yeni formda gösterilir
            yoklamaForm.Show();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {//öğrenci silme ve düzenleme işlemi için tablodan seçilenler textboxlara yazdırılır.
                seciliID = (dataGridView2.CurrentRow.Cells["Öğrenci No"].Value).ToString();
                ogrenciIDtbox.Text = seciliID.ToString();
                tboxName.Text = (dataGridView2.CurrentRow.Cells["Öğrenci Adı"].Value).ToString();
                tboxSurname.Text = (dataGridView2.CurrentRow.Cells["Öğrenci Soyadı"].Value).ToString();
                passwordTbox.Text= (dataGridView2.CurrentRow.Cells["Öğrenci Şifresi"].Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci seçilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
