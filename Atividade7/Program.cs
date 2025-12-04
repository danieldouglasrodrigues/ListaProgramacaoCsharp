using System;

public class Atividade7
{
    public static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;

        int[] vetor = new int[TAMANHO_VETOR];

        long soma = 0;

        Console.WriteLine("## Leitura de 10 Números Inteiros ##");

        for (int i = 0; i < TAMANHO_VETOR; i++)
        {
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write($"Digite o número inteiro para a posição {i + 1} de {TAMANHO_VETOR}: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int numero))
                {
                    vetor[i] = numero;
                    soma += numero;
                    entradaValida = true; 
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite APENAS um número inteiro.");
                }
            }
        }

        double media = (double)soma / TAMANHO_VETOR;

        int contadorSuperiorAMedia = 0;

        foreach (int elemento in vetor)
        {
            if (elemento > media)
            {
                contadorSuperiorAMedia++;
            }
        }

        Console.WriteLine("\n=============================================");
        Console.WriteLine("## Resultados da Análise do Vetor ##");
        Console.WriteLine("=============================================");

        Console.WriteLine($"Média Aritmética dos elementos: {media:F2}");

        Console.WriteLine($"Quantidade de elementos estritamente acima da média: {contadorSuperiorAMedia}");
        Console.WriteLine("=============================================");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}