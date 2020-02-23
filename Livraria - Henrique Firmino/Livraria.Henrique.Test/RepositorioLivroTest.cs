using FluentAssertions;
using Livraria.Henrique.Dados;
using Livraria___Henrique_Firmino.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Livraria.Henrique.Test
{
	[TestClass]
	public class RepositorioLivroTest
	{
		[TestMethod]
		public void AoPersistirUmObjetoDeLivroValidoNaoDeveLancarExcessao()
		{
			using (var livro = new LivroContext())
			{
				var repositorio = new RepositorioLivro(livro);
				var livroNovo = new LivroVO()
				{
					Titulo = "Henrique",
					Autor = "Fulano",
					Capa = "Teste",
					DataPublicacao = DateTime.Now,
					Descricao = ".Net Core",
					Editora = "Editora Fake",
					Genero = "Acadêmico",
					Links = "www.google.com",
					Pagina = 234,
					Sinopse = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
				};
				Action acao = () => repositorio.Incluir(livroNovo);

				acao.Should().NotThrow<Exception>();

			}
		}

		[TestMethod]
		public void AoPersistirUmObjetoDeLivroValidoDevePermitirAlteracaoDoObjetoSemLancarExcessao()
		{
			using (var livro = new LivroContext())
			{
				var repositorio = new RepositorioLivro(livro);
				var livroNovo = new LivroVO()
				{
					Titulo = "Teste",
					Autor = "Fulano",
					Capa = "Teste",
					DataPublicacao = DateTime.Now,
					Descricao = ".Net Core",
					Editora = "Editora Fake",
					Genero = "Acadêmico",
					Links = "www.google.com",
					Pagina = 234,
					Sinopse = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
				};
				Action acao = () => repositorio.Incluir(livroNovo);

				acao.Should().NotThrow<Exception>();

				livroNovo.Titulo = "José";
				acao = () => repositorio.Alterar(livroNovo);
				acao.Should().NotThrow<Exception>();

			}
		}

		[TestMethod]
		public void AoSolicitarUmaDelecaoDeUmObjetoDeLivroDeveRealizarSemLancarExcessao()
		{
			using (var livro = new LivroContext())
			{
				var repositorio = new RepositorioLivro(livro);
				var livroNovo = new LivroVO()
				{
					Titulo = "Deleção",
					Autor = "Fulano",
					Capa = "Teste",
					DataPublicacao = DateTime.Now,
					Descricao = ".Net Core",
					Editora = "Editora Fake",
					Genero = "Acadêmico",
					Links = "www.google.com",
					Pagina = 234,
					Sinopse = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
				};
				Action acao = () => repositorio.Incluir(livroNovo);

				acao.Should().NotThrow<Exception>();

				acao = () => repositorio.Excluir(livroNovo);
				acao.Should().NotThrow<Exception>();

			}
		}
	}
}
