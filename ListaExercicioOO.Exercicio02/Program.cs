namespace ListaExercicioOO.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularFahrenheit valorFahrenheit = new CalcularFahrenheit();

            Console.WriteLine("Conversor de Escalas - Fahrenheit para Celsius");
            Console.WriteLine("Digite o valor em graus Fº: ");

            valorFahrenheit.fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O resultado é:{valorFahrenheit.ConverterFahrenheitParaCelsius()}ºC");
            Console.ReadLine();
        }
    }
}