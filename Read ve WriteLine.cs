using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgalarlaCsharp
{
    class Program
    {
        static void Main(string[] args)
         // salih aga gibi buraya yazmayın iki parantezin arasına yazmanız lazım.
        {
            /*Buraya kodlar yazılacak.    
            Ana kodun altına yardımcı kod yazıldığında tab atalım!
            Console.Read(); ve Console.ReadLine(); çıktıyı uzun süre tutmak için yazılan koddur yoksa işlem bittikten sonra hemen program kapanır
            Console.ReadLine(X); kodu X e atanmış değeri ortaya çıkarmak içindir.
            Console.Read(); diye çıktı yaptırmaya çalıştığımızda bazen çıktılarda bug olup göstermeyebilir. Bu yüzden Console.ReadLine(); yazalım!
            Console.WriteLine("X"); kodu tek bir satıra X yazısını yazdırır.
            Console.Write("X"); iki tane yazarsak bunlar yan yana olur.*/


            Console.WriteLine("Salih Adam");  /* burada Writeline yazılıldığında ne olcağını gördük */

            Console.Writeline("salik adam");  /* tekrar yazdığımızda yanına değil altına çıktı alırız */

            Console.Write("Mehmet");          /* ama burda yaptığımızda yanında .ıktı alırız */
            Console.Write(" Zahid pekince");  /* bu yazdığımız üstteki mehmet yazısının yanına yazılır*/

            Console.ReadLine();               /* Burada yazdığımız Readline kodun hemen kapanmaması için kullanılır.bunu yazmasaydık ekranda yazdıklarımız hemen açılıp acaktı*/

        }
    }
}
