namespace Venda
{
    public class Pedido
    {

        public string Cliente      { get; }
        public double ValorTotal   { get; }
        public int QuantidadeItens { get; }

        public Pedido(string cliente, double valorTotal, int quantidadeItens)
        {
            this.Cliente         = cliente;
            this.ValorTotal      = valorTotal;
            this.QuantidadeItens = quantidadeItens;
        }
    }
}
