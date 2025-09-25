using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Data
{
    internal class Sql
    {
        const string CONNECTIONSTRING = "server=DESKTOP-LIHEPUT\\SQLEXPRESS;database=HomeT;Trusted_connection=true;";
        private static SqlConnection _connection = new SqlConnection(CONNECTIONSTRING);

        public int NonQueryEx(string cmd)
        {
            int result = 0;
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(cmd, _connection);
                result = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return result;

        }
        public DataTable QueryEx(string cmd)
        {
            DataTable table= new DataTable();
            try
            {
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return table;
        }

    }
}
