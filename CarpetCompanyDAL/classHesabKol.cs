using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CarpetCompanyDAL
{
    public class classHesabKol
    {
        SenadHaDataContext senad = new SenadHaDataContext();
        public OperationResult<List<HesabKol>> Select(string serach)
        {
            try
            {
                var query = senad.HesabKols.Where(x => x.CodeKol.Contains(serach)).ToList();
                return new OperationResult<List<HesabKol>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch 
            {
                return new OperationResult<List<HesabKol>>
                {
                    Success = false
                };
            }
            
        }
        public OperationResult<List<string>> SelectAllCodeKol()
        {
            try
            {
                var query = senad.HesabKols.Select(x => x.CodeKol).ToList();
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
        public OperationResult<List<HesabKol>> SelectCodeKol(string serach)
        {
            try
            {
                var query = senad.HesabKols.Where(x => x.CodeKol == serach).ToList();
                return new OperationResult<List<HesabKol>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabKol>>
                {
                    Success = false
                };
            }

        }
        public OperationResult Delete(string CodeKol)
        {
            try
            {
                var query = senad.HesabKols.Where(x => x.CodeKol == CodeKol);
                senad.HesabKols.DeleteAllOnSubmit(query);
                senad.SubmitChanges();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch (Exception)
            {
                return new OperationResult
                {
                    Success = false
                };
                    
            }
            
        }
        public OperationResult Insert(string CodeKol,string OnvanKol)
        {
            try
            {
                HesabKol kol = new HesabKol();
                kol.CodeKol = CodeKol;
                kol.OnvanKol = OnvanKol;
                senad.HesabKols.InsertOnSubmit(kol);
                senad.SubmitChanges();
                return new OperationResult
                { Success = true };
            }
            catch (Exception)
            {
                return new OperationResult
                { Success = false };
            }
            
        }

    }
}
