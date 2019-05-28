using LojaVirtual;
using NUnit.Framework;

namespace CarrinhoDeComprasTests
{
    public class CarrinhoDeComprasTests
    {

        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicializa()
        {
            this.carrinho = new CarrinhoDeComprasBuilder().Cria();
        }

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            var item         = carrinho.MaiorValor();
            var itemEsperado = 0.0;

            Assert.AreEqual(itemEsperado, item);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho = new CarrinhoDeComprasBuilder()
                                                    .ComItens(descricao:"Geladeira", quantidade: 1, valorUnitario: 900.0)
                                                    .Cria();

            var item         = carrinho.MaiorValor();
            var itemEsperado = new Item(descricao: "Geladeira", quantidade: 1, valorUnitario: 900.0).ValorTotal;

            Assert.AreEqual(itemEsperado,item);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            carrinho = new CarrinhoDeComprasBuilder()
                                                    .ComItens(descricao: "Geladeira", quantidade: 1, valorUnitario: 900.0)
                                                    .ComItens(descricao: "Fogão", quantidade: 1, valorUnitario: 1500.0)
                                                    .ComItens(descricao: "Máquina de Lavar", quantidade: 1, valorUnitario: 750.0)
                                                    .Cria();


            var item         = carrinho.MaiorValor();
            var itemEsperado = new Item(descricao: "Fogão", quantidade: 1, valorUnitario: 1500.0).ValorTotal;

            Assert.AreEqual(itemEsperado,item);
        }
    }
}