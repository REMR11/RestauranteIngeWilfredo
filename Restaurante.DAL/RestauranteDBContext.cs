using Microsoft.EntityFrameworkCore;
using Restaurante.EL;
using System;

namespace Restaurante.DAL;

public class RestauranteDBContext : DbContext
{
    public RestauranteDBContext(){}
    public RestauranteDBContext(DbContextOptions<RestauranteDBContext> options) : base(options) { }

    public DbSet<Ingredientes> Ingredientes { get; set; }
    public DbSet<Plantillo>plantillos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<>
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer(@"");
        }
    }



}