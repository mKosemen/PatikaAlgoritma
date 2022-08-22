using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string veri, metin;
            byte sayi;
            Console.WriteLine("Lütfen içerisinde metin ile sayının virgül ile ayrıldığı bir ifade giriniz.");
            veri = Console.ReadLine();
            if (veri.Contains(","))
            {
                sayi = Convert.ToByte(veri.Substring(veri.IndexOf(',') + 1));

                metin = veri.Remove(veri.IndexOf(','));
                if (metin.Length > sayi)
                    Console.WriteLine(metin.Remove(sayi, 1));
                else
                    Console.WriteLine("Metin uzunluğu sayısal değeri kapsamamaktadır.");
            }
            else
                Console.WriteLine("Lütfen Formata uygun veri giriniz.");

            Console.ReadLine();
        }
    }
}
