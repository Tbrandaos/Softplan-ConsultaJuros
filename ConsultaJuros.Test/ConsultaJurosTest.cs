using Microsoft.VisualStudio.TestTools.UnitTesting;
using Softplan.Services.JurosService;

namespace ConsultaJuros.Test
{
    [TestClass]
    public class ConsultaJurosTest
    {
        [TestMethod]
        public void ConsultaJuros_VerificaResultado()
        {
            var jurosService = new JurosService();

            var juros = jurosService.GetJuros();

            Assert.AreEqual(0.01, juros);
        }
    }
}
