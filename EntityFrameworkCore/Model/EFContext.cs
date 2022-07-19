using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Model
{
    //The DBContext class manages the entity classes or models. It is the heart of the Entity Framework Core.
    public class EFContext : DbContext 
    {
        private const string ConnectionStrings = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EntityFrameworkCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings);
        }

        public DbSet<Product> Products { get; set; }
    }
}




