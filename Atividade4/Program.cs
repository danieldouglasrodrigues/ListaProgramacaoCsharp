using System;

public class Atividade4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Calculadora de Fatorial (n!) ---");
        Console.WriteLine("------------------------------------");

        int numero = 0;
        bool inputValido = false;

        while (!inputValido)
        {
            Console.Write("\nDigite um número inteiro não negativo para calcular o fatorial: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                if (numero >= 0)
                {
                    inputValido = true;

                    long fatorial = 1;

                    Console.WriteLine("\n------------------------------------");

                    if (numero > 1)
                    {
                        for (int i = 2; i <= numero; i++)
                        {
                            fatorial *= i;
                        }
                    }

                    Console.WriteLine($"Fatorial de {numero} ({numero}!):");
                    Console.WriteLine($"\n** Resultado: {fatorial} **");
                }
                else
                {
                    Console.WriteLine("ERRO: O fatorial só é definido para números inteiros não negativos (0, 1, 2, ...).");
                }
            }
            else
            {
                Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um número inteiro válido.");
            }
        }

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}