using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Cizme
{
    internal class Program
    {
        class Daire
        {
            private double dist;
            public double Dist {
                get { return dist; }
                set
                {
                    if (value > 0)
                    {
                        dist = value;
                    }
                   
                } 
            }
            private int yaricap;
            public int Yaricap
            {
                get { return yaricap; }
                set
                {
                    if (value > 0)
                    {
                        yaricap = value;
                    }
                    else
                    {
                        Console.WriteLine("0 veya negatif sayi giremezsiniz");

                    }
                }
            }
            public void RUN()
            {
                Console.Write("Dairenin yarıçapını girin: ");
                 Yaricap = int.Parse(Console.ReadLine());

                int diameter = Yaricap * 2;

                // Çizim alanı oluşturma
                for (int i = 0; i <= diameter; i++)
                {
                    for (int j = 0; j <= diameter; j++)
                    {
                        Dist = Math.Sqrt((i - Yaricap) * (i - Yaricap) + (j - Yaricap) * (j - Yaricap));

                        if (dist > Yaricap - 0.5 && dist < Yaricap + 0.5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
 
        
        static void Main(string[] args)
        {
            Daire d1= new Daire();
            d1.RUN();

            Console.ReadLine();
        }
    }
}
