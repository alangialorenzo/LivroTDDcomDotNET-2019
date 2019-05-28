using System;

namespace Venda
{
    public class NotaFiscal
    {

        public string Cliente { get; }
        public double Valor   { get; }
        public DateTime Data  { get; }

        public NotaFiscal(string cliente, double valor, DateTime data)
        {
            this.Cliente = cliente;
            this.Valor   = valor;
            this.Data    = data;
        }
    }
}
