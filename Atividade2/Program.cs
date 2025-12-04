using System;

public class Atividade2
    {
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Verificador de Número Par ou Ímpar ---");
        Console.WriteLine("------------------------------------------");

        bool inputValido = false;
        int numero = 0;

        while (!inputValido)
        {
            Console.Write("\nDigite um número inteiro: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                inputValido = true;

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"\nO número {numero} é PAR.");
                }
                else
                {
                    Console.WriteLine($"\nO número {numero} é ÍMPAR.");
                }
            }
            else
            {
                Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um número inteiro.");
            }
        }

        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}