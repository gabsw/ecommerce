using System;
using System.Data.SqlClient;

namespace ecommerce
{
    class DbConnectionFactory
    {
        static private String connString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog = p6g2; Persist Security Info=True;uid = p6g2; Password=Whiskas2019";
        static public SqlConnection newConnection()
        {
            return new SqlConnection(connString);
        }
    }
}
