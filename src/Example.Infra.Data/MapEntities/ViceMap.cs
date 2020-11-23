using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using Example.Domain.ViceAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.MapEntities
{
    public class ViceMap : IEntityTypeConfiguration<ViceDomain>
    {
        public void Configure(EntityTypeBuilder<ViceDomain> builder)
        {
            builder.ToTable("Vice", "dbo");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasColumnName("Nome");
            builder.Property(e => e.PartidoId).HasColumnName("PartidoId");
            builder.Property(e => e.Idade).HasColumnName("Idade");

            builder.Ignore(e => e.Valid);
            builder.Ignore(e => e.ValidationResult);

            builder.HasOne<PartidoDomain>(v => v.Partido)
                   .WithMany(p => p.Vices)
                   .HasForeignKey(c => c.PartidoId);

        }
    }
}
