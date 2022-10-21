using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.monday);         //monday
            Console.WriteLine((int)Gunler.tuesday);   //2

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("you should wait for going out..");
            }
            else if (sicaklik >= (int)HavaDurumu.warm)
            {
                Console.WriteLine("the wheather is so warm for going out..");
            }
            else if (sicaklik >= (int)HavaDurumu.normal && sicaklik<=(int)HavaDurumu.Hot)
            {
                Console.WriteLine("lets go out..");
            }


            Console.ReadLine();
        }
    }

    enum Gunler 
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    enum HavaDurumu
    {
        cold = 5,
        normal = 20,
        warm = 25,
        Hot = 30
    }
}
