using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {

            /*                                                          22.05.2021 tarihli çalışmamız...
            
            int [] saybe = new int [4];

            saybe[0] = 21;
            saybe[1] = 22;
            saybe[2] = 23;
            saybe[3] = 24;

            for (int i = 0; i < saybe.Length; i++)
            {
                Console.WriteLine(saybe[i]);
            }




            int[] saybeiki = { 10 , 20 , 30 , 40  };

            for (int i = 0; i < saybeiki.Length; i++)
            {
                Console.WriteLine(saybeiki[i]);

            }


            string[] isimimiz = new string[3];

            isimimiz[0] = "salik";
            isimimiz[1] = "zahid";
            isimimiz[2] = "Mehmet";

            for (int i = 0; i < isimimiz.Length; i++)
            {
                Console.WriteLine(isimimiz[i]);
            }


            double[] onda = {1.12 , 1.13 };

            for (int i = 0; i < onda.Length; i++)
            {
                Console.WriteLine(onda[i]);
            } 

            int[] say = new int[4];

            for (int i = 0; i < say.Length; i++)
            {
                Console.Write((i+1) + (". Değeri gir: "));
                say [i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("*****************************************"); 

            for (int i = 0; i < say.Length; i++)
            {

                Console.WriteLine(say[i]);
            } */

            /*  object[] anneanne = new object[4];

            anneanne[0] = "salik";
            anneanne[1] = 26;
            anneanne[2] = "Mehmet";
            anneanne[3] = 56; 

            for (int i = 0; i < anneanne.Length; i++)
            {
                Console.Write((i+1) + (". Değeri Gir:"));
                anneanne[i] = Console.ReadLine();
            }

            foreach(object S in anneanne)
            {
                Console.WriteLine(S);


            } */
            //******************************************************************************************************************************

            /* string[] test = {  "zahid",  "zun",  "gay",  "lgbt",  "salih",  "salik",  "zahid",  "zun"  };

            int adet = 0;
            string A;

            Console.Write("Kelime salla be aga kafandan: ");
            A = Console.ReadLine();

            for (int i = 0; i < test.Length; i++)
            {
                if(A == test[i])
                {
                    adet++;
                }
            }

            if(adet == 0)
            {
                Console.WriteLine("KEKW");
            }

            else if(adet != 0)
            {
                Console.WriteLine("Kelimen string listesinde bulundu hll koçuma!");
                Console.WriteLine("Kelimen listede " + adet + " kere bulunmuş.");

            } */


          /*  int[] ontane = new int[10];

            byte tekadet = 0;
            byte çiftadet = 0;

            long tektoplam = 0;
            long çifttoplam = 0;

            for (int i = 0; i < ontane.Length; i++)
            {
                Console.Write((i+1) + (". değeri gir: "));
                ontane[i] = int.Parse(Console.ReadLine());


            }

            for (int j = 0; j < ontane.Length; j++)
            {
                if(ontane[j] % 2 == 0)
                {
                    çiftadet++;
                    çifttoplam = ontane[j] + çifttoplam;
                }

                else
                {
                    tekadet++;
                    tektoplam = ontane[j] + tektoplam;

                }
            }

            if(çifttoplam > tektoplam)
            {
                Console.WriteLine("Çift sayılar kazandı yeahhhh motherfucker!");

            }

            else if(tektoplam > çifttoplam)
            {
                Console.WriteLine("Tek sayılar kazandı yeahhhh motherfucker!");


            }

            Console.WriteLine(tekadet + " adet tek sayı yazdın.");
            Console.WriteLine(çiftadet + " adet çift sayı yazdın.");

            Console.ReadLine();  */
        }
    }
}
