using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Orta_Seviye__Mutlka_Kare_Alma
{
    internal class ARAYUZ
    {
        public void RUN()
        {
            Console.Write("KAÇ ADET SAYI GİRMEK İSTERSİNİZ : ");
            int SayiAdet=int.Parse(Console.ReadLine());

            int[] Sayilar=new int[SayiAdet];

              for (int i = 0; i < Sayilar.Length; i++) // her sayiyi sirayla istedik
                {
                    Console.Write(i + 1 + ".SAYI: ");
                    Sayilar[i] = int.Parse(Console.ReadLine()); Console.WriteLine();
                    
            }

            MUTLAK MT=new MUTLAK();
            MT.run(Sayilar);
            
        }
    }
}
