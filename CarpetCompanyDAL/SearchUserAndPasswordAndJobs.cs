using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace CarpetCompanyDAL
{
    public class SearchUserAndPasswordAndJobs
    {
        public string Search(string UserName, string Password, string Jobs , out DataTable mahdode)
        {
            int Check = 0;
            string connection_string = "Data Source =.; Initial Catalog = CarpetCompany; Integrated Security = True";
            SqlConnection sc = new SqlConnection(connection_string);
            string query = $"select * from Account where UserName = '{UserName}' And Password = '{Password}' And Jobs = N'{Jobs}'";
            SqlDataAdapter Adapter = new SqlDataAdapter(query, sc);
            DataTable table = new DataTable();
            Adapter.Fill(table);
            Check = table.Rows.Count;
            mahdode = table;
            if (Check == 0)
            {
                return "not fine";
            }
            else
            {
                return Jobs;
            }
        }
        
    }
}
