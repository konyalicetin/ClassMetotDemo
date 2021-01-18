using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0001;
            musteri1.Ad = "Fatih";
            musteri1.Soyad = "Çolak";
            musteri1.FaizOranı = 9;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 0002;
            musteri2.Ad = "Kerime";
            musteri2.Soyad = "Sayar";
            musteri2.FaizOranı = 11;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0003;
            musteri3.Ad = "Zafer";
            musteri3.Soyad = "Kara";
            musteri3.FaizOranı = 12;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine("Faiz oranınız: " + musteri.FaizOranı);
                Console.WriteLine("-----------------");
            }
        }
    }
}
