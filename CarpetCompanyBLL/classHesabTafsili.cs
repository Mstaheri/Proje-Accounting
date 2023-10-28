using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classHesabTafsili
    {
        CarpetCompanyDAL.classHesabTafsili Tafsili = new CarpetCompanyDAL.classHesabTafsili();
        CarpetCompanyDAL.classHesabMoin Moin = new CarpetCompanyDAL.classHesabMoin();
        public OperationResult<List<HesabTafsili>> Select(string search = "")
        {
            var check = Tafsili.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string shomareTafsili)
        {
            var check = Tafsili.Delete(shomareTafsili);
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
        public OperationResult Insert(string CodeTafsili, string OnvanTafsili, string CodeMoin)
        {
            decimal mojodi;
            bool check1 = decimal.TryParse(CodeTafsili, out mojodi);
            var check = Tafsili.SelectCodeTafsili(CodeTafsili);
            var check2 = Moin.SelectCodeMoin(CodeMoin);
            if (string.IsNullOrEmpty(CodeTafsili) || string.IsNullOrEmpty(OnvanTafsili) || string.IsNullOrEmpty(CodeMoin))
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
            else if (CodeTafsili.Length >= 20)
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
                var Check = Tafsili.Insert(CodeTafsili, OnvanTafsili, CodeMoin);
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
