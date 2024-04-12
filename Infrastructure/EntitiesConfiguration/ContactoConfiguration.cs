using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.EntitiesConfiguration
{
    internal class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p=>p.Name).HasMaxLength (200).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(100).IsRequired();
            builder.Property(p => p.PhoneNumber).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Photo).HasMaxLength(200);
        }

    }
}
