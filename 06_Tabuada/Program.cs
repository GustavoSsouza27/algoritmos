using System;


namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int multiplicador = int.Parse(Console.ReadLine());
             
            if (multiplicador >= 1 || multiplicador >= 10)
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{multiplicador}, x {i} = {multiplicador * i}");
            }

        }
    }
}
