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

            // Este teste passa!
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("V");

            Assert.AreEqual(5, numero);

            // Este teste falha!
        }
    }
}