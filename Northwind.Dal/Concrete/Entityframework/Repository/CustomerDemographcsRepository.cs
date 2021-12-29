using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CustomerDemographcsRepository : GenericRepository<CustomerDemographic>, ICustomerDemographcsRepository
    {
        public CustomerDemographcsRepository(DbContext context) : base(context)
        {

        }
        public IQueryable CustomerDemographcsReport()
        {
            return dbset.AsQueryable();
        }
    }
}
