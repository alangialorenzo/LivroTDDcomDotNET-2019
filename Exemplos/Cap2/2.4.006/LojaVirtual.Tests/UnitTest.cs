using LojaVirtual;
using NUnit.Framework;

namespace Tests
{
    public class TestaMaiorEMenor
    {

        [Test]
        public void OrdemCrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            Produto menor, maior;
            carrinho.Adiciona(menor = new Produto("Jogo de pratos", 70.0));
            carrinho.Adiciona(        new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(maior = new Produto("Geladeira", 450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual(menor, algoritmo.Menor);
            Assert.AreEqual(maior, algoritmo.Maior);
        }

        [Test]
        public void OrdemDecrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            Produto menor, maior;
            carrinho.Adiciona(maior = new Produto("Geladeira", 450.0));
            carrinho.Adiciona(        new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(menor = new Produto("Jogo de pratos", 70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual(menor, algoritmo.Menor);
            Assert.AreEqual(maior, algoritmo.Maior);
        }

        [Test]
        public void OrdemVariada()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            Produto menor, maior;
            carrinho.Adiciona(        new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(menor = new Produto("Jogo de pratos", 70.0));
            carrinho.Adiciona(maior = new Produto("Geladeira", 450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual(menor, algoritmo.Menor);
            Assert.AreEqual(maior, algoritmo.Maior);
        }

        [Test]
        public void ApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            Produto menor, maior;
            carrinho.Adiciona(menor =  maior = new Produto("Geladeira", 450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual(menor, algoritmo.Menor);
            Assert.AreEqual(maior, algoritmo.Maior);
        }
    }
}