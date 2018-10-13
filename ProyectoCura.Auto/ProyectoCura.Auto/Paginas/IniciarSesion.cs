using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ProyectoCura.Auto.Paginas
{
    public class IniciarSesion
    {
        public IniciarSesion()
        {
            PageFactory.InitElements(Configuracion.driver, this);
        }

        [FindsBy(How = How.Id, Using = "txt-username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "txt-password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "btn-login")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login > div > div > div.col-sm-12.text-center > p.lead.text-danger")]
        public IWebElement lblError { get; set; }
    }
}
