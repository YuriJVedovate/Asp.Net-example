using Example.Domain.ExampleAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Infra.Data.MapEntities
{
    public class ExampleMap : IEntityTypeConfiguration<ExampleDomain>
    {
        public void Configure(EntityTypeBuilder<ExampleDomain> builder)
        {
            builder.ToTable("Example","dbo");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Age).HasColumnName("Age");
            builder.Property(e => e.Name).HasColumnName("Name");
            builder.Property(e => e.NumeroCasa).HasColumnName("NumeroCasa");
            builder.Property(e => e.Rua).HasColumnName("Rua");
            builder.Property(e => e.Cidade).HasColumnName("Cidade");
            builder.Property(e => e.Estado).HasColumnName("Estado");

            builder.Ignore(e => e.Valid);
            builder.Ignore(e => e.ValidationResult);
        }
    }
}
