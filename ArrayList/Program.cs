using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList liste=new ArrayList();
        //    liste.Add("ayse");
        //    liste.Add(12);
        //    liste.Add(true);
        //    liste.Add('A');
        //    Console.WriteLine(liste[1]);
        //    foreach (var lst in liste)
        //    {
        //     Console.WriteLine(lst);
        //    }
        //    //adrange birden fazla elemanı aynı anda nasıl ekleriz
        //    string[] renk={"sarı","mavi"};
           List<int> sayi=new List<int>(){1,2,3,4,5};
           //liste.AddRange(renk);
           liste.AddRange(sayi);
           foreach (var lst in liste)
           {
            Console.WriteLine(lst);
           }
           //sort
           liste.Sort();//bunun icin değerlerin int olması lazim liste içerisindeki
           foreach (var list_e in liste)
           {
             Console.WriteLine(list_e);
           }
           Console.WriteLine(liste.BinarySearch(3));
           //REVERSE BÜYÜKTEN küçüğe veya küçükten büyüğe sırala
           liste.Reverse();
           foreach (var list_e in liste)
           {
             Console.WriteLine(list_e);
           }
           liste.Clear();
           foreach (var list_e in liste)
           {
             Console.WriteLine(list_e);
           }
        }
    }
}
