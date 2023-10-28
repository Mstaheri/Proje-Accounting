using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class Employee
    {
        SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=CarpetCompany;Integrated Security=True");
        public OperationResult Insert(string FirstName, string LastName, string PhoneNumber,
            string UserName, string Password, string Jobs, bool Rate1, bool Rate2, bool Rate3,
            bool Rate4, bool Rate5)
        {
            try
            {
                string procName = "InsertAccount";
                SqlCommand smd = new SqlCommand(procName, sc);
                smd.CommandType = CommandType.StoredProcedure;
                smd.Parameters.AddWithValue("@fname", FirstName);
                smd.Parameters.AddWithValue("@lname", LastName);
                smd.Parameters.AddWithValue("@phone", PhoneNumber);
                smd.Parameters.AddWithValue("@user", UserName);
                smd.Parameters.AddWithValue("@pass", Password);
                smd.Parameters.AddWithValue("@job", Jobs);
                smd.Parameters.AddWithValue("@AccessRate1", Rate1);
                smd.Parameters.AddWithValue("@AccessRate2", Rate2);
                smd.Parameters.AddWithValue("@AccessRate3", Rate3);
                smd.Parameters.AddWithValue("@AccessRate4", Rate4);
                smd.Parameters.AddWithValue("@AccessRate5", Rate5);
                sc.Open();
                smd.ExecuteNonQuery();
                sc.Close();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch 
            {
                return new OperationResult
                {
                    Success = false,
                };
            }
            
        }
        public OperationResult Delete(string UserName)
        {
            try
            {
                string procName = "DeleteAccount";
                SqlCommand smd = new SqlCommand(procName,sc);
                smd.CommandType = CommandType.StoredProcedure;
                smd.Parameters.AddWithValue("@userName", UserName);
                sc.Open();
                smd.ExecuteNonQuery();
                sc.Close();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch 
            {
                return new OperationResult
                {
                    Success = false
                };
            }
        }
        public OperationResult<DataTable> Select(string search = "")
        {
            try
            {
                string procName = "SelectAccount";
                SqlCommand cmd = new SqlCommand(procName,sc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sc.Open();
                adapter.Fill(dt);
                sc.Close();
                return new OperationResult<DataTable>
                {
                    Success = true,
                    Data = dt
                };
                
            }
            catch 
            {
                return new OperationResult<DataTable>
                {
                    Success = false
                };
            }
            
        }
        public OperationResult Updat(string FirstName, string LastName, string PhoneNumber,
            string UserName, string Password, string Jobs)
        {
            try
            {
                string procName = "UpdateAccount";
                SqlCommand smd = new SqlCommand(procName,sc);
                smd.CommandType = CommandType.StoredProcedure;
                smd.Parameters.AddWithValue("@fname", FirstName);
                smd.Parameters.AddWithValue("@lname", LastName);
                smd.Parameters.AddWithValue("@phone", PhoneNumber);
                smd.Parameters.AddWithValue("@user", UserName);
                smd.Parameters.AddWithValue("@pass", Password);
                smd.Parameters.AddWithValue("@job", Jobs);
                sc.Open();
                smd.ExecuteNonQuery();
                sc.Close();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch 
            {
                return new OperationResult
                {
                    Success = false
                };
            }
        }

    }
}
