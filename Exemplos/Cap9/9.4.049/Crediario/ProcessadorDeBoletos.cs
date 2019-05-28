using System.Collections.Generic;

namespace Crediario
{
    public class ProcessadorDeBoletos
    {

        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (var boleto in boletos) 
            {
                Pagamento pagamento = new Pagamento(boleto.ValorDoBoleto, MeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
