using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class classSenads
    {
        CarpetCompanyDAL.classSenads Senads = new CarpetCompanyDAL.classSenads();

        public OperationResult<List<Senad>> Select(string search = "")
        {
            var check = Senads.Select(search);
            if (check.Success == true)
            {
                return check;
            }
            else
            {
                return new OperationResult<List<Senad>>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
        }
        public OperationResult Delete(string CodeSenad)
        {
            var check = Senads.Delete(CodeSenad);
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
        public OperationResult<decimal> SumBedehkar()
        {
            var query = Senads.SumBedehkar();
            if (query.Success == true)
            {
                return query;
            }
            else
            {
                return new OperationResult<decimal>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }
            
        }
        public OperationResult<decimal> SumBestankar()
        {
            var query = Senads.SumBestankar();
            if (query.Success == true)
            {
                return query;
            }
            else
            {
                return new OperationResult<decimal>
                {
                    Success = false,
                    Message = "خطای رخ داده است لطفا با پشتیبان تماس بگیرید"
                };
            }

        }
        public OperationResult Insert(params string[] ListSenad)
        {
            decimal price;
            bool check1 = decimal.TryParse(ListSenad[0], out price);
            bool check2 = decimal.TryParse(ListSenad[7], out price);
            bool check3 = decimal.TryParse(ListSenad[8], out price);
            var check5 = Senads.SelectShomareSenad(ListSenad[0]);
            for (int i = 0; i < ListSenad.Length; i++)
            {
                if (i != 2 && i != 3)
                {
                    if (string.IsNullOrEmpty(ListSenad[i]))
                    {
                        return new OperationResult
                        {
                            Success = false,
                            Message = "لطفا همه اطلاعات را کامل پر کنید"
                        };
                    }
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
            else if (check1 == false || check2 == false || check3 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل شماره سند و بستانکار و بدهکار فقط باید عدد وارد شود"
                };
            }
            else
            {
                var Check = Senads.Insert(ListSenad[0], ListSenad[1], ListSenad[2], ListSenad[3], ListSenad[4],
                    ListSenad[5], ListSenad[6], ListSenad[7], ListSenad[8]);
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
        public OperationResult Update(params string[] ListSenad)
        {
            decimal price;
            bool check1 = decimal.TryParse(ListSenad[0], out price);
            bool check2 = decimal.TryParse(ListSenad[7], out price);
            bool check3 = decimal.TryParse(ListSenad[8], out price);
            for (int i = 0; i < ListSenad.Length; i++)
            {
                if (i != 2 && i != 3)
                {
                    if (string.IsNullOrEmpty(ListSenad[i]))
                    {
                        return new OperationResult
                        {
                            Success = false,
                            Message = "لطفا همه اطلاعات را کامل پر کنید"
                        };
                    }
                }

            }
            if (check1 == false || check2 == false || check3 == false)
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "داخل شماره سند و بستانکار و بدهکار فقط باید عدد وارد شود"
                };
            }
            else
            {
                var Check = Senads.Update(ListSenad[0], ListSenad[1], ListSenad[2], ListSenad[3], ListSenad[4],
                    ListSenad[5], ListSenad[6], ListSenad[7], ListSenad[8]);
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
