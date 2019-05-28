using System;

namespace Venda
{
    public class RelogioDoSistema : IRelogio
    {

        public DateTime Hoje()
        {
            if (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Saturday))
                return DateTime.Now.AddDays(2);

            if (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Sunday))
                return DateTime.Now.AddDays(1);

            return DateTime.Now;
        }
    }
}
