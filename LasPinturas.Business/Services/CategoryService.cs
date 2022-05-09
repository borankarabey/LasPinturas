using LasPinturas.DataAccess.Data;
using LasPinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasPinturas.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private LasPinturasDbContext dbContext;

        public CategoryService(LasPinturasDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IList<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }
    }
}
