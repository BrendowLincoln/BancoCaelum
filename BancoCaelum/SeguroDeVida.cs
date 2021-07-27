using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    public class SeguroDeVida : ITributavel
    {

        const double Tributo = 42.0;

        public double CalcularTributo()
        {
            return Tributo;
        }
    }
}
