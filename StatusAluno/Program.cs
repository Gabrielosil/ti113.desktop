namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;
            string mensagem = "";
            double media = 0;

            Console.WriteLine("Informe a 1a nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Informe a 2a nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                mensagem = "Aprovado";
            }
            else if (media >= 5 && media < 7)
            {
                mensagem = "Recuperação";
            }
            else
            {
                mensagem = "Reprovado";
            }

            Console.WriteLine($"O Status do Aluno de Média: {media} é {mensagem}");
        }
    }
}