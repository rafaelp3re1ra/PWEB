using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GestaoLoja.Entities;

// A classe AplicationUser extende a classe IdentityUser, aka o utilizador. Isto vai-nos permitir personalizar os dados do utilizador. Acrescentar propriedades.
// Depois disto deve-se abrir o package manager e fazer "Add-Migration "Novas Entidades"" e depois Update-DataBase

namespace GestaoLoja.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<ModoEntrega> ModosEntrega { get; set; }
    }
}