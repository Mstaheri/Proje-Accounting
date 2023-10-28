using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class Mali
    {
        CarpetCompanyDAL.Mali mal = new CarpetCompanyDAL.Mali();
        public OperationResult<List<HesabMali>> Select(string search = "")
        {
            var check = mal.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<HesabMali>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult<List<string>> SelectShomareHesab()
        {
            var check = mal.SelectShomareHesab();
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
        public OperationResult Delete(string shomareHesab)
        {
            var check = mal.Delete(shomareHesab);
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
        public OperationResult Insert(string ShomareHesab, string SahebHesab, string NamHesab,
            string NamBank, string Tozihat, string Mojodi)
        {
            decimal mojodi;
            bool check1 = decimal.TryParse(Mojodi, out mojodi);
            var check3 = mal.Select(ShomareHesab);
            if (string.IsNullOrEmpty(ShomareHesab) || string.IsNullOrEmpty(SahebHesab) ||
                string.IsNullOrEmpty(NamHesab) || string.IsNullOrEmpty(NamBank) ||
                string.IsNullOrEmpty(Mojodi))
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
                    Message = "این شماره حساب قبلا وارد شده"
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
                var Check = mal.Insert(ShomareHesab, SahebHesab, NamHesab, NamBank, Tozihat, mojodi);
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
        public OperationResult Update(string shomareHesab, string SahebHesab, string NamHesab,
            string NamBank, string Tozihat, string Mojodi)
        {
            decimal mojodi;
            bool check1 = decimal.TryParse(Mojodi, out mojodi);
            if (string.IsNullOrEmpty(shomareHesab) || string.IsNullOrEmpty(SahebHesab) ||
                string.IsNullOrEmpty(NamHesab) || string.IsNullOrEmpty(NamBank) ||
                string.IsNullOrEmpty(Mojodi))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else if (check1 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل موجودی فقط باید هدد وارد کرد"
                };
            }
            else
            {
                var Check = mal.Update(shomareHesab, SahebHesab, NamHesab, NamBank, Tozihat, mojodi);
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
