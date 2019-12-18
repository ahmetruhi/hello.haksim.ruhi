using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello.haksim.ruhi
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayac=0;
            //while(sayac<5)
            //{
            //    Console.WriteLine("Gazi");
            //    sayac++;
            //}



            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı Giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Girdiğiniz Sayları Toplamı:{toplam}");



            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //while(sayi!=0)
            //{
            //    toplam += sayi;
            //    Console.WriteLine("Bir sayı giriniz:");
            //    sayi = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Girdiğiniz sayıların toplamı:{toplam}"); (((Console.WritLine'ı tekrar tekrar yazmaya gerek yok)))


            int toplam = 0;
            int sayi;
            do
            {
                Console.WriteLine("Sayı giriniz:");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
            } while (sayi != 0);
            Console.WriteLine($"Girdiğiniz sayıları toplamı:{toplam}");



            Console.ReadKey();
        }
    }
}
