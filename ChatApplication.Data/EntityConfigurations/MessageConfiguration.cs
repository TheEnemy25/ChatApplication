using ChatApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApplication.Data.EntityConfigurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Message");

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Content).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Timestamp).IsRequired();
            builder.Property(m => m.Sentiment).IsRequired().HasMaxLength(50);
            builder.Property(m => m.IsRead);

            //builder.HasMany(c => c.Users)
            //    .WithOne(ma => ma.Actor)
            //    .HasForeignKey(ma => ma.ActorId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
