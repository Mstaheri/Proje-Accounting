using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class HoghoghKarmandan
    {
        CarpetCompanyDAL.HoghoghKarmandan HK = new CarpetCompanyDAL.HoghoghKarmandan();
        public OperationResult<List<Hoghogh>> Select(string search = "")
        {
            var check = HK.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<Hoghogh>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string codeHoghogh)
        {
            var check = HK.Delete(codeHoghogh);
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
        public OperationResult Insert(string CodeHoghogh, string ShomareHesab, string Nam,
            string Tarikh, string NoaHoghogh, string price , string Tozihat)
        {
            decimal price2;
            bool check1 = decimal.TryParse(price, out price2);
            var check3 = HK.SelectCodeHoghogh(CodeHoghogh);
            if (string.IsNullOrEmpty(CodeHoghogh) || string.IsNullOrEmpty(ShomareHesab) ||
                string.IsNullOrEmpty(Nam) || string.IsNullOrEmpty(Tarikh) ||
                string.IsNullOrEmpty(NoaHoghogh) || string.IsNullOrEmpty(price))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
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
            else if (check3.Data.Count > 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "این کد حقوق قبلا وارد شده"
                };
            }
            else if (check1 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل موجودی فقط باید عدد وارد کرد"
                };
            }
            else
            {
                var Check = HK.Insert(CodeHoghogh, ShomareHesab, Nam, Tarikh, NoaHoghogh, price2, Tozihat);
                if (Check.Success == true && Check.Message == null)
                {
                    return new OperationResult
                    {
                        Success = true,
                        Message = "ثبت با موفقیت کامل شد"
                    };
                }
                else if (Check.Success == false && Check.Message != null)
                {
                    return new OperationResult
                    {
                        Success = true,
                        Message = "موجودی ناکافی"
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
        public OperationResult update(string CodeHoghogh, string ShomareHesab, string Nam,
           string Tarikh, string NoaHoghogh, string price, string Tozihat)
        {
            decimal price2;
            bool check1 = decimal.TryParse(price, out price2);
            if (string.IsNullOrEmpty(CodeHoghogh) || string.IsNullOrEmpty(ShomareHesab) ||
                string.IsNullOrEmpty(Nam) || string.IsNullOrEmpty(Tarikh) ||
                string.IsNullOrEmpty(NoaHoghogh) || string.IsNullOrEmpty(price))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else
            {
                var Check = HK.update(CodeHoghogh, ShomareHesab, Nam, Tarikh, NoaHoghogh, price2, Tozihat);
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
