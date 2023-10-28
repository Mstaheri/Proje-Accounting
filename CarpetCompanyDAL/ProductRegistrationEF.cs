using CarpetCompanyDAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class ProductRegistrationEF
    {
        public OperationResult Insert(string ProductCode, string ProductName, string Unit
            , string PurchasePrice, string SalesPrice, string BarCode)
        {
            try
            {
                int Purchase = int.Parse(PurchasePrice);
                int Sales = int.Parse(SalesPrice);
                ProductRegistration Product = new ProductRegistration()
                {
                    ProductCode = ProductCode,
                    ProductName = ProductName,
                    Unit = Unit,
                    PurchasePrice = Purchase,
                    SalesPrice = Sales,
                    BarCode = BarCode
                };
                MyDbContext db = new MyDbContext();
                db.ProductRegistrations.Add(Product);
                db.SaveChanges();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch
            {
                return new OperationResult
                {
                    Success = false
                };
            }

        }
        public OperationResult Delete(string code)
        {
            try
            {
                MyDbContext db = new MyDbContext();
                var query = db.ProductRegistrations.Single(x => x.ProductCode == code);
                db.ProductRegistrations.Remove(query);
                db.SaveChanges();
                return new OperationResult
                {
                    Success = true
                };

            }
            catch
            {
                return new OperationResult
                {
                    Success = false
                };
            }
        }
       
        public OperationResult Updat(string ProductCode, string ProductName, string Unit
            , string PurchasePrice, string SalesPrice, string BarCode)
        {
            try
            {
                int Purchase = int.Parse(PurchasePrice);
                int Sales = int.Parse(SalesPrice);
                MyDbContext db = new MyDbContext();
                var Product = db.ProductRegistrations.Where(x => x.ProductCode == ProductCode).Single();
                Product.ProductName = ProductName;
                Product.Unit = Unit;
                Product.PurchasePrice = Purchase;
                Product.SalesPrice = Sales;
                Product.BarCode = BarCode;
                db.SaveChanges();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch
            {
                return new OperationResult
                {
                    Success = false
                };
            }
        }
    }
    

}
