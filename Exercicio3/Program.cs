namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            if (double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.WriteLine("\n");
                Console.Write("Digite o segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double numero2))
                {
                    Console.WriteLine("\n");
                    if (numero1 > numero2)
                    {
                        Console.WriteLine($"O maior número é: {numero1}");
                    }
                    else if (numero2 > numero1)
                    {
                        Console.WriteLine($"O maior número é: {numero2}");
                    }
                    else
                    {
                        Console.WriteLine("Os números são iguais.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número válido.");
            }
        }
    }
}