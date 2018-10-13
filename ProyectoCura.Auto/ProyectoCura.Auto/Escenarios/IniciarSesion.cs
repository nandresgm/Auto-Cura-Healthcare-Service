using NUnit.Framework;
using System.Threading;

namespace ProyectoCura.Auto.Escenarios
{
    class IniciarSesion
    {
        [SetUp]
        public void Inicializar()
        {
            Acciones.InicializarDriver();
        }

        [Test, Description("Campos obligatorios")]
        public void CamposObligatorios()
        {
            NavegarA.IniciarSesion();
            Assert.That(Acciones.NoIngresarCampos());
        }

        [TearDown]
        public void FinalizarDriver()
        {
            Configuracion.driver.Quit();
        }
    }
}
