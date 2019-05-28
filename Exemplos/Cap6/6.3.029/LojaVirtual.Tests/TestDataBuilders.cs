namespace LojaVirtual
{
    /// <summary>
    /// Padrão de Criação Builder
    /// </summary>
    public class CarrinhoDeComprasBuilder
    {

        private readonly CarrinhoDeCompras _carrinho;

        public CarrinhoDeComprasBuilder() => this._carrinho = new CarrinhoDeCompras();

        public CarrinhoDeComprasBuilder ComItens(string descricao, int quantidade, double valorUnitario)
        {
            this._carrinho.Adiciona(new Item(descricao,quantidade,valorUnitario));
            return this;
        }

        public CarrinhoDeCompras Cria() => this._carrinho;
    }
}
