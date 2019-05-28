using Crediario;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class ProcessadorDeBoletosTests
    {

        [Test]
        public void DeveProcessarPagamentoViaBoletoUnico()
        {
            ProcessadorDeBoletos processador = new ProcessadorDeBoletos();

            Fatura fatura = new Fatura("Cliente", 150.0);
            Boleto b1 = new Boleto(150.0);
            IList<Boleto> boletos = new List<Boleto>() { b1 };

            processador.Processa(boletos, fatura);

            Assert.AreEqual(1, fatura.Pagamentos.Count);
            Assert.AreEqual(150.0, fatura.Pagamentos[0].ValorDoPagamento);
        }

        [Test]
        public void DeveProcessarPagamentoViaMuitosBoletos()
        {
            ProcessadorDeBoletos processador = new ProcessadorDeBoletos();

            Fatura fatura = new Fatura("Cliente", 300.0);
            Boleto b1 = new Boleto(100.0);
            Boleto b2 = new Boleto(200.0);
            IList<Boleto> boletos = new List<Boleto>() { b1, b2 };

            processador.Processa(boletos, fatura);

            Assert.AreEqual(2, fatura.Pagamentos.Count);
            Assert.AreEqual(100.0, fatura.Pagamentos[0].ValorDoPagamento);
            Assert.AreEqual(200.0, fatura.Pagamentos[1].ValorDoPagamento);
        }
    }
}