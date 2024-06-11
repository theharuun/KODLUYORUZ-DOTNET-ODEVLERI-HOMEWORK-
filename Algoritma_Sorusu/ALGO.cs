using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Sorusu
{
    internal class ALGO
    {
        class algoritma
        {
            private string str;
            private int integer;
            public string Str
            {
                get { return str; }
                set
                {
                    if (value != "")
                    {
                        str = value;
                    }
                }
            }
            public int Integer
            {
                get { return integer; }
                set
                {
                    if (value > 0)
                        integer = value;
                }
            }


            public void algoritmaCoz(string s, int y)
            {
                ArrayList arrayList = new ArrayList();
                Console.Write("ALGORITMA CEVABIN : ");
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == s[y])
                    {
                        continue;
                    }
                   
                    Console.Write(s[i]);
                }

                Console.WriteLine(); Console.WriteLine();
            }
        }
        public void RUN()
        {


            algoritma alg = new algoritma();
            Console.Write("Bir string ifade giriniz : ");
            alg.Str = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Girdiginiz ifadeden hangi index kalkmasini istiyorsanız o index giriniz : ");
            alg.Integer =int.Parse(Console.ReadLine());
            alg.algoritmaCoz(alg.Str, alg.Integer);

        }
    }
}
