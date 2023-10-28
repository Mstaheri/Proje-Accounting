using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class classHesabTafsili
    {
        SenadHaDataContext senad = new SenadHaDataContext();
        public OperationResult<List<HesabTafsili>> Select(string serach)
        {
            try
            {
                var query = senad.HesabTafsilis.Where(x => x.CodeTafsili.Contains(serach)).ToList();
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = false
                };
            }
        }

        public OperationResult<List<HesabTafsili>> SelectCodeTafsili(string serach)
        {
            try
            {
                var query = senad.HesabTafsilis.Where(x => x.CodeTafsili == serach).ToList();
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = false
                };
            }
        }
        public OperationResult<List<HesabTafsili>> SelectCodeMion(string serach)
        {
            try
            {
                var query = senad.HesabTafsilis.Where(x => x.CodeMoin == serach).ToList();
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<HesabTafsili>>
                {
                    Success = false
                };
            }
        }
        public OperationResult Delete(string CodeTafsili)
        {
            try
            {
                var query = senad.HesabTafsilis.Where(x => x.CodeTafsili == CodeTafsili);
                senad.HesabTafsilis.DeleteAllOnSubmit(query);
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
        public OperationResult Insert(string CodeTafsili, string OnvanTafsili, string CodeMoin)
        {
            try
            {
                HesabTafsili Tafsili = new HesabTafsili();
                Tafsili.CodeTafsili = CodeTafsili;
                Tafsili.OnvanTafsili = OnvanTafsili;
                Tafsili.CodeMoin = CodeMoin;
                senad.HesabTafsilis.InsertOnSubmit(Tafsili);
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
