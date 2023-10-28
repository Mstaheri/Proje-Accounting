using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classHesabMion
    {
        CarpetCompanyDAL.classHesabMoin Moin = new CarpetCompanyDAL.classHesabMoin();
        public OperationResult<List<HesabMoin>> Select(string search = "")
        {
            var check = Moin.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<HesabMoin>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult<List<string>> SelectAllCodeMoin()
        {
            var check = Moin.SelectAllCodeMoin();
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
        public OperationResult Delete(string shomareMoin)
        {
            var check = Moin.Delete(shomareMoin);
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
        public OperationResult Insert(string CodeMoin, string OnvanMoin , string CodeKol)
        {
            decimal mojodi;
            bool check1 = decimal.TryParse(CodeMoin, out mojodi);
            CarpetCompanyDAL.classHesabKol kol = new CarpetCompanyDAL.classHesabKol();
            var check = Moin.SelectCodeMoin(CodeMoin);
            var check2 = kol.SelectCodeKol(CodeKol);
            if (string.IsNullOrEmpty(CodeMoin) || string.IsNullOrEmpty(OnvanMoin) || string.IsNullOrEmpty(CodeKol))
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
            else if (check2.Data.Count == 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد کل وجود ندارد"
                };
            }
            else if (CodeMoin.Length >= 15)
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
                var Check = Moin.Insert(CodeMoin, OnvanMoin ,CodeKol);
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
