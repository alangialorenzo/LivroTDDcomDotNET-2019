using NumerosRomanos;
using NUnit.Framework;

namespace Tests
{
    public class ConversorDeNumeroRomanoTest
    {

        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);

            // Falha!
        }
    }
}