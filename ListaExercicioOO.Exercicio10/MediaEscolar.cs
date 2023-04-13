using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio10
{
    internal class MediaEscolar
    {
        public decimal peso1, nota1, peso2, nota2, notaFinal;
        public decimal CalcularMediaPonderada()
        {
            notaFinal = (peso1 * nota1 + peso2 * nota2) / (peso1 + peso2);
            notaFinal = Math.Round(notaFinal, 2);
            return notaFinal;
    }   }
}
