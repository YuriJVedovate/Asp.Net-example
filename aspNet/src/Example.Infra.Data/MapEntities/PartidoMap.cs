using Example.Domain.PartidoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.MapEntities
{
    public class PartidoMap : IEntityTypeConfiguration<PartidoDomain>
    {
        public void Configure(EntityTypeBuilder<PartidoDomain> builder)
        {
            builder.ToTable("Partido", "dbo");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasColumnName("Nome");
            builder.Property(e => e.Sigla).HasColumnName("Sigla");
            builder.Property(e => e.NumeroEleitoral).HasColumnName("NumeroEleitoral");
            builder.Property(e => e.Foto).HasColumnName("Foto");

            builder.Ignore(e => e.Valid);
            builder.Ignore(e => e.ValidationResult);
        }
    }
}
