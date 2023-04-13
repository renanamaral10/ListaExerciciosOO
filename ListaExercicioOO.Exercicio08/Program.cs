namespace ListaExercicioOO.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeLata latas = new VolumeLata();

            Console.WriteLine("Cálculo do Volume de Uma Lata de Óleo");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do diâmetro da lata: ");
            latas.diametro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da lata: ");
            latas.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O volume da lata é de " + latas.CalcularVolumeLata() + " mL.");
        }
    }
}