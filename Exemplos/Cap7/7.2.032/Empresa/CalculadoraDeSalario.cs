namespace Empresa
{
    public class CalculadoraDeSalario
    {

        public double CalculaSalario(Funcionario funcionario) =>
            funcionario.Cargo.Equals((Cargo.DESENVOLVEDOR))
                ? DezOuVintePorCentoDeDesconto(funcionario)
                : QuinzeOuVinteCincoPorCentoDeDesconto(funcionario);

        private double QuinzeOuVinteCincoPorCentoDeDesconto(Funcionario funcionario) =>
            funcionario.Salario > 2500
                ? funcionario.Salario * 0.75
                : funcionario.Salario * 0.85;

        private double DezOuVintePorCentoDeDesconto(Funcionario funcionario) =>
            funcionario.Salario > 3000
                ? funcionario.Salario * 0.8
                : funcionario.Salario * 0.9;
    }
}
