namespace Empresa
{
    public class Cargo
    {

        public static Cargo DESENVOLVEDOR => 
            new Cargo(new DezOuVintePorCento());

        public static Cargo DBA => 
            new Cargo(new QuinzeOuVinteCincoPorCento());

        public static Cargo TESTADOR => 
            new Cargo(new QuinzeOuVinteCincoPorCento());


        public IRegraDeCalculo Regra { get; }
        private Cargo(IRegraDeCalculo regra) => this.Regra = regra;
    }
}
