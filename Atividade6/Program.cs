using System;

public class Atividade6
{
    public static void Main(string[] args)
    {
        const int TamanhoVetor = 5;

        int[] vetor = new int[TamanhoVetor];

        Console.WriteLine("## Preenchimento do Vetor ##");

        for (int i = 0; i < TamanhoVetor; i++)
        {
            Console.Write($"Digite o número inteiro para a posição {i}: ");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                vetor[i] = numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                i--; 
            }
        }

        Console.WriteLine("\n--- Elementos na Ordem Inversa ---");

        for (int i = TamanhoVetor - 1; i >= 0; i--)
        {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}