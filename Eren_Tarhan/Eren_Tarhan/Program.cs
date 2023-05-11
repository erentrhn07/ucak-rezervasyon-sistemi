using System;
using System.Threading;

namespace Eren_Tarhan 
{
    internal class Program 
    {
      static void Main(string[] args) 
        {
            Console.Title = "Uçak Rezervasyon Sistemi";

            Console.WriteLine("Uçak Rezervasyon Sistemine Hoşgeldiniz.\n");

            MusteriOlusturma musteriOLusturma = new MusteriOlusturma();
            Musteri musteri = musteriOLusturma.musteri();

            UcusOlusturma ucusOlusturma = new UcusOlusturma(musteri.Ad, musteri.Soyad);
            Console.Write(ucusOlusturma.UcusDondur());

            Console.Write("\n\n İyi Yolculuklar.");

            Thread.Sleep(1000);
        }
    }
}