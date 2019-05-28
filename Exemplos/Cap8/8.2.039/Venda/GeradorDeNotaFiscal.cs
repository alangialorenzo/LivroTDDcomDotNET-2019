using System;

namespace Venda
{
    public class GeradorDeNotaFiscal
    {

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(
                                            pedido.Cliente,
                                            pedido.ValorTotal * 0.94,
                                            DateTime.Now
                                          );

            new NFDao().Persiste(nf);

            return nf;
        }
    }
}
