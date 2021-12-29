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
    class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        public ProductsRepository(DbContext context) : base(context)
        {

        }
        public IQueryable ProductsReport()
        {
            return dbset.AsQueryable();
        }
    }
}
