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
    public partial class ogrenciYoklama : Form
    {
        private string seciliID;

        public ogrenciYoklama(string seciliID)
        {
            InitializeComponent();
            this.seciliID = seciliID;//tablodan seçilen öğrenci id si seciliID değerine atanır bu parametre ile öğrencinin yoklama formuna gidilir bu sayede her öğrencinin yoklama bilgisi ayrı ayrı gösterilir.
            tabloYenileme();
        }

        public void tabloYenileme()
        {
            SqlCommand command = new SqlCommand(
            "SELECT d.Ogretmen_ID AS [Öğretmen ID], o.Ders_Adi AS [Ders Adı], d.Mevcut AS [Mevcut], itd.Toplam AS [Toplam] " +//sütun isimleri "[]" içlerine yazılarak ayarlandı 
            "FROM DEVAMSIZLIK d " +
            "JOIN OGRETMEN o ON d.Ogretmen_ID = o.Ogretmen_ID " +//ogretmen_ID tablolar arası bağlı olduğundan primary key olduğu tablodan çekilir
            "JOIN ISLENEN_TOPLAM_DERS itd ON d.Ogretmen_ID = itd.Ogretmen_ID " +//işlenen toplam ders bilgisi gerekli tablodan çekilir
            "WHERE d.Ogrenci_No = @studentId",
            sqlvariable.baglanti);

            command.Parameters.AddWithValue("@studentId", seciliID);
            sqlvariable.BaglantiKontrol(sqlvariable.baglanti);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
