using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriAd = "Kerem";
            musteri1.MusteriSoyad = "Kaplan";
            musteri1.MusteriTC = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAd = "Haydar";
            musteri2.MusteriSoyad = "Dümen";
            musteri2.MusteriTC = "22222222222";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 3;
            musteri3.MusteriAd = "Fatih";
            musteri3.MusteriSoyad = "Terim";
            musteri3.MusteriTC = "33333333333";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriID = 4;
            musteri4.MusteriAd = "Ahmet";
            musteri4.MusteriSoyad = "Mehmet";
            musteri4.MusteriTC = "44444444444";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri ID : " + musteri.MusteriID);
                Console.WriteLine("Musteri Adı : " + musteri.MusteriAd);
                Console.WriteLine("Musteri SoyAdı : " + musteri.MusteriSoyad);
                Console.WriteLine("Musteri Tc : " + musteri.MusteriTC);
                Console.WriteLine("###############");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("--------------------------");
            musteriManager.MusteriGuncelle(musteri2);
            Console.WriteLine("--------------------------");
            musteriManager.MusteriListele(musteri3);
            Console.WriteLine("--------------------------");
            musteriManager.MusteriSil(musteri4);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("İŞLEMLER TAMAMLANDI. TEBRİKLER!!!!!");
        }
    }
}
