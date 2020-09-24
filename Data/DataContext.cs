using Microsoft.EntityFrameworkCore;

using APICsharp.Models;

namespace APICsharp{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
               : base(options)
               {

               }

    
      public DbSet<Product>Products {get;set;}

      public DbSet<Cateogry> Categories {get;set;}
    }
}
