using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsius
{
    public class Converter
    {
        public static double FahrenheitToCelsius(double F)
        {
            double C = 5 / 9 * (F - 32);

            return C;
        }

    }
}
