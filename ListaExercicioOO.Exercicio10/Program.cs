namespace ListaExercicioOO.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaEscolar mediaPonderada = new MediaEscolar();

            Console.WriteLine("Cálculo de Média Ponderada");
            Console.WriteLine();
            Console.WriteLine("Digite o valor da primeira nota: ");
            mediaPonderada.nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira nota: ");
            mediaPonderada.peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota: ");
            mediaPonderada.nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da segunda nota: ");
            mediaPonderada.peso2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Sua média final é: {mediaPonderada.CalcularMediaPonderada()}");

        }
    }
}