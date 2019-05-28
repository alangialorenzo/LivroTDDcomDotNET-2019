using System.Collections.Generic;

namespace Crediario
{
    public class Fatura
    {

        public IList<Pagamento> Pagamentos              { get; }
        public string Nome                              { get; }
        public double ValorTotalDaFatura                { get; }
        public bool Pago                                { get; private set; }

        public Fatura(string nome, double valorTotalDaFatura)
        {
            this.Pagamentos              = new List<Pagamento>();
            this.Nome                    = nome;
            this.ValorTotalDaFatura      = valorTotalDaFatura;
            this.Pago                    = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);

            double valorTotal = 0;
            foreach (var p in Pagamentos) valorTotal += p.ValorDoPagamento;

            if (valorTotal >= this.ValorTotalDaFatura) this.Pago = true;
        }
    }
}
