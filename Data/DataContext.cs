using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Manage_Library2._0.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        public DbSet<Book> Books => Set<Book>();
    }
}

/*
DataContext hereda de DbContext, la clase DataContext debe exponer un constructor publico con el parametro (DbContextOptions<DataContext> options)
DataContext luego se puede usar en controladores ASP.NET Core u otros servicios a través de la inyección del constructor
*/