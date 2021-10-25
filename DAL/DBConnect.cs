using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
       
        protected SqlConnection _con = new SqlConnection(@"Data Source=sql.freeasphost.net\MSSQL2016;Database=hoainam11134_QLBVMB;uid=hoainam11134;pwd=161120");

        public void Connect()
        {
            _con.Open();
        }

        public void Disconnect()
        {
            _con.Close();
        }
    }

    
}
