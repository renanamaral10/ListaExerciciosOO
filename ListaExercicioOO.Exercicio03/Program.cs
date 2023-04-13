namespace ListaExercicioOO.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularCilindro calcularCilindro = new CalcularCilindro();
            Console.WriteLine("Cálculo do Volume de Cilindro");

            Console.WriteLine("Digite o valor do raio: ");
            calcularCilindro.raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            calcularCilindro.altura = Convert.ToDouble(Console.ReadLine());

        }
    }
}