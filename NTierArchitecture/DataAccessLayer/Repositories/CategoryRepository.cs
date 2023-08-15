using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public List<Category> GetCategories()
        {
            return GetAll();
        }
        public Category GetByCategoryId(int categoryId)
        {
            return Get(c => c.CategoryID == categoryId);
        }
    }
}
