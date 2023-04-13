namespace ListaExercicioOO.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotasEscolares notasAlunos = new NotasEscolares();

            Console.WriteLine("Calculadora de Média");
            Console.WriteLine();
            Console.WriteLine("Digite a nota do 1º Bimestre: ");
            notasAlunos.notaUmBimestre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do 2º Bimestre: ");
            notasAlunos.notaDoisBimestre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do 3º Bimestre: ");
            notasAlunos.notaTresBimestre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do 4º Bimestre: ");
            notasAlunos.notaQuatroBimestre = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sua média final é " + notasAlunos.CalcularMediaHarmonica());
            Console.ReadLine();
        }
    }
}