using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------------------------------------------------------OPERATÖRLER----------------------------------------------------------------------------------*/

            // ------------------------------------------------------------Aritmatik operatörleri:

            // --------------------------Toplama Operatörü: +  ------------------------------
            // --------------------------Çıkarma Operatörü: -  ------------------------------

            byte sayi1 = 149;
            int sayi2 = 359;

            byte KaliAbinDeger1i = 31;
            byte KaliAbinDeger2si = 69;

            byte sayi3 = 97;
            short sayi4 = 432;

            Console.WriteLine(sayi1 + sayi2);  // burda bizim için sayi1 ve sayi2 olarak atadığımız sayıları bizim için topladı.
            Console.WriteLine(sayi1 - sayi2);  // burda bizim için sayi1 den sayi2 yi çıkarttı ve ekrana yazdırdı.

            int toplamlari = sayi3 + sayi4;
            int KaliAbinToplamasi = KaliAbinDeger1i + KaliAbinDeger2si;
            int sonuc = sayi1 + sayi2;
            int cikartmaSonuc = sayi1 - sayi2;
            int ToplaCikar = (sayi2 + sayi1) - sayi1;

            Console.WriteLine(KaliAbinToplamasi);
            Console.WriteLine(toplamlari);
            Console.WriteLine(sonuc);            // yukardakiyle aynı cevabı vercek bize vercektir sadece farklı yöntem olsun diye yazdım.
            Console.WriteLine(cikartmaSonuc);   // buda çıkartmanın aynısı.
            Console.WriteLine(ToplaCikar);     // burda  sayi bie ve ikiyi topladıktan sonra sayi1 değerini tekrar çıkardı.




            // -------------------------Çarpma Operatör: *  -----------------------------------
            // -------------------------Bölme Operatörü: / ------------------------------------


            byte sayiB = 50;
            byte sayiB2 = 25;

            byte sayiBe = 132;
            byte Sayi2Be = 234;


            byte sayiA = 113;
            byte sayiA2 = 251;

            int SayiyicarpBe = sayiBe * Sayi2Be;
            int charpbunlariadamihastaetme = sayiA * sayiA2;
            int sonucBol = sayiB / sayiB2;               // burda sayiB yi sayiB2 ye böldük.
            int sonuccarp = sayiB2 * sayiB;
            // burda da sayiB'yle sayiB2 yi çarptık.

            Console.WriteLine("BU UZUNUN TAMAM MI" + charpbunlariadamihastaetme);
            Console.WriteLine("BU SALİHİN ELLEME DOVER" + SayiyicarpBe);
            Console.WriteLine(sonucBol);          // burda da sonuçları ekrana yazdırdık.
            Console.WriteLine(sonuccarp);

            // ---------------------------Mod Alma Operatörü: % ----------------------------------

            byte sayiMod = 17;
            byte sayiMod2 = 9;

            short ShakShak = 23472;
            byte ShakKirar = 132;


            byte slapslap = 21;
            short ShakShakie = 27892;

            int Shakira = slapslap % ShakShakie;
            int ShakShakChi = ShakShak % ShakKirar;
            Console.WriteLine("BU UZUNUN ONA GÖRE KRALINI TTEN " + Shakira);
            Console.WriteLine("BU SALİHİN ELLEYENİ DÖVER " + ShakShakChi);
            Console.WriteLine(sayiMod % sayiMod2); // burda 14 sayısını 3 e böldük ve kalanı ekrana yazdırmış olduk. sonuç 2 olcaktır.


            //----------------------------- Arttırma Operatörü:++ -----------------------------------
            //----------------------------- Azaltma Operatörü : --   --------------------------------


            byte sayimiz = 150;                  // burda sayimiz değişkeninin içine 150 sayısını ekledik yani sayimiz = 150 şuan
            byte ZUNsayisi = 137;
            byte Salihin = 253;

            sayimiz++;                         // burda sayimiz değerine 1 ekledik yani sayimiz değeri bundan sonra 151 oldu 
            Console.WriteLine(sayimiz);   // burda sayimiz değerini yazdırdık yani en son yaptığımız 151 değeri ekrana yazıldı

            Salihin++;
            Console.WriteLine(Salihin);

            ZUNsayisi++;
            Console.WriteLine(ZUNsayisi);

            sayimiz--;                       // burda en son eklediğimiz 1 değeri tekrar çıkardık yani "--" eksi eksi yaptığımızda yani 1 çıkarcak.
            Console.WriteLine(sayimiz); // burda 150 sayısını ekrana yazdırcak çünkü en son sayimiz değerinden 1 çıkardık 151 yapmıştık tekrar 1 çıkardığımızda 150 sayısını elde ettik

            Salihin--;
            Console.WriteLine("salih abin bu" + Salihin);

            ZUNsayisi--;
            Console.WriteLine(ZUNsayisi);


            // ------------------------------ Atama Operatörü: = ----------------------------------------

            byte sayiATa = 25; // burda sayiATa değişkeninin içine 25 değerini atamış olduk 

            Console.WriteLine(sayiATa);

            short otuzbircisayi = 3131;
            Console.WriteLine(otuzbircisayi);

            short salihaltmishikide = 6262;
            Console.WriteLine(salihaltmishikide);




            // ---------------------------------------------------------------------KARŞILAŞTIRMA OPERATÖRLERİ------------------------------------------------------------------------------------



            // -----------------------------------------------Büyüktür Operatörü : > 
            // -----------------------------------------------Küçüktür Operatörü : <



            bool Kontrol = 50 > 25;                 // burda 50 25 den büyükmüdür onu kontrol etti ve bize true yani doğru olduğunu yazdırcaktır. 

            bool shakshakbuyukmudur = 3123123132222221 > 1231213212313123123;

            bool uzun = 9999999999999999999 > 1;

            Console.WriteLine("Evet " + shakshakbuyukmudur);

            Console.WriteLine(Kontrol);       // Kontrol değerini ekrana yazdırcak

            Console.WriteLine(uzun);

            bool Kontrol2 = 25 < 50;         // 25 in 50 den küçük olup olmadığını sormuş olduk eğer 25 50 den küçükse bize true değerini yazdırcaktır.

            bool uzun1 = 31136226 < 692;

            bool Shakshakkuchukmudur = 12131 < 3221321123;

            Console.WriteLine("hayır " + Shakshakkuchukmudur);

            Console.WriteLine(Kontrol2);  // Kontrol2 de 25 50 den küçük olduğu için bize true ifadesini vercektir.

            Console.WriteLine(uzun1);


            // ---------------------------------------------Eşittir Operatörü : == 
            // --------------------------------------------Eşit değildir(farklı) Operatörü : != 


            byte sayiEsit = 25;
            byte sayiEsitmi = 25;  // buralarda herzamanıki gibi sayılarımızı tanımladık

            bool control = sayiEsit == sayiEsitmi;   // burada tanımladığımız değişkenlerin birbirine eşit olduğunu söyledik ve kontrol edip bize cevap olarak true veya false diycek

            Console.WriteLine(control);         // iki değişken birbirine eşit olduğu için  True değerini alcaz

            byte shorty = 69;
            byte bit = 69;

            bool bitTesti = shorty == bit;

            Console.WriteLine(bitTesti + " Salih Adam BİLİYO BU İŞİ BEEA");

            byte byty = 31;
            short Shorty = 3331;

            bool uzunluktesti = byty == Shorty;

            Console.WriteLine(uzunluktesti);



            byte sayim = 54;
            byte sayimiz2 = 54;                     //burda değişkenlerimize değerlerini verdik.

            bool cozumumuz = sayim != sayimiz2;   // iki değişkenin eşit olmadığını söyledik ve bize kontrol edip true veya false değerlerini vercek

            Console.WriteLine(cozumumuz);  // bize false değerini göstercek çünkü iki değer eşitti ama biz ona eşit olmadığını söylemiştik bizim dediğimiz yanlış olduğu için false değerini alcaz

            byte mybad = 47;
            byte yourbadfoolish = 47;

            bool sucuk = mybad != yourbadfoolish;

            Console.WriteLine(sucuk);

            byte bagsuriye = 31;
            byte yourbed = 69;

            bool baghsur = bagsuriye != yourbed;
            Console.WriteLine(baghsur + " SALİH ADAM BU EŞİTSİZLİĞİ DE ÇÖZDÜ HADİ BAKİİİİİM!");
            Console.WriteLine("bagsur salih");


            // ----------------------------------------------Büyük eşit Operatörü: >=
            // ----------------------------------------------Küçük eşit Operatörü: <= 

            byte BuyukEsit = 150;
            byte BuyukEsit2 = 168;                // Değişkenlerin içine atadık


            bool anla = BuyukEsit >= BuyukEsit2;            // değişkenin büyük veya eşitmi olduğuna baktırdık eğer büyük veya eşitse bize true çıktısını vercektir.

            Console.WriteLine("büyük veya eşitmidir ?" + anla);   // burda False değerini aldık çünü hem eşit değil hemde buyukesit  değeri diğer değişkenden büyük değil.

            byte KucukEsit = 125;
            byte KucukEsit2 = 126;           // değerlerimizi değişkenlerin içine koyduk .

            bool kucukAnla = KucukEsit <= KucukEsit2;     // kucukesit değişkeni kucukesit2 değişkeninden küçük veya eşitse bize true değerini vercektir.

            Console.WriteLine("küçük veya eşitmidir ?  " + kucukAnla);     // burda true değerini aldık çünki kucukesit değişkeni kucukesit2 değişkeninden küçük.



            //------------------------------------------------------------------------------MANTIKSAL OPERATÖRLER--------------------------------------------------------------------------
            //Long birincidegisken = 456000;

            //long ikincidegisken = -500;

            //long MaxDeger = MaxVolue;

            //long MinDeger = MinVolue;

            //Console.WriteLine(birinciDegisken);
            //Console.WriteLine(ikinciDegisken);
            //Consoole.WriteLine(MaxDeger);
            //Console.WriteLine(MinDeger);

            //Console.ReadLine();
            //------------------------------------------------- VE Operatörü: && 

            // bir tane bile false varsa sonuç false dır


            byte opve1 = 25;
            byte opve2 = 36;
            byte opve3 = 46;      // değerlerimizi değişkenlerin içine atadık.

            bool VEopersonuc = opve1 <= opve2 && opve2 < opve3;  // burda opve1 küçük veya eşitmi opve2 ye dedik ordan true çıktısını aldık sonra kodlar devam etmesi için ve kullandık orda da 

            Console.WriteLine(VEopersonuc); // burda True değerini alcaz çünü T ve T oldu yukarda. aynı lisedeki mantık konusu gibi                                                  * opve2 küçükmüdür opve3 den dedik burdaki sonuçda true olcak. sonuç olarak da biri true diğeride true olduğu için bize True çıksını vercek*/


            byte Salihve1 = 131;
            byte Salihve2 = 169;
            byte Salihve3 = 31;

            bool SalihinSonucu = Salihve1 < Salihve2 && Salihve2 >= Salihve3;

            Console.WriteLine(SalihinSonucu + " Salih adam ve operütörünü de çözdü yehh madafaka!");


            byte uzunve1 = 172;
            byte uzunve2 = 196;
            byte uzunve3 = 100;

            bool uzununsonucu = uzunve1 <= uzunve2 && uzunve2 >= uzunve3;

            Console.WriteLine(uzununsonucu + " Uzun bu kaltağı beceriyo be ");




            // ------------------------------------------------- Veya operatörü : || 

            // bir tane bile true varsa sonuç true dur.

            byte opveya1 = 5;
            byte opveya2 = 5;
            byte opveya3 = 10;               // değişkenleri atadık

            bool ciktimiz = opveya1 == opveya2 || opveya2 > opveya3;  // veya işaretinden önceki yaptığımız eşittirde alcağımız sonuç True olcak veya işaretinden sonraki yerse False olcak çünkü opve2 büyük değildir opve3 den.

            Console.WriteLine(ciktimiz);                  // burda çıktıyız alacağız alcağımız çıktı True olcak çünü en az bir true kuralına uygun.

            byte shakbam1 = 31;
            byte shakbam2 = 69;
            byte shakbam3 = 100;

            bool shakbam = shakbam1 == shakbam2 || shakbam2 < shakbam3;

            Console.WriteLine(shakbam + " Salih bu işi de becerdi ya adamın erkek suyu ya");

            byte domdomkurshunu1 = 11;
            byte domdomkurshunu2 = 22;
            byte domdomkurshunu3 = 33;

            bool domdomkurshunu = domdomkurshunu1 == domdomkurshunu2 || domdomkurshunu2 < domdomkurshunu3;

            Console.WriteLine(domdomkurshunu);



            //-------------------------------------------------Değil Operatörrü : ! 

            // yazdığımız bir değişkenin değilini alır yanı tersini yapar.

            bool Hello = true;

            Console.WriteLine(Hello);   // burda biz true değerini alcaz
            Console.WriteLine(!Hello); // ama burda False alcaz çünü başına Değil işareti ekledik.

            bool agamagabuga = true;

            Console.WriteLine(agamagabuga + " SALİH BİLİYO SU İŞİ BEBEEBEBE");
            Console.WriteLine(!agamagabuga);

            bool jahreininmuzlari = false;

            Console.WriteLine(jahreininmuzlari);
            Console.WriteLine(!jahreininmuzlari);

            Console.ReadLine();




            /* ----------------------------------------------------------------------------------OPERATÖR DERSLERİ BİTTİ --------------------------------------------------------------------------------------*/


        }
    }
}
