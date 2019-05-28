using System.Collections.Generic;

namespace Crediario
{
    public class ProcessadorDeBoletos
    {

        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            Boleto boleto = boletos[0];

            Pagamento pagamento = new Pagamento(boleto.ValorDoBoleto, MeioDePagamento.BOLETO);

            fatura.Pagamentos.Add(pagamento);
        }
    }
}
