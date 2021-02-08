using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" isimli müşteri eklendi");
        }
        public void Duzenle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isim soyisimli müşterinin hesabında düzenleme yapıldı", musteri.Adi, musteri.Soyadi);
        }

        public Musteri[] Listele()
        {
            Console.WriteLine("Musteriler listelendi.");

            // veri kaynağından müşterileri GetAll yada GetById ile sorgula

            return new Musteri[0];
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("...silindi.");
        }
    }
}
