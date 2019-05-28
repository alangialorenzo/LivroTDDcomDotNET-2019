namespace Empresa
{
    public class Funcionario
    {

        public string Nome    { get; }
        public double Salario { get; }
        public Cargo Cargo    { get; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            this.Nome    = nome;
            this.Salario = salario;
            this.Cargo   = cargo;
        }
    }
}
