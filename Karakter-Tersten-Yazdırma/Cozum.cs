using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Tersten_Yazdırma
{
    internal class Cozum
    {
        static string StringiTersineCevir(string metin)
        {
            char[] charArray = metin.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static string ArrayListToString(ArrayList list)
        {
            // ArrayList'i string dizisine dönüştürme
            string[] array = (string[])list.ToArray(typeof(string));
            // String ifadeleri boşluk ile birleştirme
            return string.Join(" ", array);
        }
        public  string[] Run(string cumle)
        {
            // Cümleyi boşluk karakterine göre ayır
            string[] kelimeler = cumle.Split(' ');

           ArrayList ters = new ArrayList();

            for(int i = 0;i<kelimeler.Length;i++)
            {
                ters.Add(StringiTersineCevir(kelimeler[i]));
                
            }
            string tersCumle = ArrayListToString(ters);

            Console.WriteLine("ilk cumle: " + cumle);
            Console.WriteLine("ters cumle: " + tersCumle);

            return kelimeler;
        }
    }
}
