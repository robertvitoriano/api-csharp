using Microsoft.EntityFrameworkCore;

using APICsharp.Models;

namespace APICsharp.Data{

    public class DataContext : DbContext
    {
        // Método construtor
        public DataContext(DbContextOptions<DataContext> options)
               : base(options)
               {

               }
  
    
      public DbSet<Product>Products {get;set;}

      public DbSet<Category> Categories {get;set;}
    }
}
