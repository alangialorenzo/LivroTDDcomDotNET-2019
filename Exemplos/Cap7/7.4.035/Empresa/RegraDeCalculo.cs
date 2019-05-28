namespace Empresa
{
    public abstract class RegraDeCalculo
    {

        public double Calcula(Funcionario funcionario) =>
            funcionario.Salario > Limite()
                ? funcionario.Salario * PorcentagemAcimaDoLimite()
                : funcionario.Salario * PorcentagemBase();

        protected abstract int Limite();
        protected abstract double PorcentagemAcimaDoLimite();
        protected abstract double PorcentagemBase();
    }
}
