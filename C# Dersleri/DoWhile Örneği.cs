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

                Console.Write("Hangi Sayıya Kadar Toplamak İstiyorsun: ");
                string SayiA = Console.ReadLine();

                long A = long.Parse(SayiA);
                long toplamm = 0;

                long b = 1;
                do
                {

                    toplamm = b + toplamm ;
                    b++;


                } while (b<=A);

                Console.WriteLine("Toplam: " + toplamm);

                Console.ReadLine(); 


            int a = 1;
            int toplam = 0;
            Console.Write("kaça kadar olan sayılar toplansın: ");
            string sayix = Console.ReadLine();

            int x = int.Parse(sayix);

            do
            {
                toplam = a + toplam;
                a++;
            } while (a<=x);

            Console.WriteLine("Toplamların: " + toplam);
            Console.ReadLine();

        }
    }
}
