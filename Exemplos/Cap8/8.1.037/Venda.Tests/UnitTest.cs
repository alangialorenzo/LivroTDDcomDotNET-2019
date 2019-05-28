using NUnit.Framework;
using Venda;

namespace Tests
{
    public class NotaFiscalTests
    {

        private GeradorDeNotaFiscal gerador;

        [SetUp]
        public void Inicializa()
        {
            gerador = new GeradorDeNotaFiscal();
        }

        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor);
        }
    }
}