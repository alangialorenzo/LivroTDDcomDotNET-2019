using LojaVirtual;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            MaiorPreco algoritmo = new MaiorPreco();

            double valor = algoritmo.Encontra(carrinho);

            Assert.AreEqual(0.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            MaiorPreco algoritmo = new MaiorPreco();

            double valor = algoritmo.Encontra(carrinho);

            Assert.AreEqual(900.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            MaiorPreco algoritmo = new MaiorPreco();

            double valor = algoritmo.Encontra(carrinho);

            Assert.AreEqual(1500.0, valor, 0.0001);
        }

    }
}