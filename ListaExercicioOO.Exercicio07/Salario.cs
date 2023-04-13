using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicioOO.Exercicio07
{
    internal class Salario
    {
        public double salarioBase, vendas, comissao, salarioTotal, comissaoFinal;

        public double CalcularComissaoVendas()
        {
            comissaoFinal = comissao / 100 * vendas;
            salarioTotal = salarioBase + comissaoFinal;
            return salarioTotal;
        }
    }
}
