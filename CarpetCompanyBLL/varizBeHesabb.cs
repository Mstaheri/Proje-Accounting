using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class varizBeHesabb
    {
        CarpetCompanyDAL.varizBeHesabb varizs = new CarpetCompanyDAL.varizBeHesabb();

        public OperationResult<List<VarizBeHesab>> Select(string search = "")
        {
            var check = varizs.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<VarizBeHesab>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string code)
        {
            var check = varizs.Delete(code);
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
        public OperationResult Insert(string CodeVariz, string shomareHesab, string NamHesab,
            string NamVarizKonande, string TarikhVarizi, string Tozihat, string Price)
        {
            CarpetCompanyBLL.Mali mal = new CarpetCompanyBLL.Mali();
            var Check1 = mal.Select(shomareHesab);
            decimal Pricee;
            bool check2 = decimal.TryParse(Price, out Pricee);
            var check4 = varizs.SelectCode(CodeVariz);
            if (string.IsNullOrEmpty(CodeVariz) || string.IsNullOrEmpty(shomareHesab) ||
                string.IsNullOrEmpty(NamHesab) || string.IsNullOrEmpty(NamVarizKonande) ||
                string.IsNullOrEmpty(TarikhVarizi) || string.IsNullOrEmpty(Price))
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
                    Message = "کد واریز تکراری است"
                };
            }
            else if (shomareHesab.Length != 19)
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
                var Check = varizs.Insert(CodeVariz, shomareHesab, NamHesab, NamVarizKonande, TarikhVarizi, Tozihat, Pricee);
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
