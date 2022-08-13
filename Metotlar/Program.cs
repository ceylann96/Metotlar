using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product ürün1 = new Product();
            ürün1.Adi = "Elma";
            ürün1.Fiyat = 15;
            ürün1.Aciklama = "Gel Elmaaayaaaaa gelll";

            Product ürün2 = new Product();
            ürün2.Adi = "Nar";
            ürün2.Fiyat = 25;
            ürün2.Aciklama = "Nar gibi naaarr";

            Product[] ürünler = new Product[] { ürün1, ürün2 };

            foreach (var urun in ürünler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("--------Methots----------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(ürün1);

            sepetmanager.Ekle(ürün2);

           






        }
    }
}
