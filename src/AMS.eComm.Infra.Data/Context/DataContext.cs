using AMS.eComm.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.eComm.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) :base (options){}
        public DbSet<Product> Product { get; set; }
        public DbSet<Color> Color { get; set; }
    }
}