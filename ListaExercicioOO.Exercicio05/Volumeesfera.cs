using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio05
{
    internal class VolumeEsfera 
    {
        public double volume, raio, diametro, pi = 3.14;
        public double CalcularVolumeEsfera()
        {
            raio = diametro / 2;
            volume = 1.33 * pi * (raio * raio * raio);

            volume = Math.Round(volume, 2);

            return volume;
        }
    }
}