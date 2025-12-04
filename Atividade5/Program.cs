using System;

public class Atividade5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Gerador da Sequência de Fibonacci ---");
        Console.WriteLine("-----------------------------------------");

        int nTermos = 0;
        bool inputValido = false;

        while (!inputValido)
        {
            Console.Write("\nDigite o número de termos (N) que você deseja gerar (N >= 1): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out nTermos))
            {
                if (nTermos >= 1)
                {
                    inputValido = true;

                    Console.WriteLine("\n-----------------------------------------");

                    long termoAnterior1 = 0; // F(0)
                    long termoAnterior2 = 1; // F(1)

                    Console.Write($"Os {nTermos} primeiros termos da sequência de Fibonacci são: \n\n");

                    if (nTermos == 1)
                    {
                        Console.Write($"{termoAnterior1}");
                    }
                    else if (nTermos >= 2)
                    {
                        Console.Write($"{termoAnterior1}, {termoAnterior2}");

                        for (int i = 3; i <= nTermos; i++)
                        {
                            long proximoTermo = termoAnterior1 + termoAnterior2;

                            Console.Write($", {proximoTermo}");

                            termoAnterior1 = termoAnterior2;
                            termoAnterior2 = proximoTermo;
                        }
                    }
                    Console.WriteLine("\n"); // Adiciona uma nova linha após a sequência
                }
                else
                {
                    Console.WriteLine("ERRO: Por favor, digite um número inteiro positivo (igual ou maior que 1).");
                }
            }
            else
            {
                Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um número inteiro.");
            }
        }

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}