using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classAsnadeDaryafti
    {
        CarpetCompanyDAL.classAsnadeDaryafti Daryafti = new CarpetCompanyDAL.classAsnadeDaryafti();
        CarpetCompanyDAL.Mali mal = new CarpetCompanyDAL.Mali();

        public OperationResult<List<AsnadeDaryafti>> Select(string search = "")
        {
            var check = Daryafti.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<AsnadeDaryafti>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string CodeSenad)
        {
            var check = Daryafti.Delete(CodeSenad);
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
        public OperationResult Insert(params string[] ListDaryafti)
        {
            decimal price;
            bool check1 = decimal.TryParse(ListDaryafti[7], out price);
            bool check3 = decimal.TryParse(ListDaryafti[4], out price);
            var check4 = mal.Select(ListDaryafti[1]);
            var check5 = Daryafti.SelectCode(ListDaryafti[0]);
            for (int i = 0; i < ListDaryafti.Length; i++)
            {
                if (string.IsNullOrEmpty(ListDaryafti[i]))
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "لطفا همه اطلاعات را کامل پر کنید"
                    };
                }
            }
            if (check5.Data.Count > 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد سند تکراری است"
                };
            }
            else if (ListDaryafti[1].Length != 19)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره حساب معتبر وارد کنید"
                };
            }
            else if (check4.Data.Count == 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره حساب وجود ندارد"
                };
            }
            else if (check1 == false || check3 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل مبلغ و شماره سند فقط باید عدد وارد کرد"
                };
            }
            else
            {
                var Check = Daryafti.Insert(ListDaryafti[0], ListDaryafti[1], ListDaryafti[2], ListDaryafti[3], ListDaryafti[4],
                    ListDaryafti[5], ListDaryafti[6], ListDaryafti[7], ListDaryafti[8], ListDaryafti[9]);
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
        public OperationResult Update(params string[] ListDaryafti)
        {
            decimal price;
            bool check1 = decimal.TryParse(ListDaryafti[7], out price);
            bool check3 = decimal.TryParse(ListDaryafti[4], out price);
            var check4 = mal.Select(ListDaryafti[1]);
            for (int i = 0; i < ListDaryafti.Length; i++)
            {
                if (string.IsNullOrEmpty(ListDaryafti[i]))
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "لطفا همه اطلاعات را کامل پر کنید"
                    };
                }
            }
            if (ListDaryafti[1].Length != 19)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره حساب معتبر وارد کنید"
                };
            }
            else if (check4.Data.Count == 0)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره حساب وجود ندارد"
                };
            }
            else if (check1 == false || check3 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل مبلغ و شماره سند فقط باید عدد وارد کرد"
                };
            }
            else
            {
                var Check = Daryafti.Update(ListDaryafti[0], ListDaryafti[1], ListDaryafti[2], ListDaryafti[3], ListDaryafti[4],
                    ListDaryafti[5], ListDaryafti[6], ListDaryafti[7], ListDaryafti[8], ListDaryafti[9], ListDaryafti[10]);
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
