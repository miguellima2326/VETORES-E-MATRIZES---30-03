using System;

class Ex5
{
    static void Main()
    {
        string[] alunos = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
            alunos[i] = Console.ReadLine();

            double soma = 0;

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                notas[i, j] = double.Parse(Console.ReadLine());
                soma += notas[i, j];
            }

            medias[i] = soma / 3;
        }

        Console.WriteLine("\nResultados:\n");

        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{alunos[i]} - Média: {medias[i]:F2} - {(medias[i] >= 7 ? "Aprovado" : "Reprovado")}");
        }

        Console.ResetColor();
    }
}
