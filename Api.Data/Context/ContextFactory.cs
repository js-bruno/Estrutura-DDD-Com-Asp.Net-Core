using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //usado para criar migrações
            var connectionString = "Data Source=TotemBibiLITE.db";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionsBuilder.UseSqlite(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}