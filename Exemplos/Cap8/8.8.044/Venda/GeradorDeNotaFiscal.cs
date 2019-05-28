using System.Collections.Generic;

namespace Venda
{
    public class GeradorDeNotaFiscal
    {

        private IList<IAcaoAposGerarNota> acoes;
        private IRelogio relogio;
        private ITabela tabela;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes   = acoes;
            this.relogio = new RelogioDoSistema();
            this.tabela  = new Tabela();
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio)
        {
            this.acoes   = acoes;
            this.relogio = relogio;
            this.tabela  = new Tabela();
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio, ITabela tabela)
        {
            this.acoes   = acoes;
            this.relogio = relogio;
            this.tabela  = tabela;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(
                                            pedido.Cliente,
                                            pedido.ValorTotal * tabela.ParaValor(pedido.ValorTotal),
                                            relogio.Hoje()
                                          );

            foreach (var acao in acoes)  acao.Executa(nf);
            
            return nf;
        }
    }
}
