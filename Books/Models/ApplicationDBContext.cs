using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Books.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext():base("DefaultConnection")
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }


    }
}