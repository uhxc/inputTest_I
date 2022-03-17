using System;

namespace inputTest_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine($"você digitou:\n{frase}\n{x}\n{y}\n{z}");
            Console.WriteLine($"{vet[0]} {vet[1]} {vet[2]}");



        }
    }
}
