using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Döngüsü_Falan_Filan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kaç Satır Sayın Olsun Agam: ");
            string SatırA = Console.ReadLine();

            Console.Write("Sayın Kaçıncı Sayıdan Başlasın Agam: ");
            string SayıBaşlamasıB = Console.ReadLine();

            long a = long.Parse(SatırA);
            long b = long.Parse(SayıBaşlamasıB);

            for(long Açılış = b; Açılış <= a ; Açılış++)
            {
                for(long AçılışınAbisi = 1; AçılışınAbisi <= Açılış; AçılışınAbisi++)
                {  
                Console.Write(AçılışınAbisi);
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
