using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoCura.Auto
{
    public static class Configuracion
    {
        public static IWebDriver driver { get; set; }
        public static string Url = "https://katalon-demo-cura.herokuapp.com/";
    }
}
