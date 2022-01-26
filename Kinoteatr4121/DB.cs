using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Kinoteatr4121
{
    class DB
    {
        private SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JSJGVJUO;Initial Catalog=KINOKASSA;Integrated Security=True");
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
        public string ReturnFromDB(string s)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand(s,GetConnection());
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = com;
                adapter.Fill(table);
                CloseConnection();
                return table.Rows[0][0].ToString();
            }
            catch
            {
                CloseConnection();
                return "";
            }
            
        }
        public void NonQuery(string s)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand(s, GetConnection());
            com.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
