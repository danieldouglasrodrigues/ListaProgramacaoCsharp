using System;

public class Atividade3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Conversor de Temperatura (°C para °F) ---");
        Console.WriteLine("---------------------------------------------");

        double celsius = 0.0;
        double fahrenheit = 0.0;
        bool inputValido = false;

        while (!inputValido)
        {
            Console.Write("\nDigite a temperatura em graus Celsius (°C): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out celsius))
            {
                inputValido = true;

                fahrenheit = (celsius * 1.8) + 32;

                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine($"Temperatura digitada: {celsius:F2}°C");
                Console.WriteLine($"\n** Temperatura convertida em Fahrenheit: {fahrenheit:F2}°F **");
            }
            else
            {
                Console.WriteLine("ERRO: Entrada inválida. Por favor, digite um valor numérico para a temperatura.");
            }
        }

        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}