using Example.Domain.CandidatoAggregate;
using Example.Domain.PartidoAggregate;
using Example.Domain.ExampleAggregate;
using Example.Infra.Data.MapEntities;
using Microsoft.EntityFrameworkCore;
// add a reference to System.ComponentModel.DataAnnotations DLL



namespace Example.Infra.Data
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExampleMap());
            modelBuilder.ApplyConfiguration(new CandidatoMap());
            modelBuilder.ApplyConfiguration(new PartidoMap());
        }

        public DbSet<ExampleDomain> Example { get; set; }
        public DbSet<CandidatoDomain> Candidato { get; set; }
        public DbSet<PartidoDomain> Partido { get; set; }

    }

}



