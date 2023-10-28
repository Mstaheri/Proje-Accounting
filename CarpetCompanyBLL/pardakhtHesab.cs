using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class pardakhtHesab
    {
        CarpetCompanyDAL.pardakhtHesab pardakhti = new CarpetCompanyDAL.pardakhtHesab();

        public OperationResult<List<PardakhtAzHesab>> Select(string search = "")
        {
            var check = pardakhti.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<PardakhtAzHesab>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string code)
        {
            var check = pardakhti.Delete(code);
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
        public OperationResult Insert(string CodePardakhti, string ShomareHesab,
            string NamHesab, string NamPardakhtKonande, string TarikhPardakht,
            string Tozihat, string Price)
        {
            CarpetCompanyBLL.Mali mal = new CarpetCompanyBLL.Mali();
            var Check1 = mal.Select(ShomareHesab);
            decimal Pricee;
            bool check2 = decimal.TryParse(Price, out Pricee);
            var check4 = pardakhti.SelectCode(CodePardakhti);
            if (string.IsNullOrEmpty(CodePardakhti) || string.IsNullOrEmpty(ShomareHesab) ||
                string.IsNullOrEmpty(NamHesab) || string.IsNullOrEmpty(NamPardakhtKonande) ||
                string.IsNullOrEmpty(TarikhPardakht) || string.IsNullOrEmpty(Price))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else if (check4.Data.Count > 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد پرداختی تکراری است"
                };
            }
            else if (ShomareHesab.Length != 19)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره حساب معتبر وارد کنید"
                };
            }
            else if (Check1.Data.Count == 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره حساب وجود ندارد"
                };
            }
            else if (check2 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل مبلغ فقط باید عدد وارد کرد"
                };
            }
            else
            {
                var Check = pardakhti.Insert(CodePardakhti, ShomareHesab, NamHesab, NamPardakhtKonande, TarikhPardakht, Tozihat, Pricee);
                if (Check.Success == true)
                {
                    return new OperationResult
                    {
                        Success = true,
                        Message = "ثبت با موفقیت کامل شد"
                    };
                }
                else if(Check.Success == false && Check.Message != null)
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "موجودی حساب کافی نیست حساب خود را شارژ کنید :ِ"
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
