using System;

public class Atividade1
{
    public static void Main(string[] args)
    {
        double[] notas = new double[4];
        double soma = 0;
        double media;

        Console.WriteLine("--- Calculadora de Média Aritmética Simples ---");
        Console.WriteLine("---------------------------------------------");

        for (int i = 0; i < 4; i++)
        {
            bool inputValido = false;

            while (!inputValido)
            {
                Console.Write($"\nDigite a nota {i + 1} (Ex: 8.5 ou 8,5): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out notas[i]))
                {
                    inputValido = true;
                    soma += notas[i];
                }
                else
                {
                    Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um número válido (use ponto ou vírgula conforme a configuração do seu sistema).");
                }
            }
        }

        media = soma / 4.0;

        Console.WriteLine("\n---------------------------------------------");

        Console.WriteLine($"Soma total das notas: {soma:F2}");
        Console.WriteLine($"Número de notas: 4");
        Console.WriteLine($"\n** Média Aritmética Simples: {media:F2} **");

        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}