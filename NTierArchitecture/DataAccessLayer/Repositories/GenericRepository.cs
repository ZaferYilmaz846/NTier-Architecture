using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>filter = null)
        {
            using (NorthwndContext context = new NorthwndContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>>filter = null)
        {
            using (NorthwndContext context = new NorthwndContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        
    }
}
