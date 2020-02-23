using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Livraria___Henrique_Firmino.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Teste(){


			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}
