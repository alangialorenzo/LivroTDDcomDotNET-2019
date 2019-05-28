namespace LojaVirtual
{
    public class Produto 
    {

        public string Nome   { get; private set; }
        public double Valor  { get; private set; }

        public Produto(string nome, double valor)
        {
            this.Nome  = nome;
            this.Valor = valor;
        }

        public override bool Equals(object obj)
        {
            return Equals(this.Nome, (obj as Produto).Nome);
        }
    }
}
