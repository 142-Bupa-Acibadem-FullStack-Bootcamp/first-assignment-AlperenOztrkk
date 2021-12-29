using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CustomerCustomerDemoRepository : GenericRepository<CustomerCustomerDemo>, ICustomerCustomerDemoRepository
    {
        public CustomerCustomerDemoRepository(DbContext contex) : base(contex)
        {

        } 
        public IQueryable CustomerDemoReport()
        {
            return dbset.AsQueryable();
        }
    }
}
