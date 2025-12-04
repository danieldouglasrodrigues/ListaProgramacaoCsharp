using System;

public class Atividade8
{
    public static void Main(string[] args)
    {
        const int TAMANHO_AB = 5;

        const int TAMANHO_C = TAMANHO_AB * 2;

        int[] vetorA = { 1, 3, 5, 7, 9 };
        int[] vetorB = { 2, 4, 6, 8, 10 };

        int[] vetorC = new int[TAMANHO_C];

        for (int i = 0; i < TAMANHO_AB; i++)
        {
            int indexC_A = 2 * i;
            vetorC[indexC_A] = vetorA[i];

            int indexC_B = 2 * i + 1;
            vetorC[indexC_B] = vetorB[i];
        }

        Console.WriteLine("## Mescla Alternada de Vetores (CLI C#) ##");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine($"Vetor A original: {{ {string.Join(", ", vetorA)} }}");
        Console.WriteLine($"Vetor B original: {{ {string.Join(", ", vetorB)} }}");

        Console.WriteLine("\nResultado do Vetor C (Preenchimento Alternado):");
        Console.WriteLine($"Vetor C preenchido: {{ {string.Join(", ", vetorC)} }}");

        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}