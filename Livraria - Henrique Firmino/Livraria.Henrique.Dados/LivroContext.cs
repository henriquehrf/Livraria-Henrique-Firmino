using Livraria___Henrique_Firmino.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Henrique.Dados
{
	public class LivroContext : DbContext
	{
		public DbSet<Livro> Livro { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<Livro>()
				.ToTable("Livros")
				.HasKey("Id");

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=devsmovere.brazilsouth.cloudapp.azure.com,1040;Database=LivrariaDB;integrated security=false; user=henriquefirmino; pwd=MN0EALRkxADv;");
		}
	}
}
