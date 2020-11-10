using Example.Domain.ElectionAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Infra.Data.MapEntities
{
    public class ElectionMap : IEntityTypeConfiguration<ElectionDomain>
    {
        public void Configure(EntityTypeBuilder<ElectionDomain> builder)
        {
            builder.ToTable("Election", "dbo");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasColumnName("Name");
            builder.Property(e => e.Entourage).HasColumnName("Entourage");
            builder.Property(e => e.Age).HasColumnName("Age");
            builder.Property(e => e.Occupation).HasColumnName("Occupation");
            builder.Property(e => e.Patrimony).HasColumnName("Patrimony");
            builder.Property(e => e.Vice).HasColumnName("Vice");

            builder.Ignore(e => e.Valid);
            builder.Ignore(e => e.ValidationResult);
        }
    }
}
