using System;

class Ex1
{
    static void Main()
    {
        int[] vetor = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nValores nas posições pares:");

        for (int i = 0; i < 15; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Posição {i}: {vetor[i]}");
            }
        }
    }
}
