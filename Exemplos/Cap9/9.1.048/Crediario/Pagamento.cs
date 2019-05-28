namespace Crediario
{
    public class Pagamento
    {

        public double ValorDoPagamento         { get; }
        public MeioDePagamento MeioDePagamento { get; }

        public Pagamento(double valorDoPagamento, MeioDePagamento meioDePagamento)
        {
            this.ValorDoPagamento = valorDoPagamento;
            this.MeioDePagamento  = meioDePagamento;
        }
    }
}
