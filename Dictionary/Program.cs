using System;
using System.Collections.Generic; 


namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> il= new Dictionary<int, string>();
            il.Add(34, "İstanbul");
            il.Add(06, "Ankara");
            il.Add(40, "Kırşehir");
            il.Add(29, "Gümüşhane");
            il.Add(71, "Kırıkkale");
            Console.Write("Plaka numarasını giriniz. ");
            int plaka = int.Parse(Console.ReadLine());
            Console.Write(il[plaka]);
            Console.Read(); 
        }
    }
}