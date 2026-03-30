using System;

class Ex6
{
    static char[,] tabuleiro = new char[3, 3];

    static void Main()
    {
        Inicializar();
        Jogar();
    }

    static void Inicializar()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tabuleiro[i, j] = '-';
    }

    static void Mostrar()
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(tabuleiro[i, j] + " ");

            Console.WriteLine();
        }
    }

    static void Jogar()
    {
        char jogador = 'X';

        for (int turno = 0; turno < 9; turno++)
        {
            Mostrar();

            Console.WriteLine($"\nJogador {jogador}:");
            Console.Write("Linha (0-2): ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Coluna (0-2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (tabuleiro[linha, coluna] == '-')
            {
                tabuleiro[linha, coluna] = jogador;

                if (VerificarVitoria(jogador))
                {
                    Mostrar();
                    Console.WriteLine($"Jogador {jogador} venceu!");
                    return;
                }

                jogador = (jogador == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Posição ocupada!");
                Console.ReadKey();
                turno--;
            }
        }

        Mostrar();
        Console.WriteLine("Empate!");
    }

    static bool VerificarVitoria(char j)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((tabuleiro[i, 0] == j && tabuleiro[i, 1] == j && tabuleiro[i, 2] == j) ||
                (tabuleiro[0, i] == j && tabuleiro[1, i] == j && tabuleiro[2, i] == j))
                return true;
        }

        if ((tabuleiro[0, 0] == j && tabuleiro[1, 1] == j && tabuleiro[2, 2] == j) ||
            (tabuleiro[0, 2] == j && tabuleiro[1, 1] == j && tabuleiro[2, 0] == j))
            return true;

        return false;
    }
}
