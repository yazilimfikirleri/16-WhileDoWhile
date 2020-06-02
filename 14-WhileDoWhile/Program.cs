using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //For döngüsü gibi, Bir işi belirli sayıda yapmamızı sağlayan döngüdür.For döngüsünden farklı olarak döngü başlangıç değeri ve iterasyon bilgisi döngü içerisinde belirtilmez.
            //int i = 1;
            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.Read();

            //While Döngüsü Kullanarak 1'den 10'a kadar çarpım tablosunu ekranda yazdırma.

            //int y = 1;
            //while (y <= 10)
            //{
            //    int z = 1;
            //    while (z <= 10)
            //    {
            //        Console.WriteLine($"{y}x{z}={y * z}");
            //        z++;
            //    }
            //    Console.WriteLine("------");
            //    y++;
            //}
            //Console.Read();

            //Do..While
            //Do while döngüsü, while döngüsü ile aynı yapıya sahiptir. While döngüsünde ki gibi iterasyon ve döngünün başlangıç değeri döngü dışarısında belirtilir. Tek farkı, Do While döngüsü ne olursa olsun en az 1 kez çalışır. Diğer döngüler şart sağlandığında çalışırken, do while döngüsü şart ne olursa olsun bir kez çalışacaktır. 

            //int sayi = 1;
            //do
            //{
            //    Console.WriteLine("sayı=" + sayi);
            //    sayi++;
            //}
            //while (sayi <= 100);
            //Console.Read();

            int x, y, sonuc;
            string devam;
            do
            {
                y = 1;
                Console.WriteLine("Çarpım tablosu oluşturulacak sayıyı girin.");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x + " Çarpım tablosu");
                while (y <= 10)
                {
                    sonuc = y * x;
                    Console.WriteLine(y + "*" + x + "=" + sonuc);
                    y++;
                }
                Console.WriteLine("başka bir çarpım tablosu oluşturmak ister misin?(E/H)");
                devam = Console.ReadLine();
            }
            while (devam == "E" || devam == "e");

        }
    }
}
