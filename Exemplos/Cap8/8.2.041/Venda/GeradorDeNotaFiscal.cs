using System;

namespace Venda
{
    public class GeradorDeNotaFiscal
    {

        private NFDao dao;
        private SAP sap;

        public GeradorDeNotaFiscal()
        {
            this.dao = new NFDao();
            this.sap = new SAP();
        }

        public GeradorDeNotaFiscal(NFDao dao)
        {
            this.dao = dao;
            this.sap = new SAP();
        }

        public GeradorDeNotaFiscal(NFDao dao, SAP sap)
        {
            this.dao = dao;
            this.sap = sap;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(
                                            pedido.Cliente,
                                            pedido.ValorTotal * 0.94,
                                            DateTime.Now
                                          );

            dao.Persiste(nf);
            sap.Envia(nf);

            return nf;
        }
    }
}
