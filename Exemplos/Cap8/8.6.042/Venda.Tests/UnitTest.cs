using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using Venda;

namespace Tests
{
    public class NotaFiscalTests
    {

        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            // Nenhuma acao
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new List<IAcaoAposGerarNota>()); 

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor);
        }

        [Test]
        public void DevePersistirNFGerada()
        {
            Mock<IAcaoAposGerarNota> dao = new Mock<IAcaoAposGerarNota>();

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>()
                { dao.Object };

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Executa(nf));
        }

        [Test]
        public void DeveEnviarNFGeradaParaSAP()
        {
            Mock<IAcaoAposGerarNota> dao = new Mock<IAcaoAposGerarNota>();
            Mock<IAcaoAposGerarNota> sap = new Mock<IAcaoAposGerarNota>();

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>()
                    { dao.Object, sap.Object };

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Executa(nf));
            sap.Verify(t => t.Executa(nf));
        }
    }
}