﻿using System;

namespace Donguler_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
             //WHİLE

            // 1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsol a yazdıran program

            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac; // toplam = toplam + sayac
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //'a' dan 'z' ye kadar tüm harfleri konsola yazdır

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }

            //FOREACH

            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadKey();

        }
    }
}
