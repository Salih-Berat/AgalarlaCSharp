using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BABAANNENİN EN SEVDİĞİ LOGİN UYGULAMASINA HOŞ GELDİN!");
            int a = 0;
            while(a <= 2)
            {
                string abegi = ("abisi");
                string abisi = ("abegi");

            Console.Write("Kullanıcı Adı gir adamı hasta etme = ");
            string kullaniciadi = Console.ReadLine();
            Console.Write("gir şu lanet olası şifreyi : ");
            string şifre = Console.ReadLine();


                if (kullaniciadi != abegi || şifre != abisi)
                {
                    a += 1;

                    if (a == 3)
                    {

                        Console.WriteLine("Hakkın bitti seni gay!");
                        Console.ReadLine();
                        break;
                    }


                    Console.WriteLine("sen kimi kandırıyon he !!! benim alnımda enayi mi yazıyo gerçeğini gir hemen");
                    Console.ReadLine();


                }




                else if (kullaniciadi == abegi && şifre == abisi)
                {
                    Console.WriteLine("Bu seferlik girmeyi başardın seni ucube ama bir dahaki sefere bu kadar kolay olmayacak (╯°□°）╯︵ ┻━┻ ");
                    Console.ReadLine();
                    break;





                }


            }
        }
    }
}
            
