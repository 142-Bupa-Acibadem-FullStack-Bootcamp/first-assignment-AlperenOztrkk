using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(DbContext context) : base(context)
        {

        }
        public IQueryable CategoriesReport()
        {
            return dbset.AsQueryable();
        }
    }






}

