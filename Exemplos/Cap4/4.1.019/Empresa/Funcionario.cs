namespace Empresa
{
    public class Funcionario
    {

        public string Nome    { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo    { get; private set; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            this.Nome    = nome;
            this.Salario = salario;
            this.Cargo   = cargo;
        }
    }
}
