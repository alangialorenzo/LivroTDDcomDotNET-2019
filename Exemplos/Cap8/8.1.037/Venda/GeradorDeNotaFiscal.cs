using System;

namespace Venda
{
    public class GeradorDeNotaFiscal
    {

        public NotaFiscal Gera(Pedido pedido) =>
            new NotaFiscal(
                            pedido.Cliente,
                            pedido.ValorTotal * 0.94,
                            DateTime.Now
                          );
    }
}
