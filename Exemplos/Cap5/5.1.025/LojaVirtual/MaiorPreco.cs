namespace LojaVirtual
{
    public class MaiorPreco
    {

        public double Encontra(CarrinhoDeCompras carrinho)
        {
            if (carrinho.Itens.Count == 0) return 0;

            return carrinho.Itens[0].ValorTotal;
        }
    }
}
