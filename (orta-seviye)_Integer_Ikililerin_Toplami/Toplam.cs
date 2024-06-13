using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Integer_Ikililerin_Toplami
{
    internal class Toplam
    {
        public void Run(ArrayList arrayToplam, int[] sayi)
        {
            for (int i = 0; i < sayi.Length; i++) // her sayiyi sirayla istedik
            {
                Console.Write(i + 1 + ".SAYI: ");
                sayi[i] = int.Parse(Console.ReadLine()); Console.WriteLine();
            }

            for (int i = 0; i < sayi.Length; i = i + 2)//her ikili cifti topladik ve eger aynı olan varsa onun karesini aldik ve arraylistine ekledik
            {
                int toplam = sayi[i] + sayi[i + 1];
                if (arrayToplam.Contains(toplam))
                {
                    toplam *= toplam;
                    arrayToplam.Add(toplam);
                }
                else
                {
                    arrayToplam.Add(toplam);
                }

            }
            foreach (int i in arrayToplam) { Console.Write(i + " - "); }
        }

    }
}
