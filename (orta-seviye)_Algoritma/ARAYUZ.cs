using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Algoritma
{
    internal class ARAYUZ
    {
        private string girilen;
        public string Girilen
        {
            get { return girilen; }

            set
            {
                if (value != null)
                {
                    girilen = value;
                }
            }
        }

        public void RUN()
        {
            Console.WriteLine("Cumledeki Kelimenin ilk ve son harflerini degistirmek icin cumleyi yaziniz :");
            string Girilen = Console.ReadLine();

           ALGO czm = new ALGO();
            czm.Run(Girilen);
        }
    }
}
