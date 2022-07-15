using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Ekleniyor");
            Console.WriteLine("Musteri Eklendi!!!!!");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Siliniyor");
            Console.WriteLine("Musteri Silindi!!!!!");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Musteriler Listeleniyor");
            Console.WriteLine("Musteriler Listelendi!!!!!");
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Musteri Guncelleniyor");
            Console.WriteLine("Musteri Guncellendi!!!!!");
        }
    }
}
