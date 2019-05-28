using System.Collections.Generic;

namespace LojaVirtual
{
    public class CarrinhoDeCompras
    {

        private readonly IList<Produto> _produtos;

        public CarrinhoDeCompras() => this._produtos = new List<Produto>();

        public IList<Produto> Produtos => this._produtos;

        public void Adiciona(Produto produto) => this._produtos.Add(produto);
    }
}
