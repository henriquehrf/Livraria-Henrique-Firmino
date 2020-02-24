using Livraria.Henrique.Dados.DAO;
using Livraria___Henrique_Firmino.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Livraria___Henrique_Firmino.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class LivroController : ControllerBase
	{
		[HttpGet]
		public IList<LivroVO> RetornarTodosLivros()
		{
			var livroDao = new LivroDAO();
			return livroDao.RetornarTodos();
		}

		[HttpPost]
		public IActionResult InserirUmLivro(LivroVO livro)
		{
			var livroDao = new LivroDAO();
			livroDao.Inserir(livro);
			return Ok();
		}

		[HttpPut]
		public IActionResult AlterarUmLivro(LivroVO livro)
		{

			var livroDao = new LivroDAO();
			livroDao.Alterar(livro);
			return Ok();
		}

		[HttpPost]
		public IActionResult RemoverUmLivro(LivroVO livro)
		{
			var livroDao = new LivroDAO();
			livroDao.Excluir(livro);
			return Ok();

		}
	}
}
