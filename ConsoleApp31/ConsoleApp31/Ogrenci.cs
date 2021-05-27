using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Ogrenci
    {

        private int Öğrencino;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okul;

        public Ogrenci(int _Öğrencino , string _isim , string _soyisim , int _vize1 , int _vize2 , int _final , string _okul )
        {

            Öğrencino = _Öğrencino;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okul = _okul;

        }

        public void Bilgi()
        {

            Console.WriteLine("Öğrencinin okul numarası: " + Öğrencino);
            Console.WriteLine("Öğrencinin adı: " + isim + soyisim);
            Console.WriteLine("Öğrencinin okulu: " + okul);

        }

        public void Not()
        {
            Console.WriteLine("(Üniversite not sistemini bilmiyorum ağlamayın )Öğrencinin not ortalaması: " + ((vize1+vize2+final) / 3));
            Console.WriteLine("Öğrencinin 1. Vize Notu: " + vize1);
            Console.WriteLine("Öğrencinin 2. Vize Notu: " + vize2);
            Console.WriteLine("Öğrencinin Final Notu: " + final);

        }

        public void Okulöğren()
        {
            Console.WriteLine("Okulu: " + okul);

        }

    }
}
