using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ProyectoCura.Auto.Paginas
{
    public class Inicio
    {
        public Inicio()
        {
            PageFactory.InitElements(Configuracion.driver, this);
        }

        [FindsBy(How = How.Id, Using = "btn-make-appointment")]
        public IWebElement MakeAppointment { get; set; }
    }
}