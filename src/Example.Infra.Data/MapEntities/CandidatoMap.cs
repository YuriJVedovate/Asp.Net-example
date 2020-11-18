using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.MapEntities
{
    public class CandidatoMap : IEntityTypeConfiguration<CandidatoDomain>
    {
        public void Configure(EntityTypeBuilder<CandidatoDomain> builder)
        {
            builder.ToTable("Candidato", "dbo");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasColumnName("Nome");
            builder.Property(e => e.PartidoId).HasColumnName("PartidoId");
            builder.Property(e => e.Idade).HasColumnName("Idade");
            builder.Property(e => e.Posicao).HasColumnName("Posicao");
            builder.Property(e => e.Vice).HasColumnName("Vice");

            builder.Ignore(e => e.Valid);
            builder.Ignore(e => e.ValidationResult);


            builder.HasOne<PartidoDomain>(s => s.Partido)
                        .WithMany(g => g.Candidatos)
                        .HasForeignKey(s => s.PartidoId);
        }
    }
}
