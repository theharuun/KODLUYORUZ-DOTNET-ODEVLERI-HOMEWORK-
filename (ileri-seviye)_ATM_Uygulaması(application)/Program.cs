using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _ileri_seviye__ATM_Uygulaması_application_
{
    internal class Program
    {
        class Musteri
        {
            public static List<Musteri> musteriListesi = new List<Musteri>();
          
            private string isim;
            public string Isim 
            {
                get {  return isim; }
                set 
                {
                    if(value != "") 
                    isim = value;
                }
            }

            private string sifre;
            public string Sifre
            {
                get { return sifre; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Şifre boş olamaz.");
                    }
                    else
                    {
                        sifre = value; 
                    }
                  
                }
            }

            private int bakiye;
            public int Bakiye
            {
                get { return bakiye; }
                set
                {
                    bakiye = value;
                }
            }
            public Musteri()
            {
                bakiye=0;
                listeyeEkle(this);
            }
            public static void listeyeEkle(Musteri musteri)
            {
                musteriListesi.Add(musteri);
            }
            public static void listeyiYazdir()
            {
                foreach (var item in musteriListesi)
                {
                    Console.WriteLine("Musteri ismi: "+item.isim);
                }
            }
            public static bool musteriVarmiIsim(string girisIsim)
            {
                foreach (var item in musteriListesi)
                {
                    if (girisIsim == item.isim)
                    {
                        return true;
                    }

                }

                return false;
            }
            public static bool musteriVarmi(string girisIsim , string girilenSifre, out Musteri musteri)
            {
                foreach (var item in musteriListesi)
                {
                    if (girisIsim == item.isim && girilenSifre==item.sifre)
                    {
                        musteri = item;
                        return true;
                    }
                    
                }
                musteri = null;

                return false;
            }
            public void GecmisiGoruntule()
            {
                string veri = Logger.DosyaOku();

                if (!string.IsNullOrEmpty(veri))
                    Console.WriteLine(veri);
                else
                    Console.WriteLine("\nŞuan geçmiş kaydınız yok!\n");
            }
            public void BakiyeYazdirma()
            {
                Console.WriteLine("Bakiyeniz : "+Bakiye);
            }
            public void paraCekme(int cekilecek)
            {
                Console.WriteLine("Eski Bakite tutariniz : " + bakiye);
                bakiye -= cekilecek;
                Logger.DosyaYaz("Para Cekme");
                Console.WriteLine("yeni bakiye tutariniz : " + bakiye);
            }
            public void paraYatirma(int yatirilacak)
            {
                Console.WriteLine("Eski Bakite tutariniz : " + bakiye);
                bakiye += yatirilacak;
                Logger.DosyaYaz("Para Yatirma");
                Console.WriteLine("yeni bakiye tutariniz : " + bakiye);
            }
            public void paraGönder(int yatirilacak,string musteriIsim)
            {
                Console.WriteLine(musteriIsim + " kisisine  " + yatirilacak + " miktar para gonderiliyor .. ");
                if (Musteri.musteriVarmiIsim(musteriIsim))
                {
                    foreach (var item in musteriListesi)
                    {
                        if (musteriIsim == item.isim)
                        {
                            item.bakiye += yatirilacak;
                            Logger.DosyaYaz("Para Gonderme");
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("Girmis Oldugunuz Miktarda Paraniz yok veya Gondermek İstediginiz Kisi Banka Hesabı Bulunmuyor.");
                }
            }
           public static string SifreOkuma(int uzunluk)
            {
                char[] SIFRE = new char[uzunluk];
                int SuanIndex = 0;

                while (SuanIndex < uzunluk)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Backspace && SuanIndex > 0)
                    {
                        SuanIndex--;
                        Console.Write("\b \b");
                    }
                    else if (!char.IsControl(key.KeyChar) && SuanIndex < uzunluk)
                    {
                        SIFRE[SuanIndex] = key.KeyChar;
                        SuanIndex++;
                        Console.Write("*");
                    }
                }

                return new string(SIFRE);
            }
        }
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Isim = "Harun"; musteri1.Sifre = "5757";
            Musteri musteri2 = new Musteri();
            musteri2.Isim = "Sıla"; musteri2.Sifre = "4859";
            Musteri musteri3 = new Musteri();
            musteri3.Isim = "Berkay"; musteri3.Sifre = "5703";
            Musteri musteri4 = new Musteri();
            musteri4.Isim = "Erbatur"; musteri4.Sifre = "8520";
            Musteri musteri5 = new Musteri();
            musteri5.Isim = "Selim"; musteri5.Sifre = "2003";
            

            Musteri musteriCikis;

            A:
            Console.WriteLine(" ***** HOSGELDINIZ *****\n KORKMAZ BANK ATM \n");
            Console.Write("Isminizi giriniz : "); string isim=Console.ReadLine();
            Console.Write("\n 4 Haneli Sifrenizi giriniz : "); string sifre = Musteri.SifreOkuma(4);
            Console.WriteLine();
            if (Musteri.musteriVarmi(isim,sifre,out musteriCikis))
            {
                Console.WriteLine("\n\n\n\n\n\n ***** HOSGELDINIZ "+ isim.ToUpper() +" Bey/Hanım *****");
                B:
                Console.WriteLine("Yapmak Istediginiz Islemi Seciniz");
                Console.WriteLine("1-)Para Yatir \n 2-)Para Cek \n 3-)Para Gonder Baska Musteriye \n 4-)Gecmisi Goruntule \n 5-) Bakiye Goruntule \n 6-) Cikis Yap");
                int secilen = int.Parse(Console.ReadLine());
                switch (secilen) 
                {
                    case 1:
                        Console.Write("Yatirmak Istediginiz Miktari Yaziniz :");    
                        int yatirma=int.Parse(Console.ReadLine());
                        musteriCikis.paraYatirma(yatirma);
                      
                        goto B;
                        break;
                    case 2:
                        Console.Write("Cekmek Istediginiz Miktari Yaziniz : ");
                        int cekme = int.Parse(Console.ReadLine());
                        musteriCikis.paraCekme(cekme);
                       
                        goto B;

                        break;
                    case 3:
                        Console.Write("Gondermek Istediginiz Miktari Yaziniz : ");
                        int gonderme = int.Parse(Console.ReadLine());
                        Console.Write("\n Gondermek Istediginiz Musteri Ismini Yaziniz : ");
                        string hedefIsim = Console.ReadLine();
                        musteriCikis.paraGönder(gonderme, hedefIsim);
                      
                        goto B;
                        break;
                    case 4:
                        musteriCikis.GecmisiGoruntule();
                        goto B;
                        break;
                    case 5:
                        musteriCikis.BakiyeYazdirma();
                        goto B;
                        break;
                    case 6:
                        Console.WriteLine("Gule gulee :) ");
                        Logger.DosyaYaz("Hesaptan Cikis Yapma");
                        break;
                    default: Console.WriteLine("Farkli Tus Kombinasyonlarini Bastiniz Tekrar Tercih Ekranina Yonlendiriliyorsunuz ..");
                        goto B;
                        break;
                }
                

            }
            else
            { 
                Console.WriteLine("Hesabınız Bulunmuyor Kayıt Olmak Ister Misiniz ? istiyorsanız 1 tusuna ,cikis yapmak icin 0 tusuna basiniz");
                int secilen=int.Parse(Console.ReadLine());
                if (secilen == 1)
                {
                    Musteri musteri = new Musteri();
                    Console.Write("Isminizi Yazinizi :"); musteri.Isim = Console.ReadLine();
                    Console.Write("\n Sifrenizi Yaziniz (4 adet rakam): "); musteri.Sifre = Musteri.SifreOkuma(4);
                    Console.Write("\n Sifrenizi Tekrar Yaziniz (4 adet rakam): "); string tekrar = Console.ReadLine();
                    if (tekrar == musteri.Sifre)
                    {
                        Console.WriteLine("Kaydoldunuz Giris Ekranina Yonlendiriliyorsunuz ... ");
                        goto  A;
                    }
                }
            }








            Console.ReadLine();
        }
    }
}
