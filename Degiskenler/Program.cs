using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger=2;
            string degisken=null;
            string Degisken=null;
            string degisken_10=null; //sınırsız
             Console.WriteLine(degisken);
            Console.WriteLine(deger);

            byte b = 5; //1 byte
            sbyte c=5; ///1 byte
            short s=5; //2 byte 
            ushort u=5; //2 byte 
            Int16 i16=2; //2 byte 
            int i=2; // 4 byte
            Int32 i32=2; // 4 byte
            Int64 i64=2; //8 byte

            uint ui=2; //4 byte
            long l=4;  //8 byte
            ulong ul=4; //8byte
            float f=5; //reel sayılar tam sayılar 4 byte
            double d=5; //reel sayılar tam sayılar 8 byte
            decimal de=5; //reel sayılar tam sayılar 16 byte
            char ch='2'; //2 byte 


            bool bl=true;
            bool b2=false;
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);
            object o1='x';
            object o2=2;
            object o3=4.3;
            
            string str1=string.Empty;
            str1="nazlı yarıscı";
            string ad="naz";
            string soyad="yarıscı";
            string tamisim=ad+" "+soyad;

            int int1=5;
            int int2=3;
            int int3=int1*int2;


            bool b1=10<2;
            
            //değişken dönüşüm
            string str20="20";
            int int20=20;
            string yenideger=str20+int20.ToString();
            Console.WriteLine(yenideger); // cıktı 2020


            //int değişim
            int int21=int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);  //cıktı 40

            int int22=int20+int.Parse(str20); //cıktı 20
            //parse string donusum icin


            //Datetime dönusum
            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
             Console.WriteLine(datetime);
             string hour=DateTime.Now.ToString("HH.mm");
              Console.WriteLine(hour);



           
        }
    }
}