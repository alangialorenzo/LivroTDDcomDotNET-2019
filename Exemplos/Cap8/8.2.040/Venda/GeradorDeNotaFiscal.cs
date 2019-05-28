using System;

namespace Venda
{
    public class GeradorDeNotaFiscal
    {

        private NFDao dao;

        public GeradorDeNotaFiscal() => this.dao = new NFDao();

        public GeradorDeNotaFiscal(NFDao dao) => this.dao = dao;

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(
                                            pedido.Cliente,
                                            pedido.ValorTotal * 0.94,
                                            DateTime.Now
                                          );

            dao.Persiste(nf);

            return nf;
        }
    }
}
