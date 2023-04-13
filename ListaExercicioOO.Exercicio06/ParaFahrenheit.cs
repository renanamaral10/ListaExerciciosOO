using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio06
{
    internal class ParaFahrenheit
    {
        public double celsius, fahrenheit;
        public double ConverterParaFahrenheit()
        {
            fahrenheit = celsius * 1.8 + 32;
            fahrenheit = Math.Round(fahrenheit, 2);
            return fahrenheit;
        }

    }
}
