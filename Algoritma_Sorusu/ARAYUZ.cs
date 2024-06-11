using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Sorusu
{
    internal class ARAYUZ
    {

        public void RUN()
        {

            Console.Write("Kac tane kelime algoritma denemek istersiniz :  ");
            int deneme=int.Parse(Console.ReadLine());
            for (int i = 0; i < deneme; i++) 
            {
                Console.WriteLine(i+1+".Kelimen:");
                ALGO aLGO = new ALGO();
                aLGO.RUN();

            }





        }
        
    }
}
