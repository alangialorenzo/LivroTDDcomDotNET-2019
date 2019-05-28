using System;
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
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new List<IAcaoAposGerarNota>(), new RelogioDoSistema());

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

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes, new RelogioDoSistema());

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

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes,new RelogioDoSistema());

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            dao.Verify(t => t.Executa(nf));
            sap.Verify(t => t.Executa(nf));
        }

        [Test]
        public void DeveGerarNFParaSegundaSeSabado()
        {
            Mock<IRelogio> date = new Mock<IRelogio>();
            DateTime fakeDate = new DateTime(year:2019, month:05, day:18); // Esta data cai num sábado
            date.Setup(d => d.Hoje()).Returns(fakeDate.AddDays(2));

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new List<IAcaoAposGerarNota>(), date.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(DayOfWeek.Monday, nf.Data.DayOfWeek);
        }

        [Test]
        public void DeveGerarNFParaSegundaSeDomingo() 
        {
            Mock<IRelogio> date = new Mock<IRelogio>();
            DateTime fakeDate = new DateTime(year:2019, month:05, day:19); // Esta data cai num domingo
            date.Setup(d => d.Hoje()).Returns(fakeDate.AddDays(1));

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new List<IAcaoAposGerarNota>(), date.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(DayOfWeek.Monday, nf.Data.DayOfWeek);
        }

        [Test]
        public void DeveGerarNFDuranteASemanaNormalmente()
        {
            Mock<IRelogio> date = new Mock<IRelogio>();
            DateTime fakeDate = new DateTime(year: 2019, month: 05, day: 15); // Esta data cai numa quarta-feira
            date.Setup(d => d.Hoje()).Returns(fakeDate);

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new List<IAcaoAposGerarNota>(), date.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(DayOfWeek.Wednesday, nf.Data.DayOfWeek);
        }
    }
}