using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class UpdatAcceess
    {
        public OperationResult UpdatAccess(bool check1, bool check2, bool check3,
            bool check4, bool check5, string user)
        {
            CarpetCompanyDAL.UpdatAccess emp = new CarpetCompanyDAL.UpdatAccess();
            var Check = emp.Updat(check1, check2, check3, check4, check5, user);
            if (Check.Success == true)
            {
                return new OperationResult
                {
                    Success = true,
                    Message = "ثبت با موفقیت کامل شد"
                };
            }
            else
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
    }
    
}
