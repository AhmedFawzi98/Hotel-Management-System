namespace HotelManagementAF.Context;

public class ReservationContext : DbContext
{
    public virtual DbSet<Reservation> Reservations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ReservationConfig());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FrontEnd_Reservation_AF;integrated Security=true;Encrypt=false");
}