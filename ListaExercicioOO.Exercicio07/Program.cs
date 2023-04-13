namespace ListaExercicioOO.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.WriteLine("Cálculo de Salário");
            Console.WriteLine();
            Console.WriteLine("Digite o salário base em reais: ");
            salario.salarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor em reais das vendas: ");
            salario.vendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número da porcentagem da comissão: ");
            salario.comissao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O seu salário total esse mês é {salario.CalcularComissaoVendas()}");
        }
    }
}