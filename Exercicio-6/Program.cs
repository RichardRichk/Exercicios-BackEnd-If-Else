using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, vamos ver se o aluno passou de ano ou esta reprovado\nQuantas aulas tem por ano?");
            int AulasAnuais = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quantas Aulas o aluno faltou ?");
            int AulasFaltantes = int.Parse(Console.ReadLine());
            
        }
    }
}

