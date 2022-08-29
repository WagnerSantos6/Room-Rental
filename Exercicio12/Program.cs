using System;
using System.Globalization;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] vect = new Customer[10];

            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Customer (name, email);
            }


            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ", " + vect[i]);
                }
            }




        }
    }
}
