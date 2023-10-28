using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classHesabKol
    {
        CarpetCompanyDAL.classHesabKol kol = new CarpetCompanyDAL.classHesabKol();
        public OperationResult<List<HesabKol>> Select(string search = "")
        {
            var check = kol.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<HesabKol>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult<List<string>> SelectAllCodeKol()
        {
            var check = kol.SelectAllCodeKol();
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<string>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string shomareKol)
        {
            var check = kol.Delete(shomareKol);
            if (check.Success == true)
            {
                return new OperationResult
                {
                    Message = "حذف با موفقیت انجام شد"
                };
            }
            else
            {
                return new OperationResult
                {
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Insert(string CodeKol , string OnvanKol)
        {
            decimal mojodi;
            bool check1 = decimal.TryParse(CodeKol, out mojodi);
            CarpetCompanyDAL.classHesabKol kol = new CarpetCompanyDAL.classHesabKol();
            var check = kol.SelectCodeKol(CodeKol);
            if (string.IsNullOrEmpty(CodeKol) || string.IsNullOrEmpty(OnvanKol))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else if (check.Data.Count > 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد تکراری است"
                };
            }
            else if (CodeKol.Length >= 15)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد زیر 15 رقم وارد کنید"
                };
            }
            else if (check1 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل کد فقط باید عدد وارد کرد"
                };
            }
            else
            {
                var Check = kol.Insert(CodeKol, OnvanKol);
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
