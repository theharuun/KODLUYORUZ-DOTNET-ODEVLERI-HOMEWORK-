using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}. number :  ");
                list[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(list);
            int n1 = list[0];
            int n2 = list[1];
            int n3 = list[2];
            int m1 = list[list.Length - 1];
            int m2 = list[list.Length - 2];
            int m3 = list[list.Length - 3];

            float minOrtalama = (float)((n1 + n2 + n3) / 3);
            float maxOrtalama = (float)((m1 + m2 + m3) / 3);

            Console.WriteLine("average of the three smallest  number : " + minOrtalama);
            Console.WriteLine("average of the three biggest number : " + maxOrtalama);
            float sumAvg = maxOrtalama + minOrtalama;
            Console.WriteLine("sum of averages : " + sumAvg);

            Console.ReadLine();
        }
    }
}
