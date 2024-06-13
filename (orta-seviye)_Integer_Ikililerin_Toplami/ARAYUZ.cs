using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Integer_Ikililerin_Toplami
{
    internal class ARAYUZ
    {
        public void RUN()
        {
            Console.WriteLine("***********HOSGELDINIZ************\nkaç çift sayi giriceksiniz  \nOrnegin 6 cift giricegim yazarsaniz 12 sayi isteyecegiz sizden");
            int SayiAdet = int.Parse(Console.ReadLine());
            if (SayiAdet % 2 != 0)
            {
                Console.Write("Cift Sayi Girmelisiniz : ");
                SayiAdet = int.Parse(Console.ReadLine());
            }
            // kaç adet çift sayı gireceğini aldık önce
            Console.WriteLine(SayiAdet * 2 + " tane sayi yazicaksiniz :)) ");

            ArrayList arrayToplam = new ArrayList(); // ikili çiftleri toplayıp koyacağımız arraylistimiz

            int[] sayi = new int[SayiAdet * 2]; // alınan cift sayisina bagli cift sayi iceren array olusturduk

            Toplam  tt =new Toplam();
            tt.Run(arrayToplam, sayi);

        }
    }
}
