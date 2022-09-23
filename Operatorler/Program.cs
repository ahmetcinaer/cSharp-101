using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
              int x=3;
           int y=3;
           y=y+2;
            Console.WriteLine(y);
           y+=2;
            Console.WriteLine(y);
           y/=1;
           Console.WriteLine(y);
           x*=2;
           Console.WriteLine(x);
           //Mantıksal operatorler
           bool isSuccess=true;
           bool isCompleted=false;

           if(isSuccess&&isCompleted)
           Console.WriteLine("perfect");

           if(isSuccess || isCompleted)
           Console.WriteLine("great");

           if(isSuccess &&! isCompleted)
           Console.WriteLine("fine");


           //ilişkisel operatorler
           int a=3;
           int b=4;
           bool sonuc=a<b;
           Console.WriteLine(sonuc);
            sonuc=a>b;
           Console.WriteLine(sonuc);
           sonuc=a>=b;
           Console.WriteLine(sonuc);
           sonuc=a<=b;
           Console.WriteLine(sonuc);
           sonuc=a==b;
           Console.WriteLine(sonuc);
           sonuc=a!=b;
           Console.WriteLine(sonuc);


           //Aritmetik operatorler

           int sayi1=10;
           int sayi2=5;
           int sonuc1=sayi1/sayi2;
           Console.WriteLine(sonuc1);
             sonuc1=sayi1*sayi2;
           Console.WriteLine(sonuc1);
           sonuc1=sayi1+sayi2;
           Console.WriteLine(sonuc1);
           sonuc1=sayi1-sayi2;
           Console.WriteLine(sonuc1);
           sonuc1=sayi1++;
           Console.WriteLine(sonuc1);

           //mod alma %
           int sonuc2=20%3;
           sonuc1=sayi1*sayi2;
           Console.WriteLine(sonuc2);
        }
    }
}
