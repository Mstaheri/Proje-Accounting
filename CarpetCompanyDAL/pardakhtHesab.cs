using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    
    public class pardakhtHesab
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult<List<PardakhtAzHesab>> Select(string search)
        {
            try
            {
                var query = linq.PardakhtAzHesabs.Where(x => x.ShomareHesab.Contains(search)).ToList();
                return new OperationResult<List<PardakhtAzHesab>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<PardakhtAzHesab>>
                {
                    Success = false
                };
            }
        }
        public OperationResult<List<PardakhtAzHesab>> SelectCode(string search)
        {
            try
            {
                var query = linq.PardakhtAzHesabs.Where(x => x.CodePardakhti == search).ToList();
                return new OperationResult<List<PardakhtAzHesab>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<PardakhtAzHesab>>
                {
                    Success = false,
                };
            }
        }
        public OperationResult Delete(string code)
        {
            try
            {
                var query = linq.PardakhtAzHesabs.Where(x => x.CodePardakhti == code).Single();
                linq.PardakhtAzHesabs.DeleteOnSubmit(query);
                linq.SubmitChanges();
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
        public OperationResult Insert(string CodePardakhti, string ShomareHesab,
            string NamHesab, string NamPardakhtKonande, string TarikhPardakht,
            string Tozihat, decimal Price)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == ShomareHesab).Single();
                if(query != null)
                {
                    if (query.Mojodi >= Price)
                    {
                        query.Mojodi -= Price;
                    }
                    else
                    {
                        return new OperationResult
                        {
                            Success = false,
                            Message = "موجودی کافی نیست"
                        };
                    }
                }
                PardakhtAzHesab pardakhti = new PardakhtAzHesab();
                pardakhti.CodePardakhti = CodePardakhti;
                pardakhti.ShomareHesab = ShomareHesab;
                pardakhti.NamHesab = NamHesab;
                pardakhti.NamPardakhtKonande = NamPardakhtKonande;
                pardakhti.TarikhPardakht = TarikhPardakht;
                pardakhti.Tozihat = Tozihat;
                pardakhti.Price = Price;
                linq.PardakhtAzHesabs.InsertOnSubmit(pardakhti);
                linq.SubmitChanges();
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
