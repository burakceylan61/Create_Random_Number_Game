using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_üretme
{
    internal class Program
    {

        static Random sayiuretme = new Random();   //method
        static void Main(string[] args)
        {

            int tahmin, sayi = sayiuretme.Next(20); //kosul ve sayı üretme fonksiyonumuz.
           
            while (true)
            {
                Console.WriteLine("sayi giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());
              
                if (tahmin == 3)
                {
                    Console.WriteLine("KAYBETTİNİZ! Tutulan sayi: " + sayi);
                    break;
                }
               else  if  (tahmin > sayi)
                {
                    Console.WriteLine("kucuk sayi girniz ");
                }

                else if (tahmin < sayi)
                {
                    Console.WriteLine("büyük sayi giriniz ");
                }
                else if(sayi%2==0)
                   Console.WriteLine("dogru sayı cift ");
                else
                {
                    Console.WriteLine("dogru sayı tek : ");

                }          

                }

            }
        }
    }


