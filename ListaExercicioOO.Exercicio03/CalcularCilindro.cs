using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio03
{
    internal class CalcularCilindro
    {
        public double altura, raio, volume, pi = 3.14;
        public double calcularvolume()
        {
            raio = raio * raio;
            volume = pi * (altura * raio);
            return volume;
        }
    }
}
