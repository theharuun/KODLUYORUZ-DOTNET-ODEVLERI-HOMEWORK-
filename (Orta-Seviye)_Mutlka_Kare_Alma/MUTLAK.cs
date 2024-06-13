using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Orta_Seviye__Mutlka_Kare_Alma
{
    internal class MUTLAK
    {
        int toplam = 0;
        int mutlak = 0;
        public void run(int[] Sayilar)
        {
            for(int i = 0; i < Sayilar.Length; i++)
            {
                if(Sayilar[i] < 67)
                {
                    toplam+=67-Sayilar[i];
                }
                else if(Sayilar[i] >67)
                {
                    int kare= (Sayilar[i] - 67) * (Sayilar[i]-67);
                    mutlak += kare;
                }
            }
            Console.WriteLine("TOPLAM : "+toplam+" -  MUTLAK: "+mutlak);
        } 

        
    }
}
