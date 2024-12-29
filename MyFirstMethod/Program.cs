using System;

namespace MyFirstMehod
{
    class Program
    {
        static void Main(string[] args)
        {

            void Lyrics()

            {
                Console.WriteLine("Show must go on!");
            }

            int RandomNumber()
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                return number % 2;
            }

            int ProductAxB(int a, int b)
            {

                return a * b;
            }

            void Hello(string name, string surname)
            {
                Console.WriteLine($"Hoş geldiniz {name} {surname}");
            }
            ///////////////////////////////////////////////////////////////////////

            Lyrics();

            int remainder = RandomNumber();
            Console.WriteLine($"Sayının ikiye bölümünden kalan: {remainder}");

            int product = ProductAxB(6, 8);
            Console.WriteLine($"Sayıların çapımı: {product}");

            Hello("Botan", "Elveren");

        }

    }
}