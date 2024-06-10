using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    internal class ARAYUZ
    {
        public void RunAY()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("fiboncci sayisinin derinin ortalamasini hesaplamak icin sayi giriniz: ");
              int girilen = int.Parse(Console.ReadLine());

            if (girilen < 0)
            {
                Console.WriteLine("0 dan kucuk deger GIREMEZSINIZ!!\n tekrar sayi giriniz ");
                girilen = int.Parse(Console.ReadLine());
            }
            else if (girilen > 0) 
            {
                Console.WriteLine("girdiginiz sayi : "+girilen+ " 0 ile "+girilen + "fibonnicci sayıları : ");
                FibonnciHesaplayici fb=new FibonnciHesaplayici();
                fb.sayi = girilen;
                
                var listem= fb.Calculate(fb.sayi);

                Console.WriteLine("fibonnicilerini hesaplattığınız sayıların toplamının ortalaması ");
                Ortalama ort = new Ortalama();
                ort.Hesapla(listem);
            }
        }
    }
}
