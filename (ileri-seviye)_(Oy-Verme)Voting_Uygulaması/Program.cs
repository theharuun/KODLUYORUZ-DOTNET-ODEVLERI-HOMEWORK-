using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace _ileri_seviye___Oy_Verme_Voting_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        { // Pre-defined kategoriler oluştur
            
            List<Kategori> kategoriler = new List<Kategori>();
            kategoriler.Add(new Kategori("Film Kategorileri"));
            kategoriler.Add(new Kategori("Tech Stack Kategorileri"));
            kategoriler.Add(new Kategori("Spor    Kategorileri"));
           
            
            
        
            Console.WriteLine("*************  HOSGELDINIZ *************");
        A:
            Console.Write("Oy vermek icin isminizi giriniz : ");
            string name = Console.ReadLine();

            if (UYELER.uyeKontrol(name))
            {
                Console.WriteLine(" HOSGELDINIZ " + name.ToUpper() + " BEY");
                Console.WriteLine("Oy vermek istediginiz kategoriyi seciniz ");
                Console.Write("1-) Film   2-) Yazılım Dilleri   3-) Spor   ");
                int secim = int.Parse(Console.ReadLine());

                kategoriler[secim - 1].Votes++;
                Console.WriteLine($"Teşekkürler, {name.ToUpper()}. Oyunuz kaydedildi.");
                
            }

            Console.WriteLine("Oy Ekranına Yeniden Donmek Icin 1 Sayisini Tuslayiniz \n" +
                " Oy Oranlarini Gormek ve Uygulamayi Kapatmak Icin 2 Sayisini Tuslayin \n ");
            int secim2 = int.Parse(Console.ReadLine());
            int toplamOy = 0;
            if (secim2 == 1)
            {
                goto A;
            }
            else if (secim2 == 2) 
            {
                foreach (Kategori kategori in kategoriler)
                {
                    toplamOy += kategori.Votes;
                }

                // Kategorilerin oylama sonuçlarını ekrana yazdır
                Console.WriteLine("KATEGORI\t\t\t\t OY SAYISI\t\t OY ORANI");
                foreach (Kategori kategori in kategoriler)
                {
                    double oyYuzdesi = (double)kategori.Votes / toplamOy * 100;
                    Console.WriteLine($"{kategori.Name,-40} {kategori.Votes,-20} {oyYuzdesi,5:N2}%");
                }
            }
            // Kategorilerin toplam oylarını hesapla
         
         
            

            Console.WriteLine("Program sonlandı. Çıkmak için ENTER tuşuna basın.");
            Console.ReadLine();

        }
    }
     class UYELER
    {
        static List<string> Uyeler = new List<string>() { };
      
        public static bool uyeKontrol(string name)
        {
            if (Uyeler.Contains(name))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Kaydiniz yoktu , simdi kaydoldunuz");

                Uyeler.Add(name);
            }

            return true;
        }

    }
    internal class Kategori
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Kategori() { }
        public Kategori(string name)
        {
            Name = name;
            Votes = 0;
        }


    }
}
