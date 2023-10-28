using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class classHesabMoin
    {
        SenadHaDataContext senad = new SenadHaDataContext();
        public OperationResult<List<HesabMoin>> Select(string serach)
        {
            try
            {
                var query = senad.HesabMoins.Where(x => x.CodeMoin.Contains(serach)).ToList();
                return new OperationResult<List<HesabMoin>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabMoin>>
                {
                    Success = false
                };
            }
        }
        public OperationResult<List<string>> SelectAllCodeMoin()
        {
            try
            {
                var query = senad.HesabMoins.Select(x => x.CodeMoin).ToList();
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
        public OperationResult<List<HesabMoin>> SelectCodeMoin(string serach)
        {
            try
            {
                var query = senad.HesabMoins.Where(x => x.CodeMoin == serach).ToList();
                return new OperationResult<List<HesabMoin>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabMoin>>
                {
                    Success = false
                };
            }
        }
        public OperationResult<List<HesabMoin>> SelectCodeKol(string serach)
        {
            try
            {
                var query = senad.HesabMoins.Where(x => x.CodeKol == serach).ToList();
                return new OperationResult<List<HesabMoin>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabMoin>>
                {
                    Success = false
                };
            }
        }
        public OperationResult Delete(string CodeMoin)
        {
            try
            {
                var query = senad.HesabMoins.Where(x => x.CodeMoin == CodeMoin);
                senad.HesabMoins.DeleteAllOnSubmit(query);
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
        public OperationResult Insert(string CodeMoin, string OnvanMoin,string CodeKol)
        {
            try
            {
                HesabMoin Moin = new HesabMoin();
                Moin.CodeMoin = CodeMoin;
                Moin.OnvanMoin = OnvanMoin;
                Moin.CodeKol= CodeKol;
                senad.HesabMoins.InsertOnSubmit(Moin);
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
