using System.Collections.Generic;

namespace Crediario
{
    public class Fatura
    {

        public IList<Pagamento> Pagamentos              { get; }
        public string Nome                              { get; }
        public double ValorTotalDaFatura                { get; }

        public Fatura(string nome, double valorTotalDaFatura)
        {
            Pagamentos              = new List<Pagamento>();
            Nome                    = nome;
            ValorTotalDaFatura      = valorTotalDaFatura;
        }
    }
}
