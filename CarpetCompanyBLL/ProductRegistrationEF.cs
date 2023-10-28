using CarpetCompanyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyBLL
{
    public class ProductRegistrationEF
    {
        CarpetCompanyDAL.ProductRegistrationEF rec = new CarpetCompanyDAL.ProductRegistrationEF();
        public OperationResult Insert(string ProductCode, string ProductName, string Unit
            , string PurchasePrice, string SalesPrice, string BarCode)
        {
            if (string.IsNullOrEmpty(ProductCode) || string.IsNullOrEmpty(ProductName) ||
                string.IsNullOrEmpty(Unit) || string.IsNullOrEmpty(PurchasePrice) ||
                string.IsNullOrEmpty(SalesPrice) || string.IsNullOrEmpty(BarCode))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else
            {
                var Check = rec.Insert(ProductCode, ProductName, Unit, PurchasePrice, SalesPrice, BarCode);
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
        public OperationResult Updat(string ProductCode, string ProductName, string Unit
            , string PurchasePrice, string SalesPrice, string BarCode)
        {
            if (string.IsNullOrEmpty(ProductCode) || string.IsNullOrEmpty(ProductName) ||
                string.IsNullOrEmpty(Unit) || string.IsNullOrEmpty(PurchasePrice) ||
                string.IsNullOrEmpty(SalesPrice) || string.IsNullOrEmpty(BarCode))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "لطفا همه اطلاعات را کامل پر کنید"
                };
            }
            else
            {
                var Check = rec.Updat(ProductCode, ProductName, Unit, PurchasePrice, SalesPrice, BarCode);
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
