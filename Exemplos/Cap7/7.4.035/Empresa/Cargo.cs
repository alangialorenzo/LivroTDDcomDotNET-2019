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


        public RegraDeCalculo Regra { get; }

        private Cargo(RegraDeCalculo regra) => this.Regra = regra;
    }
}
