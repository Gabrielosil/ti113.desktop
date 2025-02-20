namespace Exercicio4
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
                    Console.Write("Digite o terceiro número: ");
                    if (double.TryParse(Console.ReadLine(), out double numero3))
                    {
                        double maior = Math.Max(numero1, Math.Max(numero2, numero3));
                        Console.WriteLine($"O maior número é: {maior}");
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
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número válido.");
            }
        }
    }
}