using Livraria___Henrique_Firmino.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Livraria___Henrique_Firmino.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class LivroController : ControllerBase
	{

		[HttpGet]
		public IActionResult SImplesRequisicao()
		{
			return new ContentResult()
			{
				Content = JsonConvert.SerializeObject(new Livro() { Titulo = "Henrique", Pagina = 10 }),
				ContentType = "application/json; charset=utf-8",
				StatusCode = 200
			};
		}
	}
}
