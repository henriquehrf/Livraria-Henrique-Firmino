using Livraria___Henrique_Firmino.Models;
using System.Collections.Generic;

namespace Livraria.Henrique.Dados.DAO
{
	public class LivroDAO
	{
		public void Inserir(LivroVO livro)
		{
			using (var contexto = new LivroContext())
			{
				using (var respositorio = new RepositorioLivro(contexto))
				{
					respositorio.Incluir(livro);
				}
			}
		}

		public void Alterar(LivroVO livro)
		{
			using (var contexto = new LivroContext())
			{
				using (var respositorio = new RepositorioLivro(contexto))
				{
					respositorio.Alterar(livro);
				}
			}
		}

		public void Excluir(LivroVO livro)
		{
			using (var contexto = new LivroContext())
			{
				using (var respositorio = new RepositorioLivro(contexto))
				{
					respositorio.Excluir(livro);
				}
			}
		}

		public IList<LivroVO> RetornarTodos()
		{
			var livros = new List<LivroVO>();
			using (var contexto = new LivroContext())
			{
				using (var respositorio = new RepositorioLivro(contexto))
				{
					foreach (var livro in respositorio.Todos)
						livros.Add(livro);
				}
			}
			return livros;
		}
	}
}
