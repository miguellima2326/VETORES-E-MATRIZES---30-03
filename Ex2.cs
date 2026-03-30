using System;

class Ex2
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[] precos = new double[10];

        // Cadastro
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Preço: ");
            precos[i] = double.Parse(Console.ReadLine());
        }

        // Pesquisa
        Console.Write("\nDigite o valor máximo: ");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("\nProdutos encontrados:");

        for (int i = 0; i < 10; i++)
        {
            if (precos[i] <= valor)
            {
                Console.WriteLine($"{nomes[i]} - R$ {precos[i]:F2}");
            }
        }
    }
}
