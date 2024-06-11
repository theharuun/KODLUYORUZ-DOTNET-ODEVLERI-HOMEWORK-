using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucgen_Cizme
{
    internal class ARAYUZ
    {
        private int yukseklik;
        public int Yukseklik {
            get { return yukseklik; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("0 veya 0'dan kucuk deger giremezsiniz");
                }
                else
                {
                    yukseklik = value;
                }
            }
        }
        private int taban;
        public int Taban
        {
            get { return taban; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("0 veya 0'dan kucuk deger giremezsiniz");
                    
                }
                else
                {
                    taban = value;
                }
            }
        }

        public ARAYUZ() 
        {
          

        }

        public string Run() 
        {



            
            Console.Write("Ücgenin taban uzunlugunu girin: ");
            Taban = int.Parse(Console.ReadLine());

            Console.Write("Ücgenin yüksekligini girin: ");
            Yukseklik = int.Parse(Console.ReadLine());

            // Üçgeni çizme
            for (int i = 1; i <= yukseklik; i++)
            {
                // Yıldızları çizme
                int starCount = (i * taban) / yukseklik;
                for (int j = 0; j <= starCount; j++)
                {
                    Console.Write("*");
                }
                // Yeni satıra geçme
                Console.WriteLine();
            }

            string a = "adana";

            return a;
        }
        
    }
}
