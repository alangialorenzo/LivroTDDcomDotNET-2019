namespace LojaVirtual
{
    public class MaiorEMenor
    {

        public Produto Menor { get; private set; }
        public Produto Maior { get; private set; }

        public void Encontra(CarrinhoDeCompras carrinho)
        {
            foreach (Produto produto in carrinho.Produtos)
            {
                if (Menor == null || produto.Valor < Menor.Valor)
                {
                    Menor = produto;
                }
                if (Maior == null || produto.Valor > Maior.Valor)
                {
                    Maior = produto;
                }
            }
        }
    }
}
