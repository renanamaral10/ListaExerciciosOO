using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio08
{
    internal class VolumeLata
    {
        public double pi = 3.14, altura, raio, diametro, volume;

        public double CalcularVolumeLata()
        {
            raio = diametro / 2;
            volume = pi * (raio * raio) * altura;
            return volume;
    }   }
}
