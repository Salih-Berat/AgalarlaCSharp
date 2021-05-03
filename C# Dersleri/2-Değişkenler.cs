using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "Mehmetpekince"; /* Değişken oluştururken değiken ismi sayıyla başlamaz ve karakterer arası boşluk olmaz olursa hata alırsın.
                                                * Türkçe karakter kullanılmamalıdır ç,ö,ü,ğ gibi vb. */


            /* -------------------------------------------------------------- BYTE VERİ TİPİ --------------------------------------------------------------------------------- */
            byte birinci = 255;
            byte ZUN = 9;
            byte Kalitrik = 31;
            // byte ikinci = 256;  256 sayısını byte fonksiyonunun içine koyduğumuzda hata vecektir. Because : byte içine en fazla 0-255 sayısına kadar depolayabilir.

            byte maxdeger = byte.MaxValue; // MaxValue yazdığım zn bana byte değişkeninin alabileceği en büyük değeri söyleyecektir.
            byte mindeger = byte.MinValue; // MinValue yazdığımdaysa bana en küçük değerini vercektir.


            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.WriteLine(birinci);
            Console.WriteLine(sayi);


            /*  ---------------------------------------------------------------SHORT VERİ TİPİ------------------------------------------------------------------------------ */


            // SHORT veri tipi -32768 to 32768 sayısına kadar içinde depoluyor 

            short birinciDegisken = -1500; // sort veri tipi içinde eksili sayıları tutabilir byte da tutlmaz.
            short KatilRik = 3169;
            short maxshortDegisken = short.MaxValue; // aynı byte daki gibi büyük değerini görmüş olacağız.
            short minShort = short.MinValue; // aynı byte daki gibi en küşük değeri görmüş olcağız.
            short MrUpsidedown = -9000;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(maxshortDegisken);
            Console.WriteLine(minShort);

            /* ----------------------------------------------------------------- İNT VERİ TİPİ ---------------------------------------------------------------------------------*/

            int birinciİnt = 150;   // İnt veri tipinde -2.147.483.648 to 2.147.483.648 değerlerini alabilir byte a ve shorta göre kat ve kat çoktur.
            int maximDeger = int.MaxValue; // diğer veri tipleriyle aynı mantıkta çalışır diğerleri gibi buda en büyük değeri yazdırır yani 2.147.483.648 değerini yazdırcaktır.
            int minimDeger = int.MinValue; // buda int değerinin en küçük değerini yazdırcaktır yani -2.147.483.648 değerini vercektir bize.
            int kaboom = 316954584;
            int PhilippusAureolus = 1251895648;

            Console.WriteLine(birinciİnt);
            Console.WriteLine(maximDeger);
            Console.WriteLine(minimDeger);
            Console.WriteLine(kaboom);

            /*------------------------------------------------------------------LONG VERİ TİPİ----------------------------------------------------------------------------------*/

            // 8 byte yer kaplamaktadır rambellekte.

            long DegiskenLong = 1453;  // long veri tipi -9.223.372.036.854.775.808 to 9.223.372.036.854.775.808 arasında değer depolayabilmektedir.
            long maxDegerLong = long.MaxValue;
            long minDegerLong = long.MinValue;
            long kalitkatil = 2812893187;

            Console.WriteLine(DegiskenLong);  // burada alcağımız çıktı Degiskenlong olacaktır.
            Console.WriteLine(maxDegerLong);  // burada alcağımız çıktı maxDegerLong olcaktır.
            Console.WriteLine(minDegerLong);  // burada alacağımız çıktı minDegerLong olacaktır.
            Console.WriteLine(kalitkatil);


            /*--------------------------------------------------------------------FLOAT VERİ TİPİ ------------------------------------------------------------------------------*/


            // FLOAT VERİ TİPİ 4 BYTE YER KAPLAMATADIR RAMBELLEKTE.
            // Float değerinin içine ondalıklı sayılar depolanır.


            float DegerOndalik = 45.7f;   /* ondalık sayımızı atadıktan sonra yanına f yazmalıyız.*/
            float kaka = 31.69f;          /* nedeni ise yazdığımız değerin ondalık değer yani float olduğunu anlaması içinyazıyoruz
                                          * eğer yamazsak bize hata vercektir nedeni ise  onu double sanmasıdır.
                                          * en fazla 7 basamak sayı tutabilir içinde*/
            Console.WriteLine(DegerOndalik);
            Console.WriteLine(kaka);


            /*---------------------------------------------------------------------DOUBLE VERİ TİPİ -----------------------------------------------------------------------------*/


            // 8 BYTE yer kaplar Rambellekte.
            // double veri tipi içinde ondalıklı sayıları tutar floatdan farkı ise 15 basamak değere kadar içinde değerleri tutmasıdır.

            double DegerDouble = 12.5673854;  // gördüğünüz gibi 7 den fazla değeri içinde tutabiliyor
            double pilav = 13.693113;
            double lale = double.MaxValue;
            double bebedouble = double.MinValue;

            Console.WriteLine(DegerDouble);
            Console.WriteLine(pilav);
            Console.WriteLine(lale);
            Console.WriteLine(bebedouble);

            /*---------------------------------------------------------------------CHAR VERİ TİPİ -------------------------------------------------------------------------------*/

            // Sadece karakterlei içinde tutmak için kullanılan veri tipine "Char" veri tipi denir
            // tek tırnak içine tek değer olarak yazılır.

            char DegerChar = 'M'; //gördüğünüz gibi tek tırnak içinde tek değer yazdık.
            char DegerChar2 = 'Z'; // Her zaman tek tırnak kullanmalıyız char veri tipinde çift tırnak kullanırsak hata alırız
            char bos = ' ';
            char zunundeger3u = 'A';

            Console.WriteLine(zunundeger3u);
            Console.WriteLine(bos);
            Console.WriteLine(DegerChar);
            Console.WriteLine(DegerChar2);

            /*---------------------------------------------------------------------STRİNG VERİ TİPİ-----------------------------------------------------------------------------*/

            // String girilen 8 byte+girilen karakter kadar rambellekte yer kaplar

            string DegerStr = "Mehmet"; // tek tırnakla yazılmaz yazılırsa hata alırsınız çift tırnakla yazılması gerekir.
            string DegerStr2 = "Pekince";
            string kalininmetni = "Kali ";
            string salihinki = "Adamdır.";
            


            Console.WriteLine(DegerStr + DegerStr2);
            Console.WriteLine(kalininmetni + salihinki);
            // örnektede gördüğünüz gibi araya "+" işareti koyduğumuz zaman bize iki sonucu bireştirip yazcaktır

            /*---------------------------------------------------------------------- BOOL VERİ TİPİ -----------------------------------------------------------------------------*/

            // Bool veri tipinde sadece iki tane veri saklanır bunlar "True ve False" dır.

            bool Bak = true;  // doğru demektir
            bool Bak2 = false; // yanlış demektir 

            // peki nasıl kulanılır.

            bool cikti = 50 < 25;   // 50 küçüktür 25 demş olduk bunun doğru veya yanlış olduğunu bize çıktısını vercektir
            bool boolumuz = 8283743267823489 < 3264237467423673432;

            Console.WriteLine(boolumuz);

            Console.WriteLine(cikti);  // burada bana false çıktısını vercek çünkü 50 25 den küçük değildir.

            /*----------------------------------------------------------------------- OBJECT VERİ TİBİ -----------------------------------------------------------------------------*/

            // Tüm veri tiplerinin babasıdır içinde tüm veri tipleri saklanabilir 
            // örneğin 

            object Degerbaba = true;
            object Degerbaba2 = "salih";
            object Degerbaba3 = 350;
            object Degerbaba4 = 3.15;

            Console.WriteLine(Degerbaba);
            Console.WriteLine(Degerbaba2);
            Console.WriteLine(Degerbaba3);
            Console.WriteLine(Degerbaba4);
            Console.ReadLine();

            // gördüğünüz gibi tüm değişkenleri alabilr 

            /*------------------------------------------------------------------------- VERİ TİPLERİ BUKADAR :) -----------------------------------------------------------------------*/
            // eğer kendi bilgisayarınızda çalıştırıp denemek isterseniz her vri tipini tek tek denemenizi tavsi ediyorum karışıklık olmasın çıktılarda
        }

    }
}
