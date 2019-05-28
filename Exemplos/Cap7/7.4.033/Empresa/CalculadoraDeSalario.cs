using System.Text.RegularExpressions;

namespace Empresa
{
    public class CalculadoraDeSalario
    {

        private IRegraDeCalculo regraDeCalculo;

        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
            {
                regraDeCalculo = new DezOuVintePorCento();
                return regraDeCalculo.Calcula(funcionario);
            }

            else // DBA ou TESTADOR
            {
                regraDeCalculo = new QuinzeOuVinteCincoPorCento();
                return regraDeCalculo.Calcula(funcionario);
            }
        }
    }
}
