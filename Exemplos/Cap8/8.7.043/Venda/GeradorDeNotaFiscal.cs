using System.Collections.Generic;

namespace Venda
{
    public class GeradorDeNotaFiscal
    {

        private IList<IAcaoAposGerarNota> acoes;
        private IRelogio relogio;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes   = acoes;
            this.relogio = new RelogioDoSistema();
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio)
        {
            this.acoes   = acoes;
            this.relogio = relogio;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(
                                            pedido.Cliente,
                                            pedido.ValorTotal * 0.94,
                                            relogio.Hoje()
                                          );

            foreach (var acao in acoes)  acao.Executa(nf);
            
            return nf;
        }
    }
}
