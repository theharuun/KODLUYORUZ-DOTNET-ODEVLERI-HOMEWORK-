using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    internal class Ortalama
    {
        public double Hesapla(List <int> sayi)
        {
           
            if(sayi.Count == 0)
            {
                return 0.0;
            }
               Console.WriteLine( sayi.Average());
            return sayi.Average();
        }
    }
}
