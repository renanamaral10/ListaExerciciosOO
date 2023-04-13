namespace ListaExercicioOO.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CombustivelKm combustivelKm = new CombustivelKm();
            Console.WriteLine("Cálculo de Média de Combustível");
            Console.WriteLine();
            Console.WriteLine("Digite a quilometragem inicial do trajeto: ");
            combustivelKm.kilometroInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final do trajeto: ");
            combustivelKm.kilometroFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de litros no tanque: ");
            combustivelKm.litrosCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A média de combustível é de {combustivelKm.CalcularMediaCombustivel()} l/km");

        }
    }
}