using Chapter16.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Chapter16.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = DESKTOP-JBA9HEP\\SQLEXPRESS;" + "initial catalog = Chapter16; Integrated Security=true;");

            }
        }

        public DbSet<Livro> Livros { get; set; }

    }
}



