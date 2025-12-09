using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace WinFormsApp104
{
    internal class dbconnection
    {
        public static SqlConnection Nortwind_conn()
        {
            string ConnectionString = "Data Source=ADM403-25\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True; Encrypt=False";
            SqlConnection conn = new SqlConnection (ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
