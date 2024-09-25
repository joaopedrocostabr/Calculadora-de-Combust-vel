using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo à Calculadora de Combustível!");

        // Solicita o preço da gasolina
        Console.Write("Digite o preço da gasolina: R$ ");
        double precoGasolina = Convert.ToDouble(Console.ReadLine());

        // Solicita o preço do etanol
        Console.Write("Digite o preço do etanol: R$ ");
        double precoEtanol = Convert.ToDouble(Console.ReadLine());

        // Calcula a relação etanol/gasolina
        double relacao = precoEtanol / precoGasolina;

        Console.WriteLine($"\nA relação entre o preço do etanol e da gasolina é: {relacao:P2}");

        // Verifica qual combustível compensa mais
        if (relacao < 0.7)
        {
            Console.WriteLine("Abastecer com etanol é mais vantajoso.");
        }
        else
        {
            Console.WriteLine("Abastecer com gasolina é mais vantajoso.");
        }

        Console.WriteLine("\nObrigado por usar a Calculadora de Combustível!");
    }
}
