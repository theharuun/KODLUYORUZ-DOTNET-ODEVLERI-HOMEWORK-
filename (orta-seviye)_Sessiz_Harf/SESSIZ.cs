using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Sessiz_Harf
{
    internal class SESSIZ
    {

        public void ciftSessiz(ArrayList kelimelistesi) 
        {
            char[] unluHarf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            foreach (string kelime in kelimelistesi)
            {
                bool donus = false;

                for (int j = 0; j < kelime.Length - 1; j++)
                {
                    char harf = kelime[j];
                    char sonrakiHarf = kelime[j + 1];

                    if (!IsUnluHarf(harf, unluHarf) && !IsUnluHarf(sonrakiHarf, unluHarf))
                    {
                        donus = true;
                        break;
                    }
                }

                Console.Write( (donus ? " True " : " False "));
            }
        }

        private static bool IsUnluHarf(char harf, char[] unluHarf)
        {
            foreach (char uh in unluHarf)
            {
                if (harf == uh)
                {
                    return true;
                }
            }
            return false;
        }
        public void Run(string cumle)
        {
            ArrayList kelimeListesi = new ArrayList();

            string[] kelime=cumle.Split(' ');

            foreach (string s in kelime) 
            {
                kelimeListesi.Add(s);
            }
            
            ciftSessiz(kelimeListesi);
        }
    }
}
