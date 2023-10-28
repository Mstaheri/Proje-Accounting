using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class UpdatAccess
    {
        public OperationResult Updat(bool check1, bool check2, bool check3,
            bool check4, bool check5 , string user)
        {
            try
            {
                SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=CarpetCompany;Integrated Security=True");
                string procName = "UpdateAccess";
                SqlCommand smd = new SqlCommand(procName, sc);
                smd.CommandType = CommandType.StoredProcedure;
                smd.Parameters.AddWithValue("@AccessRate1", check1);
                smd.Parameters.AddWithValue("@AccessRate2", check2);
                smd.Parameters.AddWithValue("@AccessRate3", check3);
                smd.Parameters.AddWithValue("@AccessRate4", check4);
                smd.Parameters.AddWithValue("@AccessRate5", check5);
                smd.Parameters.AddWithValue("@user", user);
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
