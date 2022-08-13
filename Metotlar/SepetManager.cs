using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product ürün)
        {
            Console.WriteLine("Sepete Eklendi"+ "   "+ ürün.Adi + ürün.Fiyat + ürün.Aciklama);
        }
    }
}
