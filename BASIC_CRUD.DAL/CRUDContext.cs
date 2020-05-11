using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BASIC_CRUD.Entity;
using System.Data.Entity;

namespace BASIC_CRUD.DAL
{
    public class CRUDContext : DbContext
    {
        public CRUDContext() : base("DefaultConnection")
        {

        }
        public DbSet<Category> categoryList { get; set; }

        public DbSet<Product> productDetails { get; set; }
    }
}