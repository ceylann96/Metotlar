using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> isimler = new List<String> {  "a", "b", "c" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("f");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
        }
    }
}
