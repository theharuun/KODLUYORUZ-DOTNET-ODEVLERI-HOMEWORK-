using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Sessiz_Harf
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
            Console.WriteLine("Cumledeki Kelimelerde hangisinde bir unlu bir unsuz harf vardır bulmak icin cumle yaziniz :");
            string Girilen = Console.ReadLine();

            SESSIZ czm = new SESSIZ();
            czm.Run(Girilen);
        }
    }
}
