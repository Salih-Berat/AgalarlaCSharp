using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zunla_hesap
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Notunuz Ne: ");
            string Not1 = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("2. Notunuz Ne: ");
            string Not2 = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("3. Notunuz Ne: ");
            string Not3 = Console.ReadLine();

            byte Not1Byte = Convert.ToByte(Not1);
            byte Not2Byte = Convert.ToByte(Not2);
            byte Not3Byte = Convert.ToByte(Not3);

            int Ortalama = (Not1Byte + Not2Byte + Not3Byte) / 3;

            if (Ortalama >= 80)
            {
                Console.WriteLine("Ortalaman:" + Ortalama + " Sen adamın erkek çalışanısın");
                Console.ReadLine();
            }

            else if (Ortalama <= 60)
            {
                Console.WriteLine("Ortalaman:" + Ortalama + " Bi tık Mal mı nesin");
                Console.ReadLine();
            }

            else if (Ortalama <= 40)
            {
                Console.WriteLine("Ortalaman:" + Ortalama + " Sen malın değnesin be agam");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Agam sen mala benziyon bişi girmeden ne notu bekliyon");

            }


        }
    }
}
