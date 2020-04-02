using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
         public DbSet<ClienteEntity> Clientes { get; set; }

         public MyContext(DbContextOptions<MyContext> options) : base (options){}

         protected override void OnModelCreating (ModelBuilder modelBuilder) {
             base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<ClienteEntity>(new ClienteMap().Configure);
         }
    }
}