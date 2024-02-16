
namespace HotelManagementAF.EntityConfig;

public class ReservationConfig : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservation")
               .HasKey(r => r.Id);
        builder.Property(r => r.Fname)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.Lname)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.BirthDay)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.Gender)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.PhoneNumber)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.EmailAddress)
              .IsRequired()
              .HasMaxLength(-1); //means Max in Ef Core
        builder.Property(r => r.NumberGuest)
               .IsRequired();
        builder.Property(r => r.StreetAddress)
               .IsRequired()
               .HasMaxLength(-1);
        builder.Property(r => r.AptSuite)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.City)
               .IsRequired()
               .HasMaxLength(-1);
        builder.Property(r => r.State)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.ZipCode)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.RoomType)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.RoomFloor)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.RoomNumber)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.TotalBill)
               .IsRequired()
               .HasColumnType("float");
        builder.Property(r => r.PaymentType)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.CardType)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.CardNumber)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.CardExp)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(r => r.CardCvc)
               .IsRequired()
               .HasColumnType("nchar(10)");
        builder.Property(r => r.ArrivalTime)
               .IsRequired();
        builder.Property(r => r.LeavingTime)
               .IsRequired();
        builder.Property(r => r.CheckIn)
               .IsRequired();
        builder.Property(r => r.BreakFast)
               .IsRequired();
        builder.Property(r => r.Launch)
               .IsRequired();
        builder.Property(r => r.Dinner)
               .IsRequired();
        builder.Property(r => r.Cleaning)
               .IsRequired();
        builder.Property(r => r.Towel)
               .IsRequired();
        builder.Property(r => r.Surprise)
               .IsRequired();
        builder.Property(r => r.SupplyStatus)
               .IsRequired();
        builder.Property(r => r.FoodBill)
               .IsRequired();
    }
}
