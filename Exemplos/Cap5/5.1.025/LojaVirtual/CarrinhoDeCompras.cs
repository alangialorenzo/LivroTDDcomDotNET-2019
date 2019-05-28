using System.Collections.Generic;

namespace LojaVirtual
{
    public class CarrinhoDeCompras
    {

        public IList<Item> Itens { get; private set; }

        public CarrinhoDeCompras() => this.Itens = new List<Item>();

        public void Adiciona(Item item) => this.Itens.Add(item);
    }
}
