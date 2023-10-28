using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Net;
using System.Security.Policy;
using System.Security.Cryptography;

namespace CarpetCompanyDAL
{
    public class classHazineEdari
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult Insert(string codeHazine, string shomareHesab, string namHazine,
            string tarikhPardakht, decimal price, string tozihat)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == shomareHesab).Single();
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
                            Message = "موجودی کافی نیست"
                        };
                    }
                }
                HazineEdari Edari= new HazineEdari();
                Edari.CodeHazine = codeHazine;
                Edari.ShomareHesab= shomareHesab;
                Edari.NamHazine = namHazine;
                Edari.TarikhPardakht = tarikhPardakht;
                Edari.price = price;
                Edari.Tozihat = tozihat;
                linq.HazineEdaris.InsertOnSubmit(Edari);
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
        public OperationResult Delete(string code)
        {
            try
            {
                int cod = int.Parse(code);
                var query = linq.HazineEdaris.Where(x => x.CodeHazine == code).Single();
                linq.HazineEdaris.DeleteOnSubmit(query);
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
        public OperationResult<List<HazineEdari>> Select(string search = "")
        {
            try
            {
                var query = linq.HazineEdaris.Where(x => x.CodeHazine.Contains(search)).ToList();
                return new OperationResult<List<HazineEdari>>
                {
                    Success = true,
                    Data = query
                };

            }
            catch
            {
                return new OperationResult<List<HazineEdari>>
                {
                    Success = false
                };
            }

        }
        public OperationResult<List<HazineEdari>> SelectCodeHazine(string search)
        {
            try
            {
                var query = linq.HazineEdaris.Where(x => x.CodeHazine == search).ToList();
                return new OperationResult<List<HazineEdari>>
                {
                    Success = true,
                    Data = query
                };

            }
            catch
            {
                return new OperationResult<List<HazineEdari>>
                {
                    Success = false
                };
            }

        }
        public OperationResult Update(string codeHazine, string shomareHesab, string namHazine,
            string tarikhPardakht, decimal price, string tozihat)
        {
            try
            {
                var query = linq.HazineEdaris.Where(x => x.CodeHazine == codeHazine).Single();
                if (query != null)
                {
                    query.ShomareHesab = shomareHesab;
                    query.NamHazine = namHazine;
                    query.TarikhPardakht = tarikhPardakht;
                    query.price = price;
                    query.Tozihat = tozihat;
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
