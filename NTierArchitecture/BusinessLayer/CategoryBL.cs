using DataAccessLayer.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryBL
    {
        public List<Category> GetCategories()
        {
            CategoryRepository cr = new CategoryRepository();
            var categories = cr.GetCategories();
            return categories;
        }
        
    }
}
