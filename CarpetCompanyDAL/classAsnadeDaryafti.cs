using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class classAsnadeDaryafti
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult<List<AsnadeDaryafti>> Select(string search = "")
        {
            try
            {
                var query = linq.AsnadeDaryaftis.Where(x => x.CodeSenad.Contains(search)).ToList();
                return new OperationResult<List<AsnadeDaryafti>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<AsnadeDaryafti>>
                {
                    Success = false
                };
            }
        }
        public OperationResult<List<AsnadeDaryafti>> SelectCode(string search)
        {
            try
            {
                var query = linq.AsnadeDaryaftis.Where(x => x.CodeSenad == search).ToList();
                return new OperationResult<List<AsnadeDaryafti>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<AsnadeDaryafti>>
                {
                    Success = false,
                };
            }
        }
        public OperationResult Delete(string CodeSenad)
        {
            try
            {
                var query = linq.AsnadeDaryaftis.Where(x => x.CodeSenad == CodeSenad).Single();
                linq.AsnadeDaryaftis.DeleteOnSubmit(query);
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
                        query.Mojodi += decimal.Parse(ListDaryafti[7]);
                    }
                }
                AsnadeDaryafti daryafti = new AsnadeDaryafti();
                daryafti.CodeSenad = ListDaryafti[0];
                daryafti.ShomareHesab = ListDaryafti[1];
                daryafti.NamHesab = ListDaryafti[2];
                daryafti.DaryaftAz = ListDaryafti[3];
                daryafti.ShomareSenad = int.Parse(ListDaryafti[4]);
                daryafti.TarikhSabt = ListDaryafti[5];
                daryafti.TarikhSarResid = ListDaryafti[6];
                daryafti.Price = decimal.Parse(ListDaryafti[7]);
                daryafti.Tozihat = ListDaryafti[8];
                daryafti.Vaziat = ListDaryafti[9];
                linq.AsnadeDaryaftis.InsertOnSubmit(daryafti);
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
                            query2.Mojodi += decimal.Parse(ListDaryafti[7]);
                        }
                    }
                }
                var query = linq.AsnadeDaryaftis.Where(x => x.CodeSenad == ListDaryafti[0]).Single();
                if(query != null )
                {
                    query.ShomareHesab = ListDaryafti[1];
                    query.NamHesab = ListDaryafti[2];
                    query.DaryaftAz = ListDaryafti[3];
                    query.ShomareSenad = int.Parse(ListDaryafti[4]);
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
