using System;

class Ex4
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        int valor = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = valor++;
            }
        }

        Console.WriteLine("Diagonal Principal:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }

        Console.WriteLine("\nDiagonal Secundária:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, 4 - i] + " ");
        }
    }
}
