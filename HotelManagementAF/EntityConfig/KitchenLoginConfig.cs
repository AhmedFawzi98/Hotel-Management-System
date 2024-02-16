
namespace HotelManagementAF.EntityConfig;

public class KitchenLoginConfig : IEntityTypeConfiguration<KitchenLogin>
{
    public void Configure(EntityTypeBuilder<KitchenLogin> builder)
    {
        builder.ToTable("Kitchen")
               .HasKey(k => k.UserName);
        builder.Property(k => k.UserName)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(k => k.Password)
               .IsRequired()
               .HasMaxLength(50);
    }
}
