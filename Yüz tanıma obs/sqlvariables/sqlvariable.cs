using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace yoklamadenemesistem.sqlvariables
{
    public class sqlvariable
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=yuztanima.database.windows.net;Initial Catalog=yuztanima;User ID=Yusuf;Password=P@ssw0rd!");
        public static void BaglantiKontrol(SqlConnection tempConnection)//bu metod kodun içinde herhangi bir yerde çağırılarak bağlantıyı açar.
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {

            }
        }
    }
}
