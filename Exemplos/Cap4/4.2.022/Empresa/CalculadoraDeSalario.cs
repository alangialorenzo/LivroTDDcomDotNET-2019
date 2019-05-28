namespace Empresa
{
    public class CalculadoraDeSalario
    {

        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
            {
                if (funcionario.Salario > 3000) return 3200.0;

                return 1350.0;
            }

            return 425.0;
        }
    }
}
