using Moq;
using NUnit.Framework;
using Venda;

namespace Tests
{
    public class NotaFiscalTests
    {

        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal();

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor);
        }

        [Test]
        public void DevePersistirNFGerada()
        {
            Mock<NFDao> dao = new Mock<NFDao>();
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Persiste(nf));
        }

        [Test]
        public void DeveEnviarNFGeradaParaSAP()
        {
            Mock<NFDao> dao = new Mock<NFDao>();
            Mock<SAP> sap = new Mock<SAP>();
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Persiste(nf));
            sap.Verify(t => t.Envia(nf));
        }
    }
}