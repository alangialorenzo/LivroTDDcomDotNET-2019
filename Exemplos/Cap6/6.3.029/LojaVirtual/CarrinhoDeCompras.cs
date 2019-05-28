using System.Collections.Generic;

namespace LojaVirtual
{
    public class CarrinhoDeCompras
    {

        public IList<Item> Itens { get; private set; }

        public CarrinhoDeCompras() => this.Itens = new List<Item>();

        public void Adiciona(Item item) => this.Itens.Add(item);

        public double MaiorValor()
        {
            if (this.Itens.Count == 0) return 0;

            double maior = this.Itens[0].ValorTotal;
            foreach (var item in this.Itens)
            {
                if (maior < item.ValorTotal) maior = item.ValorTotal;
            }

            return maior;
        }
    }
}
