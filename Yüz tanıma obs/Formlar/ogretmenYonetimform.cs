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
    public partial class ogretmenYonetimform : Form
    {
        public ogretmenYonetimform()
        {
            InitializeComponent();
        }

        public void tabloYenileme()
        {
            try
            {
                SqlCommand tabloGetirKomutu = new SqlCommand("Select * from OGRETMEN", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(tabloGetirKomutu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //sütun isimleri ve tablo boyut gösterim ayarlaması
                dt.Columns["Ogretmen_ID"].ColumnName = "Öğretmen No";
                dt.Columns["Ogretmen_Adi"].ColumnName = "Öğretmen Adı";
                dt.Columns["Ogretmen_Soyadi"].ColumnName = "Öğretmen Soyadı";
                dt.Columns["Ders_Adi"].ColumnName = "Ders Adı";
                dt.Columns["Ogretmen_Sifre"].ColumnName = "Öğretmen Şifresi";
                dataGridView2.DataSource = dt;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            } catch (Exception ex) {
                MessageBox.Show("Tablo yenileme sırasında bir hata oluştu: " + ex.Message);

            }

        }

        private void ogretmenYonetimform_Load(object sender, EventArgs e)
        {
            tabloYenileme();//form yüklendiğinde tabloyu gösterme
        }

        private void ogretmenKaydetBut_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand idKontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM OGRETMEN WHERE Ogretmen_ID = @pid", sqlvariable.baglanti);
                idKontrolKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(tboxOgretmenID.Text));
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                int kayitSayisi = (int)idKontrolKomutu.ExecuteScalar();//sorgu sonucu değer alınır
                if (kayitSayisi > 0)
                {
                    throw new Exception("Öğretmen No bir başka öğretmen ile aynı!");
                }//eşleşen satırların sayısı döndürülür eğer 0 dan büyük ise eşleşen id ler vardır ve uyarı atılır.
                SqlCommand ekleKomutu = new SqlCommand($"Insert into OGRETMEN(Ogretmen_ID,Ogretmen_Adi,Ogretmen_Soyadi,Ders_Adi,Ogretmen_Sifre) values (@pid,@pad,@psoyad,@pcoursename,@ppassword)", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                ekleKomutu.Parameters.AddWithValue("@pid", tboxOgretmenID.Text);
                ekleKomutu.Parameters.AddWithValue("@pad", ogretmenNametbox.Text);
                ekleKomutu.Parameters.AddWithValue("@psoyad", ogretmenSurnametbox.Text);
                ekleKomutu.Parameters.AddWithValue("@pcoursename", dersaditbox.Text);
                ekleKomutu.Parameters.AddWithValue("@ppassword", ogretmenPasswordtbox.Text);
                ekleKomutu.ExecuteNonQuery();
                tabloYenileme();//tablo yenileme sonrası textbox temizleme
                tboxOgretmenID.Text = "";
                ogretmenNametbox.Text = "";
                ogretmenSurnametbox.Text = "";
                dersaditbox.Text = "";
                ogretmenPasswordtbox.Text = "";


            }
            catch (Exception ex) { }
            
        }

        private void ogretmenDuzenleBut_Click(object sender, EventArgs e)
        {
            try
            {//Ogretmen_ID baz alınarak düzenleme işlemi
                SqlCommand duzenlemeKomutu = new SqlCommand("Update OGRETMEN set Ogretmen_ID=@pidd , Ogretmen_Adi=@pad , Ogretmen_Soyadi=@psoyad, Ders_Adi=@pcoursename,Ogretmen_Sifre=@ppassword where Ogretmen_ID=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                duzenlemeKomutu.Parameters.AddWithValue("@pidd", tboxOgretmenID.Text);
                duzenlemeKomutu.Parameters.AddWithValue("@pad", ogretmenNametbox.Text);
                duzenlemeKomutu.Parameters.AddWithValue("@psoyad", ogretmenSurnametbox.Text);
                duzenlemeKomutu.Parameters.AddWithValue("@ppassword", ogretmenPasswordtbox.Text);
                duzenlemeKomutu.Parameters.AddWithValue("@pcoursename", (dersaditbox.Text));
                duzenlemeKomutu.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));
                duzenlemeKomutu.ExecuteNonQuery();
                tabloYenileme();
                tboxOgretmenID.Text = "";
                ogretmenNametbox.Text = "";
                ogretmenSurnametbox.Text = "";
                dersaditbox.Text = "";
                ogretmenPasswordtbox.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show("Öğretmen düzenleme sırasında bir hata oluştu: " + ex.Message);

            }
        }

        private void ogretmenSilBut_Click(object sender, EventArgs e)
        {
            try
            {//Ogretmen_ID nin bulunduğu tablolar arasında cascade bağlantı olmadığından ilgili tablolardaki veriler de öğretmen ile beraber silinir.
                SqlCommand silDersProgrami = new SqlCommand("DELETE FROM DERS_PROGRAMI WHERE Ogretmen_ID=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                silDersProgrami.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));
                silDersProgrami.ExecuteNonQuery();

                SqlCommand silDevamsizlik = new SqlCommand("DELETE FROM DEVAMSIZLIK WHERE Ogretmen_ID=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                silDevamsizlik.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));
                silDevamsizlik.ExecuteNonQuery();

                SqlCommand silIslenenToplamDers = new SqlCommand("DELETE FROM ISLENEN_TOPLAM_DERS WHERE Ogretmen_ID=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                silIslenenToplamDers.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));
                silIslenenToplamDers.ExecuteNonQuery();

                SqlCommand silOgretmen = new SqlCommand("DELETE FROM OGRETMEN WHERE Ogretmen_ID=@pid", sqlvariable.baglanti);
                sqlvariable.BaglantiKontrol(sqlvariable.baglanti);
                silOgretmen.Parameters.AddWithValue("@pid", Convert.ToInt64(seciliID));
                silOgretmen.ExecuteNonQuery();
                tabloYenileme();
                tboxOgretmenID.Text = "";
                ogretmenNametbox.Text = "";
                ogretmenSurnametbox.Text = "";
                dersaditbox.Text = "";
                ogretmenPasswordtbox.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show("Öğretmen silme sırasında bir hata oluştu: " + ex.Message);

            }
        }

        string seciliID;


        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {//silme düzenleme işlemi kolaylığı için tablodan seçilen öğretmen bilgileri textboxlara yazdırılır.
                seciliID = (dataGridView2.CurrentRow.Cells["Öğretmen No"].Value).ToString();
                tboxOgretmenID.Text = seciliID.ToString();
                ogretmenNametbox.Text = (dataGridView2.CurrentRow.Cells["Öğretmen Adı"].Value).ToString();
                ogretmenSurnametbox.Text = (dataGridView2.CurrentRow.Cells["Öğretmen Soyadı"].Value).ToString();
                dersaditbox.Text = (dataGridView2.CurrentRow.Cells["Ders Adı"].Value).ToString();
                ogretmenPasswordtbox.Text = (dataGridView2.CurrentRow.Cells["Öğretmen Şifresi"].Value).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Öğretmen seçilirken bir hata oluştu: " + ex.Message);


            }
        }

        
    }
}
