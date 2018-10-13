using OpenQA.Selenium.Chrome;
using ProyectoCura.Auto.Paginas;

namespace ProyectoCura.Auto
{
    public static class Acciones
    {
        public static void InicializarDriver()
        {
            Configuracion.driver = new ChromeDriver();
            Configuracion.driver.Manage().Window.Maximize();
            Configuracion.driver.Navigate().GoToUrl(Configuracion.Url);
        }

        public static bool NoIngresarCampos()
        {
            IniciarSesion PaginaIniciarSesion = new IniciarSesion();
            PaginaIniciarSesion.btnLogin.Click();
            if (PaginaIniciarSesion.lblError.Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
