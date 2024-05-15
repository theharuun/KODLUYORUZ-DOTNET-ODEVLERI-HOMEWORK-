using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KODLUYORUZ_DOTNET_ODEVLERI_HOMEWORK_

{
    internal class Program
    {

        public static int cift_bulma(int n)
        {
            int[]  arr= new int[n];
            for(int i=0; i < arr.Length; i++)
            {

                Console.Write(i + 1);
                Console.Write(". sayiyi giriniz : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int k = 0; k < arr.Length; k++)
            {
                if (arr[k] % 2 == 0)
                {

                    Console.Write(arr[k] + " -- ");

                }
            }



            return 0;
        }

        public static int esit_bulma(int n,int m)
        {

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(i + 1);
                Console.Write(". sayiyi giriniz : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] ==m )
                {

                    Console.Write("girdiginiz sayilardan m sayisina esittir,bu sayi  bu indexteki sayidir");
                     Console.Write(k+1);
                     Console.WriteLine(". sayidir.");


                }
                else if ( arr[k] % m == 0)
                {
                    Console.Write("girdiginiz sayilardan m sayisina tam bolunuyor,bu indexteki sayidir");
                    Console.Write(k + 1);
                    Console.WriteLine(". sayidir.");
                }
            }
           




            return 0;
        }

        public static void string_yazdirma(int  n)
        {
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(i + 1);
                Console.Write(". kelimeyi giriniz: ");
                arr[i] = (Console.ReadLine());
            }

            foreach (var aa in arr)
            {
                Console.WriteLine(aa);
            }

        }


        public  static int CumledekiKelimeSayisi(string cumle)
                            {
                                // Cümledeki boşlukları kullanarak cümleyi parçalayalım
                                string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                                // Toplam kelime sayısını döndürelim
                                return kelimeler.Length;
                            }

         public    static int CumledekiHarfSayisi(string cumle)
                            {
                                // Cümledeki boşlukları ve noktalama işaretlerini kaldıralım
                                cumle = cumle.Replace(" ", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("!", "").Replace("?", "");

                                // Toplam harf sayısını döndürelim
                                return cumle.Length;
                            }




        static void Main(string[] args)
        {
            Console.WriteLine("1.soru");
            //1.SORU girilen sayilardan cift olani yazdirma
            Console.WriteLine("girmek istediginiz sayiyi adedini girin ve cift olanlari sizlere gosterelim");
            int istek= Convert.ToInt32(Console.ReadLine());
            cift_bulma(istek);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2.soru");

            //2.SORU 
            Console.WriteLine("2 Sayi giriniz ilk girdiginiz kadar yeni sayilar giriceksiniz ve ikinc girdiginiz sayiya esit veya tam bolunenleri yazicaz");

            Console.Write("1.sayi: ");
            int k= Convert.ToInt32(Console.ReadLine());

            Console.Write("2.sayi :");
            int m = Convert.ToInt32(Console.ReadLine());

            esit_bulma(k,m);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("3.soru");

            // 3.SORU string olarak yazdirmak
            Console.WriteLine(" Lutfen bir sayi girin ve bu sayi kadar kelime yazicaksiniz bunlari sizlere geri dondurup vericez : ");

            int n = Convert.ToInt32(Console.ReadLine());
            string_yazdirma(n);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("4.soru");

            //4.SORU CUMLEDE KAC KELİME HARF VAR BUL

            // Kullanıcıdan bir cümle girmesini isteyelim
            Console.WriteLine("Lütfen bir cümle girin:");

            // Kullanıcının girdisini okuyalım
            string cumle = Console.ReadLine();

            // Cümledeki toplam kelime sayısını hesaplayalım
            int kelimeSayisi = CumledekiKelimeSayisi(cumle);

            // Cümledeki toplam harf sayısını hesaplayalım
            int harfSayisi = CumledekiHarfSayisi(cumle);

            // Sonuçları ekrana yazdıralım
            Console.WriteLine("Girilen cümledeki toplam kelime sayısı: " + kelimeSayisi);
            Console.WriteLine("Girilen cümledeki toplam harf sayısı: " + harfSayisi);

            // Programın kapatılmasını beklemek için bir tuşa basılmasını isteyelim
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
