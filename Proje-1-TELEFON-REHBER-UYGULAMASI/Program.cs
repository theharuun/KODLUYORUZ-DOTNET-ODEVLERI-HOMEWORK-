using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_TELEFON_REHBER_UYGULAMASI
{
    internal class Program
    {
        public class rehber
        {
            public string isim;
            public string soyisim;
            public long num;
          
            public void toWrite()
            {
                Console.WriteLine(isim+  " - " + soyisim +" - "+ num);
            }



        }
        enum secim
        {
            Yeni_Numara_Kaydetmek=1,
            Varolan_Numarayı_Silmek,
            Varolan_Numarayı_Güncelleme,
            Rehberi_Listelemek,
            Rehberde_Arama_Yapmak﻿
    };
        public class rehberFonk :rehber
        {
            public static void yeniNumaraKaydet( rehber kisi, List<rehber> kisiler)
            {
                Console.Write("Lütfen İsim giriniz : ");
                kisi.isim=Console.ReadLine(); Console.WriteLine();

                Console.Write("Lütfen Soyisim giriniz : ");
                kisi.soyisim = Console.ReadLine(); Console.WriteLine();
                Console.Write("Lütfen Numara giriniz : ");
                kisi.num = long.Parse(Console.ReadLine()); Console.WriteLine();
                kisiler.Add(kisi);

            }
            public static void numaraSilmek(rehber kisi, List<rehber> kisiler)
            {
                
                silincek:

                Console.Write("Silinecek İsim veya Soyisim giriniz : ");
                string name=Console.ReadLine();
                for(int i=0; i < kisiler.Count; i++)
                {
                     if (name == kisiler[i].isim )
                         {
                          kisiler.Remove(kisiler[i]);
                         }
                     else if(name == kisiler[i].soyisim)
                    {

                        kisiler.Remove(kisiler[i]);
                    }
                    {
                        Console.WriteLine(name+" rehberde yok");
                        Console.WriteLine("\n* Silmeyi sonlandırmak için -1- tuşlayınız");
                        Console.WriteLine("* Yeniden denemek için -2- tuşlayınız");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {

                        }
                        else
                        {
                            goto silincek;
                        }
                        break;
                    }
                }
         

            }
            public static void numaraGuncelleme(rehber kisi, List<rehber> kisiler)
            {
                numaraGuncelleme:
                Console.Write("guncellencek İsim veya Soyisim: ");
                string name = Console.ReadLine();

                for (int i = 0; i < kisiler.Count; i++)
                {
                    if (name == kisiler[i].isim || name == kisiler[i].soyisim)
                    {
                        Console.Write("Guncel İsmi giriniz : ");
                        kisiler[i].isim = Console.ReadLine();
                        Console.Write("Guncel Soyismi giriniz : ");
                        kisiler[i].soyisim = Console.ReadLine();
                        Console.Write("Guncel Numarayi giriniz : ");
                        kisiler[i].num = long.Parse(Console.ReadLine());

                        Console.WriteLine("\n Basariyla güncellendi :) ");

                    }
                    else
                    {
                        Console.WriteLine(" \n Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");
                        Console.WriteLine("* Güncellemeyi sonlandırmak için -1- tuşlayınız");
                        Console.WriteLine("* Yeniden denemek için -2- tuşlayınız");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {

                        }
                        else
                        {
                            goto numaraGuncelleme;
                        }
                        break;
                    }
                    break;
                }

                
            }

            public static void rehberdeSıralama(List<rehber> kisiler)
            {
                Console.Write("A-Z ye sıralanması için 1'i Z-A ya sıralanması için 2'yi tuşlayınız : ");
                int choose = Convert.ToInt16(Console.ReadLine());
                if (choose == 1)
                {
                   kisiler.Sort((x, y) => string.Compare(x.isim, y.isim));
                    foreach (rehber kisi in kisiler)
                    {
                        kisi.toWrite();
                    }
                }
                else if (choose == 2)
                {
                    kisiler.Sort((x, y) => string.Compare(x.isim, y.isim));
                    kisiler.Reverse();
                    foreach (rehber kisi in kisiler)
                    {
                        kisi.toWrite();
                    }
                }
            }
            public static void rehberdeArama(rehber kisi, List<rehber> kisiler)
            {
                Console.WriteLine("Arama yapmak istediginiz yolu seçin : ");
                Console.WriteLine("1-)İsme veya Soyisme Göre arama   2-)Numaraya göre arama");
                int secim=Convert.ToInt16(Console.ReadLine());
                if (secim == 1)
                {
                    Console.Write("isim veya soyisim yazınız:");
                    string aranan= Console.ReadLine();
                    for(int i = 0;i < kisiler.Count; i++)
                    {
                        if (aranan == kisiler[i].isim || aranan == kisiler[i].soyisim)
                        {
                            kisiler[i].toWrite();
                            
                        }
                        else
                        {
                            Console.WriteLine("bu isime veya soyisime sahip biri yok");
                        }
                        break;
                    }
                }
                else if(secim == 2)
                {
                    Console.Write("numarayi yazınız:");
                    long aranan = long.Parse(Console.ReadLine());
                    for (int i = 0; i < kisiler.Count; i++)
                    {
                        if (aranan == kisiler[i].num)
                        {
                            kisiler[i].toWrite();
                        }
                        else
                        {
                            Console.WriteLine("bu numaraya sahip biri yok");
                        }
                        break;

                    }
                }

            }

        }


        static void Main(string[] args)
        {
            rehber bir =new rehber();
            bir.isim = "harun"; bir.soyisim = "korkmaz"; bir.num = 05556868645;
            rehber iki = new rehber();
            iki.isim = "raziye"; iki.soyisim = "sever"; iki.num = 05556869696;
            rehber uc = new rehber();
            uc.isim = "ahmet"; uc.soyisim = "salim"; uc.num = 05556456363;
            rehber dort = new rehber();
            dort.isim = "hakan"; dort.soyisim = "sever"; dort.num = 05554758484;
            rehber bes = new rehber();
            bes.isim = "aslı"; bes.soyisim = "saz"; bes.num = 05554152525;

            List<rehber> kisiler = new List<rehber>();
            kisiler.Add(bir);
            kisiler.Add(iki);
            kisiler.Add(uc);
            kisiler.Add(dort);
            kisiler.Add(bes);

              A:
            Console.WriteLine("*********** LÜTFEN SECİM YAPINIZ ************");
           
            Console.WriteLine("1-"+secim.Yeni_Numara_Kaydetmek+"  2-"+secim.Varolan_Numarayı_Silmek+"  3-"+secim.Varolan_Numarayı_Güncelleme+"  4-"+secim.Rehberi_Listelemek+"                 5-"+secim.Rehberde_Arama_Yapmak + "  6- Çıkış yapmak için ");

            int kullaniciSecim=  Convert.ToInt16 (Console.ReadLine());

            switch (kullaniciSecim)
            {
                case 1:
                    rehberFonk.yeniNumaraKaydet(new rehber(),kisiler);
                    Console.WriteLine("Numara başarıyla eklendi");
                    goto A;
                    break;
                case 2:
                    rehberFonk.numaraSilmek(new rehber(),kisiler);
                    foreach (rehber kisi in kisiler)
                    { // SİLİNCEK
                        kisi.toWrite();
                    }
                    goto A;
                    break;
                   
                case 3:
                    
                    rehberFonk.numaraGuncelleme(new rehber(), kisiler);
                    foreach (rehber kisi in kisiler)
                    { 
                        kisi.toWrite();
                    }
                    goto A;
                    break;
                case 4:
                    rehberFonk.rehberdeSıralama(kisiler);
                    goto A;
                    break;
                case 5:
                    rehberFonk.rehberdeArama(new rehber(), kisiler);
                    goto A;
                    break;
                case 6:

                    break;
                default:
                    Console.WriteLine("1-6 arasında secim yapınız");
                    goto A;
                    break;
            }
            Console.ReadLine();   
        }
    }
}
