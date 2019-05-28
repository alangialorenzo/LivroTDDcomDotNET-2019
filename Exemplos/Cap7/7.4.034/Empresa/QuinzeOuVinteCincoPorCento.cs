namespace Empresa
{
    public class QuinzeOuVinteCincoPorCento : IRegraDeCalculo
    {

        public double Calcula(Funcionario funcionario) =>
            funcionario.Salario > 2500
                ? funcionario.Salario * 0.75
                : funcionario.Salario * 0.85;
    }
}
