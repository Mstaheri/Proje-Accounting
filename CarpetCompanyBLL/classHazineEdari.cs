using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classHazineEdari
    {
        CarpetCompanyDAL.classHazineEdari rec = new CarpetCompanyDAL.classHazineEdari();
        public OperationResult Insert(string codeHazine, string shomareHesab, string namHazine,
            string tarikhPardakht, string price, string tozihat)
        {
            decimal price2;
            decimal code2;
            bool check3 = decimal.TryParse(codeHazine, out code2);
            bool check2 = decimal.TryParse(price , out price2);
            var check1 = rec.SelectCodeHazine(codeHazine);
            if (string.IsNullOrEmpty(codeHazine) || string.IsNullOrEmpty(shomareHesab) ||
                string.IsNullOrEmpty(namHazine) || string.IsNullOrEmpty(tarikhPardakht) ||
                string.IsNullOrEmpty(price) || string.IsNullOrEmpty(tozihat))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else if(check1.Data.Count > 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد هزینه تکراری است"
                };
            }
            else if (check2 == false || check3 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل کد هزینه و مبلغ فقط باید عدد وارد کرد"
                };
            }
            else
            {
                var Check = rec.Insert(codeHazine, shomareHesab, namHazine, tarikhPardakht, price2, tozihat);
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
                        Message = "موجودی حساب کافی نیست"
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
        public OperationResult Delete(string code)
        {
            var Check = rec.Delete(code);
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
        public OperationResult<List<HazineEdari>> Select(string search = "")
        {
            var Check = rec.Select(search);
            if (Check.Success == false)
            {
                return new OperationResult<List<HazineEdari>>
                {
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
            else
            {
                return Check;
            }
        }
        public OperationResult Update(string codeHazine, string shomareHesab, string namHazine,
            string tarikhPardakht, string price, string tozihat)
        {
            decimal price2 = decimal.Parse(price);
            if (string.IsNullOrEmpty(codeHazine) || string.IsNullOrEmpty(shomareHesab) ||
                string.IsNullOrEmpty(namHazine) || string.IsNullOrEmpty(tarikhPardakht) ||
                string.IsNullOrEmpty(price) || string.IsNullOrEmpty(tozihat))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else
            {
                var Check = rec.Update(codeHazine, shomareHesab, namHazine, tarikhPardakht, price2, tozihat);
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
