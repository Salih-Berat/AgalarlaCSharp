using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrenci numarasını gir: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("İsminizi yazın: ");
            string B = Console.ReadLine();

            Console.Write("Soyisminizi yazın:");
            string C = Console.ReadLine();

            Console.Write("1. Vize notunuzu yazın: ");
            int D = int.Parse(Console.ReadLine());

            Console.Write("2. Vize notunuzu yazın: ");
            int E = int.Parse(Console.ReadLine());

            Console.Write("Final notunuzu yazın: ");
            int F = int.Parse(Console.ReadLine());

            Console.Write("Okulunuzu yazın: ");
            string G = Console.ReadLine();

            bool kontrol = true;
            Ogrenci Öğrenci = new Ogrenci(A, B, C, D, E, F, G);
            //int , string , string , int ,int , int , string

            while (kontrol)
            {

                Console.WriteLine("1- Öğrenci Bilgilerini Göster");
                Console.WriteLine("2- Öğrenci ortalamasını göster");
                Console.WriteLine("3- Öğrencinin okulunu göster");
                Console.WriteLine("4- Çıkış");

                Console.Write("Hangi işlemi yapmak istiyorsunuz: ");

                string if1 = Console.ReadLine();
                if (if1 == "1")
                {
                    Console.WriteLine("");
                    Öğrenci.Bilgi();
                    Console.WriteLine("");
                    Console.ReadLine();
                }

                else if (if1 == "2")
                {
                    Console.WriteLine("");
                    Öğrenci.Not();
                    Console.WriteLine("");
                    Console.ReadLine();
                }

                else if (if1 == "3")
                {
                    Console.WriteLine("");
                    Öğrenci.Okulöğren();
                    Console.WriteLine("");
                    Console.ReadLine();
                }

                else if (if1 == "4")
                {
                    kontrol = false;

                }

            }



        }
    }
}
