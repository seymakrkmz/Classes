using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] {
            };
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 50;
            Product urun2 = new Product();
            urun2.Adi = "armut";
            urun2.Fiyati = 60;
            Product[] urunler = new Product[] { urun1, urun2 };
        foreach(var product in urunler)
            {
                Console.WriteLine(product.Adi + "" + product.Fiyati);

            }
            Console.WriteLine("--------methodlar----------");
            Sepet sepet = new Sepet();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.Ekle2("armut",50);





        }
    }
}
