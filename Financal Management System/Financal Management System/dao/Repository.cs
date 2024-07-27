using Financal_Management_System.enumacation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financal_Management_System.dao
{
    public class Repository
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnValue;

        public Repository() { 
        conn=new SqlConnection("Server=localhost;Initial Catalog=Financial_Management_System;User ID=sa;password=12345");
        }

        public LoginState login(string UserId,string Pasword)
        {
            conn.Open();
            cmd = new SqlCommand("login_sp", conn);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Pasword", Pasword);
            returnValue = (int)cmd.ExecuteScalar();
            conn.Close();
            if (returnValue == 1 ) 
            {
                return LoginState.successful;
            }
            else
            {
                return LoginState.failed;
            }
        }
    }
}
