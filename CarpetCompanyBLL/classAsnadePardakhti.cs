using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classAsnadePardakhti
    {
        CarpetCompanyDAL.classAsnadePardakhti pardakhti = new CarpetCompanyDAL.classAsnadePardakhti();
        CarpetCompanyDAL.Mali mal = new CarpetCompanyDAL.Mali();

        public OperationResult<List<AsnadePardakhti>> Select(string search = "")
        {
            var check = pardakhti.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<AsnadePardakhti>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string CodeSenad)
        {
            var check = pardakhti.Delete(CodeSenad);
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
        public OperationResult Insert(params string[] ListPardakhti)
        {
            decimal price;
            bool check1 = decimal.TryParse(ListPardakhti[7], out price);
            bool check3 = decimal.TryParse(ListPardakhti[4], out price);
            var check4 = mal.Select(ListPardakhti[1]);
            var check5 = pardakhti.SelectCode(ListPardakhti[0]);
            for (int i = 0; i < ListPardakhti.Length; i++)
            {
                if (string.IsNullOrEmpty(ListPardakhti[i]))
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
            else if (ListPardakhti[1].Length != 19)
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
                var Check = pardakhti.Insert(ListPardakhti[0], ListPardakhti[1], ListPardakhti[2], ListPardakhti[3], ListPardakhti[4],
                    ListPardakhti[5], ListPardakhti[6], ListPardakhti[7], ListPardakhti[8], ListPardakhti[9]);
                if (Check.Success == true)
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
        public OperationResult Update(params string[] ListPardakhti)
        {
            decimal price;
            bool check1 = decimal.TryParse(ListPardakhti[7], out price);
            bool check3 = decimal.TryParse(ListPardakhti[4], out price);
            var check4 = mal.Select(ListPardakhti[1]);
            for (int i = 0; i < ListPardakhti.Length; i++)
            {
                if (string.IsNullOrEmpty(ListPardakhti[i]))
                {   
                    return new OperationResult
                    {
                        Success = false,
                        Message = "لطفا همه اطلاعات را کامل پر کنید"
                    };
                }
            }
            if (ListPardakhti[1].Length != 19)
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
                var Check = pardakhti.Update(ListPardakhti[0], ListPardakhti[1], ListPardakhti[2], ListPardakhti[3], ListPardakhti[4],
                    ListPardakhti[5], ListPardakhti[6], ListPardakhti[7], ListPardakhti[8], ListPardakhti[9], ListPardakhti[10]);
                if (Check.Success == true)
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
