namespace Empresa
{
    public class QuinzeOuVinteCincoPorCento : RegraDeCalculo
    {

        protected override int Limite() => 2500;
        protected override double PorcentagemAcimaDoLimite() => 0.75;
        protected override double PorcentagemBase() => 0.85;
    }
}
