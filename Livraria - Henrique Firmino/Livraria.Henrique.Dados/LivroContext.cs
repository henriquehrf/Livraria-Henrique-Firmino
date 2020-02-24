using Livraria___Henrique_Firmino.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Henrique.Dados
{
	public class LivroContext : DbContext
	{
		public DbSet<LivroVO> Livro { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<LivroVO>()
				.ToTable("Livros")
				.HasKey("Id");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=//;Database=//;integrated security=false; user=//; pwd=//;");
		}
	}
}
