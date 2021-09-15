using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace E_OkulProje
{
   class Connection
    {
        public SqlConnection baglanti()
        {
           SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=E_Okul;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
      
    }
}
