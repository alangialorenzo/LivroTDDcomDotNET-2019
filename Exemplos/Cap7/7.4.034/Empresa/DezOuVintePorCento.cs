namespace Empresa
{
    public class DezOuVintePorCento : IRegraDeCalculo
    {

        public double Calcula(Funcionario funcionario) =>
            funcionario.Salario > 3000
                ? funcionario.Salario * 0.8
                : funcionario.Salario * 0.9;
    }
}
