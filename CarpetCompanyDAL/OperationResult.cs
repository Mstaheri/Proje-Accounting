using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Jobs { get; set; }
    }
    public class OperationResult<T>: OperationResult
    {
        public T Data { get; set; }
    }
}
