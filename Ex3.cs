using System;

class Ex3
{
    static void Main()
    {
        int[,] matriz = new int[3, 5];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Valor [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            int soma = 0;
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine($"Soma da linha {i}: {soma}");
        }
    }
}
