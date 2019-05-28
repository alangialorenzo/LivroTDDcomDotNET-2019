namespace Empresa
{
    public class CalculadoraDeSalario
    {

        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
            {
                if (funcionario.Salario > 3000) return funcionario.Salario * 0.8;

                return funcionario.Salario * 0.9;
            }

            else // DBA ou TESTADOR
            {
                if (funcionario.Salario > 2500) return funcionario.Salario * 0.75;

                return funcionario.Salario * 0.85;
            }
        }
    }
}
