using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Goster(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + "Faiz oranınız: " + musteri.FaizOranı);
        }
    }
}
