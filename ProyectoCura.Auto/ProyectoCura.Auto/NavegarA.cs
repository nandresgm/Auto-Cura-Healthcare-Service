using ProyectoCura.Auto.Paginas;

namespace ProyectoCura.Auto
{
    public static class NavegarA
    {
        public static void IniciarSesion()
        {
            Inicio PaginaInicio = new Inicio();
            PaginaInicio.MakeAppointment.Click();
        }
    }
}
