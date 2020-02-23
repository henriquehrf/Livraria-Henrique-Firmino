using Livraria___Henrique_Firmino.Models;

namespace Livraria.Henrique.Dados
{
	public class RepositorioLivro: RepositorioBase<Livro>
	{
		public RepositorioLivro(LivroContext contexto) : base(contexto) { }
	}
}
