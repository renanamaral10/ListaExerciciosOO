using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio04
{
    internal class CombustivelKm
    {
        public double kilometroInicial, kilometroFinal, KilometroTotal, mediaKilometros, litrosCombustivel;

        public double CalcularMediaCombustivel()
        {
            KilometroTotal = kilometroFinal - kilometroInicial;
            mediaKilometros = KilometroTotal / litrosCombustivel;
            mediaKilometros = Math.Round(mediaKilometros, 2);
            return mediaKilometros;
        }
    }
}
