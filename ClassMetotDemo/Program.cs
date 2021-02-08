using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Onur";
            musteri1.Soyadi = "Soyadi";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);

            musteriManager.Duzenle(musteri1);

            musteriManager.Listele();

            musteriManager.Sil(musteri1);
        }
    }
}
