using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class Mali
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult<List<HesabMali>> Select(string search = "")
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab.Contains(search)).ToList();
                return new OperationResult<List<HesabMali>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabMali>>
                {
                    Success = false,
                };
            }
        }
        public OperationResult<string> SelectNamHesab(string search)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == search).Select(x => x.NamHesab).Single();
                return new OperationResult<string>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<string>
                {
                    Success = false,
                };
            }
        }
        public OperationResult Delete(string ShomareHesab)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == ShomareHesab);
                linq.HesabMalis.DeleteAllOnSubmit(query);
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
        public OperationResult Insert(string shomareHesab, string SahebHesab, string NamHesab,
            string NamBank, string Tozihat, decimal Mojodi)
        {
            try
            {
                HesabMali hesabs = new HesabMali();
                hesabs.ShomareHesab = shomareHesab;
                hesabs.SahebHesab = SahebHesab;
                hesabs.NamHesab = NamHesab;
                hesabs.NamBank = NamBank;
                hesabs.Tozihat = Tozihat;
                hesabs.Mojodi = Mojodi;
                linq.HesabMalis.InsertOnSubmit(hesabs);
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
        public OperationResult Update(string shomareHesab, string SahebHesab, string NamHesab,
            string NamBank, string Tozihat, decimal Mojodi)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == shomareHesab).Single();
                if (query != null)
                {
                    query.SahebHesab = SahebHesab;
                    query.NamHesab = NamHesab;
                    query.NamBank = NamBank;
                    query.Tozihat = Tozihat;
                    query.Mojodi = Mojodi;
                    linq.SubmitChanges();
                }
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
        public OperationResult<List<string>> SelectShomareHesab()
        {
            try
            {
                var query = linq.HesabMalis.Select(x => x.ShomareHesab).ToList();
                return new OperationResult<List<string>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch 
            {
                return new OperationResult<List<string>>
                {
                    Success = false
                };
            }
            
        }
    }
}
