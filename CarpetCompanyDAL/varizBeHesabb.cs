using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class varizBeHesabb
    {
        MaliDataContext linq = new MaliDataContext();
        public OperationResult<List<VarizBeHesab>> Select(string search = "")
        {
            try
            {
                var query = linq.VarizBeHesabs.Where(x => x.ShomareHesab.Contains(search)).ToList();
                return new OperationResult<List<VarizBeHesab>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch 
            {
                return new OperationResult<List<VarizBeHesab>>
                {
                    Success = false,
                };
            }
            
        }
        public OperationResult<List<VarizBeHesab>> SelectCode(string search)
        {
            try
            {
                var query = linq.VarizBeHesabs.Where(x => x.CodeVariz == search).ToList();
                return new OperationResult<List<VarizBeHesab>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<VarizBeHesab>>
                {
                    Success = false,
                };
            }

        }
        public OperationResult Insert(string CodeVariz , string ShomareHesab ,
            string NamHesab, string NamVarizKonande,string TarikhVarizi,
            string Tozihat ,decimal Price)
        {
            try
            {
                var query = linq.HesabMalis.Where(x => x.ShomareHesab == ShomareHesab).Single();
                if (query != null)
                {
                    query.Mojodi += Price;
                }               
                VarizBeHesab varizs = new VarizBeHesab();
                varizs.CodeVariz = CodeVariz;
                varizs.ShomareHesab = ShomareHesab;
                varizs.NamHesab = NamHesab;
                varizs.NamVarizKonande = NamVarizKonande;
                varizs.TarikhVarizi = TarikhVarizi;
                varizs.Tozihat = Tozihat;
                varizs.Price = Price;
                linq.VarizBeHesabs.InsertOnSubmit(varizs);
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
        public OperationResult Delete(string code)
        {
            try
            {
                var query = linq.VarizBeHesabs.Where(x => x.CodeVariz == code).Single();
                linq.VarizBeHesabs.DeleteOnSubmit(query);
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
    }
}
