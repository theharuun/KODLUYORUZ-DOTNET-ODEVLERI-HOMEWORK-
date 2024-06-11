using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Tersten_Yazdırma
{
    internal class ARAYUZ
    {
        private string girilen;
        public string Girilen {
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
            Console.WriteLine("Kelimeleri Tersten Yazilmasini Istediginiz Cumleyi Giriniz : ");
            string Girilen=Console.ReadLine();
             
            Cozum czm=new Cozum();
            czm.Run(Girilen);
        } 
    }
}
