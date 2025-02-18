namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 7: ");

            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 7)
            {
                string[] diasSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira",
                                    "Quinta-feira", "Sexta-feira", "Sábado" };

                Console.WriteLine($"O dia correspondente é: {diasSemana[numero - 1]}");
            }
            else
            {
                Console.WriteLine("Número inválido! Digite um valor entre 1 e 7.");
            }
        }
    }
}
        
    
