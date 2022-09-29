using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.KISIM

            Console.Write("Kaç Sayı Gireceksin?");
            int nSayisi = int.Parse(Console.ReadLine());
            int[] TumSayilar = new int[nSayisi];
            if (0 < nSayisi)
            {
                for (int i = 0; i < nSayisi; i++)
                {
                    Console.WriteLine((i + 1) + ". Sayı Kaç");
                    TumSayilar[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < TumSayilar.Length; i++)
                {
                    if (TumSayilar[i] % 2 == 0)
                    {
                        Console.WriteLine((i + 1) + ". Çift Tam Bölünen Eleman = " + TumSayilar[i]);
                    }
                }

            }
            else
            {
                Console.WriteLine("Pozitifi Sayı Giriniz");
            }

            // 2.KISIM

            Console.Write("Kaç Sayı Gireceksin?");
            int nSayisi = int.Parse(Console.ReadLine());
            Console.Write("Hangi Sayıya Modlayacaksınız?");
            int mSayisi = int.Parse(Console.ReadLine());
            int[] TumSayilar = new int[nSayisi];
            if (0 < nSayisi)
            {
                for (int i = 0; i < nSayisi; i++)
                {
                    Console.WriteLine((i + 1) + ". Sayı Kaç");
                    TumSayilar[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < TumSayilar.Length; i++)
                {
                    if (TumSayilar[i] % mSayisi == 0)
                    {
                        Console.WriteLine((i + 1) + ". " + mSayisi + " Tam Bölününen Eleman = " + TumSayilar[i]);
                    }
                }

            }
            else
            {
                Console.WriteLine("Pozitifi Sayı Giriniz");
            }

            // 3.KISIM

            Console.Write("Kaç Sayı Gireceksin? ");
            int nSayisi = int.Parse(Console.ReadLine());
            String[] tumKelimeler = new String[nSayisi];
            if (0 < nSayisi)
            {
                for (int i = 0; i < nSayisi; i++)
                {
                    Console.WriteLine((i + 1) + ". Kelimeyi Giriniz");
                    tumKelimeler[i] = Convert.ToString(Console.ReadLine());

                }
                Array.Reverse(tumKelimeler);

                for (int i = 0; i < tumKelimeler.Length; i++)
                {

                    Console.WriteLine((i + 1) + ". " + tumKelimeler[i]);

                }

            }
            else
            {
                Console.WriteLine("Pozitifi Sayı Giriniz");
            }

            // 4.KISIM

            Console.WriteLine("bir cümle giriniz");
            string cumle = Console.ReadLine().Trim();
            string[] dizi = cumle.Split(' ');
            int kelimeSayisi = dizi.Count();
            if (kelimeSayisi > 1)
            {
                Console.WriteLine("Kelime Sayısı: "+kelimeSayisi);
                Console.Write("cümlenizdeki harf sayısı :" + (cumle.Length - kelimeSayisi + 1));
            }

                Console.ReadKey();
        }
    }
}
