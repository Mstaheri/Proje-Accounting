using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class SearchUserAndPasswordAndJobs
    {
        public OperationResult<DataTable> UserSearch(string user , string passWord , string jobs)
        {
            if (string.IsNullOrEmpty(user) || 
                string.IsNullOrEmpty(passWord) || 
                string.IsNullOrEmpty(jobs))
            {
                return new OperationResult<DataTable>
                {
                    Success = false,
                    Message = "نام کاربری و شغل و رمز عبور خود را وارد کنید",
                };
            }
            CarpetCompanyDAL.SearchUserAndPasswordAndJobs UPJ = new CarpetCompanyDAL.SearchUserAndPasswordAndJobs();
            string job = UPJ.Search(user, passWord , jobs , out DataTable mahdode);
            if (job != "not fine")
            {
                return new OperationResult<DataTable>
                {
                    Success = true,
                    Message = "خوش امدید" + job,
                    Jobs = job,
                    Data = mahdode
                    
                };
            }
            else
            {
                return new OperationResult<DataTable>
                {
                    Success = false,
                    Message = "پیدا نشد"
                };
            }
        }
    }
}
