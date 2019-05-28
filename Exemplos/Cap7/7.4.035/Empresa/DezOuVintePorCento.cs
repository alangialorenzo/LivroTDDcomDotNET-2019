namespace Empresa
{
    public class DezOuVintePorCento : RegraDeCalculo
    {

        protected override int Limite() => 3000;
        protected override double PorcentagemAcimaDoLimite() => 0.8;
        protected override double PorcentagemBase() => 0.9;
    }
}
