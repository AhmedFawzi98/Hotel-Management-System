namespace HotelManagementAF.Context;

public class LoginContext : DbContext
{
    public virtual DbSet<FrontEndLogin> FrontEndLogins { get; set; }
    public virtual DbSet<KitchenLogin> KitchenLogins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new KitchenLoginConfig());
        modelBuilder.ApplyConfiguration(new FrontEndLoginConfig());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Login_Manager_AF;integrated Security=true;Encrypt=false");
}