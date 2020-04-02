using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClienteEntity> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);
            
            builder.HasIndex(c => c.Nome);
                
            builder.Property( c => c.Senha)
                    .IsRequired()
                    .HasMaxLength(5);

            builder.Property( c => c.Nome)
                    .IsRequired()
                    .HasMaxLength(25);
                    
        }
    }
}