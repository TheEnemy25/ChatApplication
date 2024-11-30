using ChatApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApplication.Data.EntityConfigurations
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("Chat");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);

            //builder.HasMany(c => c.Users)
            //    .WithOne(ma => ma.Actor)
            //    .HasForeignKey(ma => ma.ActorId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
