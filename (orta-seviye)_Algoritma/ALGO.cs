using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Algoritma
{
    internal class ALGO
    {
       
        static string String_I_S_yerdegistirme(ArrayList list)
        {
            ArrayList hedefCumle = new ArrayList();
            foreach (string item in list)
            {
                if (item.Length > 3)
                {
                    item.Replace(item[0], item[item.Length - 1]);
                    char ilkHarf = item[0];
                    char sonHarf = item[item.Length - 1];
                    string ortadakiHarfler = item.Substring(1, item.Length - 2);
                    string result = sonHarf + ortadakiHarfler + ilkHarf;
                    hedefCumle.Add(result);
                }
                else
                {
                    hedefCumle.Add (item);
                }
            }
            foreach (var item in hedefCumle)
            {
                Console.Write(item + " ");
            }
            return "s";
        }
        static string ArrayListToString(ArrayList list)
        {
            // ArrayList'i string dizisine dönüştürme
            string[] array = (string[])list.ToArray(typeof(string));
            // String ifadeleri boşluk ile birleştirme
            return string.Join(" ", array);
        }
        public string[] Run(string cumle)
        {
           
            ArrayList kelimeListesi = new ArrayList();
 
            // Cümleyi boşluk karakterine göre ayır
            string[] kelimeler = cumle.Split(' ');
            // kelimeleri listeye ekledik

            foreach (string kelime in kelimeler)
            {
                kelimeListesi.Add(kelime);
            }


            String_I_S_yerdegistirme(kelimeListesi);


            return kelimeler;
        }
    }
}
