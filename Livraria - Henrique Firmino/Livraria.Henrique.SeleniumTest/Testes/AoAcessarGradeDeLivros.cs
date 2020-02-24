using FluentAssertions;
using Livraria.Henrique.SeleniumTest.Fixtures;
using Livraria.Henrique.SeleniumTest.PageObjects;
using OpenQA.Selenium;
using System.Threading;
using Xunit;

namespace Livraria.Henrique.SeleniumTest
{
	[Collection("Chrome Driver")]
	public class AoAcessarGradeDeLivros
	{
		private IWebDriver _driver;

		public AoAcessarGradeDeLivros(TestFixture fixture)
		{
			_driver = fixture.Driver;
		}

		[Fact]
		public void DadoUsuarioDeveApresentarTodosElementosVisivelNaGradeDeLivros()
		{
			var acessoGrade = new GradeDeLivrosPO(_driver);
			acessoGrade.Visitar();

			acessoGrade.BuscadorDaGradeEstaVisivel().Should().BeTrue();
			acessoGrade.BotaoNovoEstaVisivel().Should().BeTrue();


		}
	}
}
