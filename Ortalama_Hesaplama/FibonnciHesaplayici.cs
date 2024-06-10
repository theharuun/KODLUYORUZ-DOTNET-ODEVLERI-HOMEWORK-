using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    internal class FibonnciHesaplayici
    {
        public int sayi;


        public List<int> Calculate(int sayi)
        {
            var series = new List<int> { 0, 1 };
            for (int i = 2; i <sayi; i++)
            {
                series.Add(series[i - 1] + series[i - 2]);
            }

            foreach (var item in series)
            {
                Console.WriteLine(item);
            }
            return series.GetRange(0, sayi);
        }

    }
}
