﻿using Abp.Extensions;
using Example.Domain.ElectionAggregate;
using Example.Domain.ExampleAggregate;
using Example.Infra.Data.MapEntities;
using Microsoft.EntityFrameworkCore;
using System;

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
            modelBuilder.ApplyConfiguration(new ElectionMap());
        }

        public DbSet<ExampleDomain> Example { get; set; }
        public DbSet<ElectionDomain> Election { get; set; }
    }
}
