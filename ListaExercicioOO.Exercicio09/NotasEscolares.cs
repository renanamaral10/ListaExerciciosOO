using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio09
{
    internal class NotasEscolares
    {
        public double notaUmBimestre, notaDoisBimestre, notaTresBimestre, notaQuatroBimestre, mediaHarmonica;

        public double CalcularMediaHarmonica()
        {
            mediaHarmonica = 4 / ((1 / notaUmBimestre) + (1 / notaDoisBimestre) + (1 / notaTresBimestre) + (1 / notaQuatroBimestre));
            mediaHarmonica = Math.Round(mediaHarmonica, 2);
            return mediaHarmonica;
    }   }
}
