using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class NorthwndContext : DbContext
    {
        public NorthwndContext() : base("Server=DESKTOP-0LOVGSG;Database=NORTHWND;Trusted_Connection=True;")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
