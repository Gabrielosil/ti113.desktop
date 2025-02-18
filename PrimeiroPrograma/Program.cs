namespace PrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("\n");
            Console.Write("Informe a Nota 1: ");
            //float nota1 = Convert.ToSingle(Console.ReadLine()!);
            float nota1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("Informe a Nota 2: ");
            float nota2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.Write("Informe a Nota 3: ");
            float nota3 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");

            float soma = nota1 + nota2 + nota3;
            //decimal media = Convert.ToInt64(soma / 3); "Para tranformar decimal em 64 bit"
            double media = (soma / 3);

            Console.WriteLine($"A média de {nome} é {media}");

        }
    }
}