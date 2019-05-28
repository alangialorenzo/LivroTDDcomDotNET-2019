namespace Venda
{
    public class Tabela : ITabela
    {
        public double ParaValor(double valor)
        {
            if (valor <= 1000) return 0.98;

            else if (valor < 3000) return 0.94; 

            else return 0.92;
        }
    }
}
