using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class classSenads
    {
        SenadHaDataContext linq = new SenadHaDataContext();
        public OperationResult<List<Senad>> Select(string search = "")
        {
            try
            {
                var query = linq.Senads.Where(x => x.ShomareSenad.Contains(search)).ToList();
                return new OperationResult<List<Senad>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch 
            {
                return new OperationResult<List<Senad>>
                {
                    Success = false
                };
            }
            
        }
        public OperationResult<List<Senad>> SelectShomareSenad(string search = "")
        {
            try
            {
                var query = linq.Senads.Where(x => x.SharheSenad == search).ToList();
                return new OperationResult<List<Senad>>
                {
                    Success = true,
                    Data = query
                };
            }
            catch
            {
                return new OperationResult<List<Senad>>
                {
                    Success = false
                };
            }

        }
        public OperationResult Delete(string Code)
        {
            try
            {
                var query = linq.Senads.Where(x => x.ShomareSenad == Code).ToList();
                linq.Senads.DeleteAllOnSubmit(query);
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
        public OperationResult<decimal> SumBedehkar()
        {
            try
            {
                var query = linq.Senads.Sum(x => x.Bedehkar);
                return new OperationResult<decimal>
                {
                    Success = true,
                    Data = (decimal)query
                };
            }
            catch 
            {
                return new OperationResult<decimal>
                {
                    Success = false
                };
            }
        }
        public OperationResult<decimal> SumBestankar()
        {
            try
            {
                var query = linq.Senads.Sum(x => x.Bestankar);
                return new OperationResult<decimal>
                {
                    Success = true,
                    Data = (decimal)query
                };
            }
            catch
            {
                return new OperationResult<decimal>
                {
                    Success = false
                };
            }


        }
        public OperationResult Insert(params string[] ListSenad)
        {
            try
            {
                Senad senadHa = new Senad();
                senadHa.ShomareSenad = ListSenad[0];
                senadHa.CodeKol = ListSenad[1];
                senadHa.CodeMoein = ListSenad[2];
                senadHa.CodeTafsili = ListSenad[3];
                senadHa.NamHesab = ListSenad[4];
                senadHa.SharheSenad = ListSenad[5];
                senadHa.TarikhSenad = ListSenad[6];
                senadHa.Bedehkar = decimal.Parse(ListSenad[7]);
                senadHa.Bestankar = decimal.Parse(ListSenad[8]);
                linq.Senads.InsertOnSubmit(senadHa);
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
        public OperationResult Update(params string[] ListSenad)
        {
            try
            {
                var query = linq.Senads.Where(x => x.ShomareSenad == ListSenad[0]).Single();
                if (query != null)
                {
                    query.CodeKol = ListSenad[1];
                    query.CodeMoein = ListSenad[2];
                    query.CodeTafsili = ListSenad[3];
                    query.NamHesab = ListSenad[4];
                    query.SharheSenad = ListSenad[5];
                    query.TarikhSenad = ListSenad[6];
                    query.Bedehkar = decimal.Parse(ListSenad[7]);
                    query.Bestankar = decimal.Parse(ListSenad[8]);
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
