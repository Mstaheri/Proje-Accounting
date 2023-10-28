using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class HoghoghKarmandan
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult<List<Hoghogh>> Select(string search = "")
        {
            try
            {
                var query = linq.Hoghoghs.Where(x => x.CodeHoghogh.Contains(search)).ToList();
                return new OperationResult<List<Hoghogh>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch (Exception)
            {
                return new OperationResult<List<Hoghogh>>
                {
                    Success = false,
                };
            }

        }
        public OperationResult Delete(string codeHoghogh)
        {
            try
            {
                var query = linq.Hoghoghs.Where(x => x.CodeHoghogh == codeHoghogh);
                linq.Hoghoghs.DeleteAllOnSubmit(query);
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
        public OperationResult Insert(string CodeHoghogh, string ShomareHesab, string Nam,
            string Tarikh, string NoaHoghogh, decimal price, string Tozihat)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == ShomareHesab).Single();
                if (query != null)
                {
                    if (query.Mojodi >= price)
                    {
                        query.Mojodi -= price;
                    }
                    else
                    {
                        return new OperationResult
                        {
                            Success = false,
                            Message = "موجودی ناکافی"
                        };
                    }
                }
                Hoghogh hogh = new Hoghogh();
                hogh.CodeHoghogh = CodeHoghogh;
                hogh.ShomareHesab = ShomareHesab;
                hogh.Nam = Nam;
                hogh.Tarikh = Tarikh;
                hogh.NoaHoghogh = NoaHoghogh;
                hogh.price = price;
                hogh.Tozihat = Tozihat;
                linq.Hoghoghs.InsertOnSubmit(hogh);
                linq.SubmitChanges();
                return new OperationResult
                {
                    Success = true,
                };
            }
            catch
            {
                return new OperationResult
                {
                    Success = false,
                };
            }

        }
        public OperationResult update(string CodeHoghogh, string ShomareHesab, string Nam,
             string Tarikh, string NoaHoghogh, decimal price, string Tozihat)
        {
            try
            {
                var query = linq.Hoghoghs.Where(x => x.CodeHoghogh == CodeHoghogh).Single();
                if (query != null)
                {
                    query.ShomareHesab = ShomareHesab;
                    query.Nam = Nam;
                    query.Tarikh = Tarikh;
                    query.NoaHoghogh = NoaHoghogh;
                    query.price = price;
                    query.Tozihat = Tozihat;
                }
                linq.SubmitChanges();
                return new OperationResult
                {
                    Success = true,
                };
            }
            catch
            {
                return new OperationResult
                {
                    Success = false,
                };
            }


        }
        public OperationResult<List<Hoghogh>> SelectCodeHoghogh(string search)
        {
            try
            {
                var query = linq.Hoghoghs.Where(x => x.CodeHoghogh == search).ToList();
                return new OperationResult<List<Hoghogh>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<Hoghogh>>
                {
                    Success = false
                };
            }
        }
    }
}
