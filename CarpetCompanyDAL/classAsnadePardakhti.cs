using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class classAsnadePardakhti
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult<List<AsnadePardakhti>> Select(string search = "")
        {
            try
            {
                var query = linq.AsnadePardakhtis.Where(x => x.CodeSenad.Contains(search)).ToList();
                return new OperationResult<List<AsnadePardakhti>>
                {
                    Success = true,
                    Data = query
                };

            }
            catch
            {
                return new OperationResult<List<AsnadePardakhti>>
                {
                    Success = false
                };
            }
        }
        public OperationResult<List<AsnadePardakhti>> SelectCode(string search)
        {
            try
            {
                var query = linq.AsnadePardakhtis.Where(x => x.CodeSenad == search).ToList();
                return new OperationResult<List<AsnadePardakhti>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<AsnadePardakhti>>
                {
                    Success = false,
                };
            }
        }
        public OperationResult Delete(string CodeSenad)
        {
            try
            {
                var query = linq.AsnadePardakhtis.Where(x => x.CodeSenad == CodeSenad).Single();
                linq.AsnadePardakhtis.DeleteOnSubmit(query);
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
        public OperationResult Insert(params string[] ListDaryafti)
        {
            try
            {
                if (ListDaryafti[9] == "وصول شده")
                {
                    var query = linq.HesabMalis.Where(x => x.ShomareHesab == ListDaryafti[1]).Single();
                    if(query != null)
                    {
                        if (query.Mojodi >= decimal.Parse(ListDaryafti[7]))
                        {
                            query.Mojodi -= decimal.Parse(ListDaryafti[7]);
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
                }
                AsnadePardakhti pardakhti = new AsnadePardakhti();
                pardakhti.CodeSenad = ListDaryafti[0];
                pardakhti.ShomareHesab = ListDaryafti[1];
                pardakhti.NamHesab = ListDaryafti[2];
                pardakhti.PardakhteBe = ListDaryafti[3];
                pardakhti.ShomareSenad = ListDaryafti[4];
                pardakhti.TarikhSabt = ListDaryafti[5];
                pardakhti.TarikhSarResid = ListDaryafti[6];
                pardakhti.Price = decimal.Parse(ListDaryafti[7]);
                pardakhti.Tozihat = ListDaryafti[8];
                pardakhti.Vaziat = ListDaryafti[9];
                linq.AsnadePardakhtis.InsertOnSubmit(pardakhti);
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
        public OperationResult Update(params string[] ListDaryafti)
        {
            try
            {
                if (ListDaryafti[9] == "وصول شده")
                {
                    if (ListDaryafti[10] == "Edit")
                    {
                        var query2 = linq.HesabMalis.Where(x => x.ShomareHesab == ListDaryafti[1]).Single();
                        if(query2 != null)
                        {
                            if (query2.Mojodi >= decimal.Parse(ListDaryafti[7]))
                            {
                                query2.Mojodi -= decimal.Parse(ListDaryafti[7]);
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
                    }
                }
                var query = linq.AsnadePardakhtis.Where(x => x.CodeSenad == ListDaryafti[0]).Single();
                if(query != null )
                {
                    query.ShomareHesab = ListDaryafti[1];
                    query.NamHesab = ListDaryafti[2];
                    query.PardakhteBe = ListDaryafti[3];
                    query.ShomareSenad = ListDaryafti[4];
                    query.TarikhSabt = ListDaryafti[5];
                    query.TarikhSarResid = ListDaryafti[6];
                    query.Price = decimal.Parse(ListDaryafti[7]);
                    query.Tozihat = ListDaryafti[8];
                    query.Vaziat = ListDaryafti[9];
                }
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
