using Microsoft.EntityFrameworkCore;

namespace CrudLivros.Models
{
    public class bancoDeDados : DbContext
    {   
        public DbSet<Livro> Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-Q3HTHE7\MSSQLSERVER2;Database=DB_Livros;User id=sa;Password=tulipa123;TrustServerCertificate=True"));
        }
    }
}
