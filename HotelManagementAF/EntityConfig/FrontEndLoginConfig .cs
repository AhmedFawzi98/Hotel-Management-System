
namespace HotelManagementAF.EntityConfig;

public class FrontEndLoginConfig : IEntityTypeConfiguration<FrontEndLogin>
{
    public void Configure(EntityTypeBuilder<FrontEndLogin> builder)
    {
        builder.ToTable("FrontEnd")
               .HasKey(F => F.UserName);
        builder.Property(F => F.UserName)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(F => F.Password)
               .IsRequired()
               .HasMaxLength(50);
    }
}
