using System.Collections.Generic;

namespace Crediario
{
    public class ProcessadorDeBoletos
    {

        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {

            double valorTotal = 0;
            foreach (var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.ValorDoBoleto, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);

                valorTotal += boleto.ValorDoBoleto;
            }

            if (valorTotal >= fatura.ValorTotalDaFatura) fatura.Pago = true;
        }
    }
}
