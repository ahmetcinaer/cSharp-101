using System;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(31);
            sayiListesi.Add(17);
            sayiListesi.Add(7);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            // foreach ve list.foreach ile elemanlara erişim

            foreach (var sayi in sayiListesi)
                  Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman cıkarma 

            sayiListesi.Remove(7);
            renkListesi.Remove("kırmızı");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);


            // liste içerisinde arama 

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içersinde bulundu..");
            }


            //eleman ile indexe erişim

            //diziyi liste çevirme

            string[] hayvanlar = { "kedi", "kopek", "kus" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizlerim

            hayvanListesi.Clear();
           //listeyi nasıl temizleriz
           animals_list.Clear();
           //liste içerisinde nesne tutmak
           List<kullanici> kullanici_list=new List<kullanici>();
           kullanici kln=new kullanici();
           kln.Isim="test";
           kln.Soyisim="deneme";
           kln.Yas=25;

           kullanici kln2=new kullanici();
           kln2.Isim="t2";
           kln2.Soyisim="d2";
           kln2.Yas=30;
           kullanici_list.Add(kln);
           kullanici_list.Add(kln2);
           //listeye kullnici atama işlemi başka nasıl yapılır yeni bir kullanıcı listesi oluşturalım
            List<kullanici> yeniliste=new List<kullanici>();
            yeniliste.Add(new kullanici(){
                Isim="ayse",
                Soyisim="aaaa",
                Yas=15
            });
            foreach (var kullanici in kullanici_list)
            {
                Console.WriteLine("kullanici adi"+kullanici.Isim);
                Console.WriteLine("kullanici soyadi"+kullanici.Soyisim);
                Console.WriteLine("kullanici yas"+kullanici.Yas);
            }
            yeniliste.Clear();

         }
         public class kullanici
         {
             private string isim;
             private string soyad;
             private int yas;
             public string Isim{get=>isim; set=>isim=value;}
             public string Soyisim{get=>soyad; set=>soyad=value;}
             public int Yas{get=>yas; set=>yas=value;}

         }

        Console.ReadKey();
        
    }
}
