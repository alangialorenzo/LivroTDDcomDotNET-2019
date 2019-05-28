using System.Text.RegularExpressions;

namespace Empresa
{
    public class CalculadoraDeSalario
    {

        public double CalculaSalario(Funcionario funcionario) =>
            funcionario.Cargo.Regra.Calcula(funcionario);
    }
}
