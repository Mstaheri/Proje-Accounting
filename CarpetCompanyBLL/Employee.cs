using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class Employee
    {
        CarpetCompanyDAL.Employee emp = new CarpetCompanyDAL.Employee();
        public OperationResult Insert(string FirstName, string LastName, string PhoneNumber,
            string UserName, string Password, string Jobs,bool Rate1, bool Rate2, bool Rate3,
            bool Rate4, bool Rate5)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PhoneNumber) ||
                string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Jobs))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else if (PhoneNumber.Length != 11 || !PhoneNumber.StartsWith("09"))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل معتبر وارد کنید"
                };
            }
            else
            {
                var Check = emp.Insert(FirstName,LastName,PhoneNumber,UserName,Password, Jobs,Rate1, Rate2, Rate3, Rate4, Rate5);
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
        public OperationResult<DataTable> Select(string search = "")
        {
            var Check = emp.Select(search);
            if (Check.Success == false)
            {
                return new OperationResult<DataTable>
                {
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
            else
            {
                return Check;
            }
        }
        public OperationResult Delete(string UserName)
        {
            var Check = emp.Delete(UserName);
            if (Check.Success == false)
            {
                return new OperationResult
                {
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
            else
            {
                return new OperationResult
                {
                    Message = "حذف با موفقیت انجام شد"
                };
            }
        }
        public OperationResult Updat(string FirstName, string LastName, string PhoneNumber,
            string UserName, string Password, string Jobs)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(PhoneNumber) ||
                string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Jobs))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else if (PhoneNumber.Length != 11 || !PhoneNumber.StartsWith("09"))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل معتبر وارد کنید"
                };
            }
            else
            {
                var Check = emp.Updat(FirstName, LastName, PhoneNumber, UserName, Password, Jobs);
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
}
