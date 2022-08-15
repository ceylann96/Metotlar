using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 5;
            gercekMusteri.MusteriNo = "1516156";
            gercekMusteri.Adi = " Kadir";
            gercekMusteri.Soyadi = "Cweylan";
            gercekMusteri.TcNo = "105189911189";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 1599;
            tuzelMusteri.SirketAdi = "TT";
            tuzelMusteri.VergiNo = "105191";


            Müsteri musteri3 = new GercekMusteri();
            Müsteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);



        }
    }
}
