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
            Console.WriteLine("KİM İYİ VÜCUD İSTER!");


            Console.Write("Kilonu Bi Yazıversene: ");
            string Kilo = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Dolandırıcı Değilim Boyunuzu Da Alabilir miyim (Örnek 170 cm olan bir kişi 1,70 olarak yazar): ");
            string Boy = Console.ReadLine();

            double BoyOndalik = double.Parse(Boy);

            short KiloSayi = short.Parse(Kilo);
            int BoySayi = Convert.ToInt32(BoyOndalik);

            int KitleOlcer = KiloSayi / (BoySayi * BoySayi);

            if (KitleOlcer <= 18)
            {
                Console.WriteLine("Zayıfsın Biraz Yemek Ye");
                Console.ReadLine();

            }

            else if (KitleOlcer >= 19 && KitleOlcer <= 24)
            {
                Console.WriteLine("Eh işte Orta");
                Console.ReadLine();
            }

            else if (KitleOlcer > 25)
            {
                Console.WriteLine("Ye Babam Ye Bi Yere Kadar Biraz Az Ye Şişko");
                Console.ReadLine();
            }


        }
    }
}
