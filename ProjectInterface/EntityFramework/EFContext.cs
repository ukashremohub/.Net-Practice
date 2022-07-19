namespace ProjectInterface.EntityFramework;
public class EFContext : DbContext
{
     // private string ConnectionStrings = ConfigurationManager.AppSettings["ConnectionStrings"];

    private const string ConnectionStrings = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionStrings);
    }

    public DbSet<MenuCardModel> MenuCard { get; set; }
    public DbSet<RoomsModel> Rooms { get; set; }
}
