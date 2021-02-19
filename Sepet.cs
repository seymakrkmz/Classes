using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Sepet
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi:" + urun.Adi);
        }
        public void Ekle2(string urunAdi, int fiyati)
        {
            Console.WriteLine("tebrikler"+ urunAdi);
        }

    } 
}
