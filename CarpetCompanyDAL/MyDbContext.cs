using CarpetCompanyDAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():base("Data Source=.;Initial Catalog=CarpetCompany;Integrated Security=True")
        {

        }
        public DbSet<ProductRegistration> ProductRegistrations { get; set; }
    }
}
