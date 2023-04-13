namespace ListaExercicioOO.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeEsfera esfera = new VolumeEsfera();

            Console.WriteLine("Cálculo do Volume de um Esfera");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do diâmetro da esfera: ");
            esfera.diametro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O volume da esfera é: {esfera.CalcularVolumeEsfera()}cm³");
            Console.ReadLine();

        }
    }
}