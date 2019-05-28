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
            this.carrinho = new CarrinhoDeCompras();
        }


        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            Assert.AreEqual(0.0, carrinho.MaiorValor());
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho.Adiciona(new Item(descricao:"Geladeira", quantidade: 1, valorUnitario: 900.0));

            Assert.AreEqual(900.0, carrinho.MaiorValor());
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            carrinho.Adiciona(new Item(descricao: "Geladeira", quantidade: 1, valorUnitario: 900.0));
            carrinho.Adiciona(new Item(descricao: "Fogão", quantidade: 1, valorUnitario: 1500.0));
            carrinho.Adiciona(new Item(descricao: "Máquina de Lavar", quantidade: 1, valorUnitario: 750.0));

            Assert.AreEqual(1500.0, carrinho.MaiorValor());
        }
    }
}