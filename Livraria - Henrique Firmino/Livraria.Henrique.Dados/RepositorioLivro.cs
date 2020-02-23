
using Livraria___Henrique_Firmino.Models;

namespace Livraria.Henrique.Dados
{
	public class RepositorioLivro: RepositorioBase<LivroVO>
	{
		public RepositorioLivro(LivroContext contexto) : base(contexto) { }
	}
}
