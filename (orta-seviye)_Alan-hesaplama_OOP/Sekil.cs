using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Alan_hesaplama_OOP
{
    internal class Sekil
    {
        public int taban;
        public int yukseklik;
        public double yaricap;
        public int secim;
        public Sekil(int taban=0, int yukseklik = 0, double yaricap = 0 )
        {
            this.taban = taban;
            this.yukseklik = yukseklik;
            this.yaricap = yaricap;
        }
        public virtual double getAlan(int yukseklik,int taban) 
        {
            return yukseklik + taban ;
        }
        public virtual double getAlanDaire (double yaricap)
        {
            return yaricap;
        }
        public virtual double getHacim(int yukseklik, int taban)
        {
            return yukseklik + taban;
        }
        public virtual double getHacimDaire(double yaricap)
        {
            return  yaricap ;
        }
        public virtual double getCevre(int yukseklik, int taban)
        {
            return yukseklik +  taban;
        }
        public virtual double getCevreDaire(double yaricap)
        {
            return yaricap;
        }

    }

    internal class DIKDORTGEN : Sekil
    {
        public void RUN()
        {
            Console.Write("Dikdortgen tabanini giriniz : ");
            taban = int.Parse(Console.ReadLine());
            Console.Write("\n Dikdortgen yuksekligini giriniz : ");
            yukseklik = int.Parse(Console.ReadLine());
            again:
            Console.WriteLine("hangisini hesaplamak istersiniz? \n 1-)Alan   2-) Cevre \n");
            int secim=int.Parse(Console.ReadLine());
            switch (secim) 
            {
                case 1: 
                   double alan= getAlan(taban, yukseklik);
                    Console.WriteLine("Dikdortgen Alani : "+ alan);
                    break;
                case 2:
                    double cevre=getCevre(taban, yukseklik);
                    Console.WriteLine("Dikdortgen Hacim : "+cevre);
                    break;
                    default: Console.WriteLine("OLMAYAN BIR ISLEME BASTINIZ !!!  YENIDEN TERCIH YAPINIZ ");
                    goto again;

                    break;

            }
            
        }

        public override double getAlan(int yukseklik, int taban)
        {


            return yukseklik*taban;
        }

        public override double getCevre(int yukseklik, int taban)
        {
            return 2*(taban+yukseklik);
        }

    }
    internal class KARE : Sekil
    {
        public void RUN()
        {
            Console.Write("Karenin bir kosesini  giriniz : ");
            taban = int.Parse(Console.ReadLine());
         
        again:
            Console.WriteLine("hangisini hesaplamak istersiniz? \n 1-)Alan   2-) Cevre \n");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    double alan = getAlan(taban, taban);
                    Console.WriteLine("Dikdortgen Alani : " + alan);
                    break;
                case 2:
                    double cevre = getCevre(taban,taban);
                    Console.WriteLine("Dikdortgen Hacim : " + cevre);
                    break;
                default:
                    Console.WriteLine("OLMAYAN BIR ISLEME BASTINIZ !!!  YENIDEN TERCIH YAPINIZ ");
                    goto again;

                    break;

            }

        }

        public override double getAlan(int yukseklik, int taban)
        {


            return yukseklik * taban;
        }

        public override double getCevre(int yukseklik, int taban)
        {
            return 2 * (taban + yukseklik);
        }

    }
    internal class UCGEN : Sekil
    {
        public void RUN()
        {
            Console.Write("Ucgen tabanini giriniz : ");
            taban = int.Parse(Console.ReadLine());
            Console.Write("\nUcgen yuksekligini giriniz : ");
            yukseklik = int.Parse(Console.ReadLine());

        again:
            Console.WriteLine("hangisini hesaplamak istersiniz? \n 1-)Alan   2-) Cevre \n");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    double alan = getAlan(taban, yukseklik);
                    Console.WriteLine("Dikdortgen Alani : " + alan);
                    break;
                case 2:
                    double cevre = getCevre(yukseklik, taban);
                    Console.WriteLine("Dikdortgen Hacim : " + cevre);
                    break;
                default:
                    Console.WriteLine("OLMAYAN BIR ISLEME BASTINIZ !!!  YENIDEN TERCIH YAPINIZ ");
                    goto again;

                    break;

            }

        }

        public override double getAlan(int yukseklik, int taban)
        {


            return (yukseklik * taban)/2 ;
        }

        public override double getCevre(int yukseklik, int taban)
        {
            double kenar=Math.Sqrt((taban/2)*(taban/2)+(yukseklik));

            double cevre = taban + (kenar * 2);
            return   cevre ;
        }

    }
    internal class DAIRE : Sekil
    {
        const double PI = 3.14;
        public void RUN()
        {
            Console.Write("Dairenin yaricapini giriniz : ");
            yaricap = double.Parse(Console.ReadLine());
           

        again:
            Console.WriteLine("hangisini hesaplamak istersiniz? \n 1-)Alan   2-) Cevre \n");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    double alan = getAlanDaire(yaricap);
                    Console.WriteLine("Dikdortgen Alani : " + alan);
                    break;
                case 2:
                    double cevre = getCevreDaire(yaricap);
                    Console.WriteLine("Dikdortgen Hacim : " + cevre);
                    break;
                default:
                    Console.WriteLine("OLMAYAN BIR ISLEME BASTINIZ !!!  YENIDEN TERCIH YAPINIZ ");
                    goto again;

                    break;

            }

        }

        public override double getAlanDaire(double yaricap)
        {
         

            return    PI*yaricap*yaricap ;
        }

        public override double getCevreDaire(double yaricap)
        {
           
            return    2*PI*yaricap;
        }

    }

}
