namespace NumerosRomanos
{
    public class ConversorDeNumeroRomano
    {

        public int Converte(string numeroEmRomano)
        {
            if (numeroEmRomano.Equals("I")) return 1;

            if (numeroEmRomano.Equals("V")) return 5;

            return 0;
        }
    }
}
