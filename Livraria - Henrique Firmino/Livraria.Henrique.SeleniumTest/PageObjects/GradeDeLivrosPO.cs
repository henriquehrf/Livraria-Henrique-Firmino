using OpenQA.Selenium;

namespace Livraria.Henrique.SeleniumTest.PageObjects
{
	public class GradeDeLivrosPO
	{
		private IWebDriver _driver;
		private By _byBotaoNovo;
		private By _byInputDeBusca;
		private By _byElementoDaGrade;

		public GradeDeLivrosPO(IWebDriver driver)
		{
			_driver = driver;
			_byInputDeBusca = By.Id("inputTermoDeBusca");
			_byBotaoNovo = By.Id("btnNovo");
		}


		public void Visitar() => _driver.Navigate().GoToUrl("https://localhost:44334");

		public bool BotaoNovoEstaVisivel() => _driver.FindElement(_byBotaoNovo).Displayed;

		public bool BuscadorDaGradeEstaVisivel() => _driver.FindElement(_byInputDeBusca).Displayed;
	}
}
