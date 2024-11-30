using ChatApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApplication.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Name).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Surname).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(50);

            //builder.HasMany(c => c.Users)
            //    .WithOne(ma => ma.Actor)
            //    .HasForeignKey(ma => ma.ActorId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
