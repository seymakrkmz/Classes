using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Şeyma Korkmaz";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Ali Korkmaz";
            kurs2.IzlenmeOrani = 58;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Ayşe Korkmaz";
            kurs3.IzlenmeOrani = 23;
            // Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " "+ kurs.Egitmen);
            }
           
            for (int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi);
            }
            int x = 0;
            while(x<kurslar.Length){
                Console.WriteLine(kurslar[x].KursAdi + " " + kurslar[x].Egitmen);
                x++;

            }
        }
    }
    class Kurs {
        public string KursAdi {get;set;}
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
