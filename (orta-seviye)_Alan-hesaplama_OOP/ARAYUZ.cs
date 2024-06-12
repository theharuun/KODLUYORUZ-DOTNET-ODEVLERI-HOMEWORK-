using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _orta_seviye__Alan_hesaplama_OOP
{
    internal class ARAYUZ
    {

        public void RUN()
        {

            Console.WriteLine("******** HOSGELDİNİZ ***********");
            Console.WriteLine();
            Console.WriteLine(" HANGI SEKIL UZERINDE CALISMAK ISTERSINIZ O RAKAMI YAZIN ? ");
            AGAIN:
            Console.WriteLine("1-)DIKDORTGEN   2-)DAIRE   3-)UCGEN   4-)KARE   5-)UYGULAMAYI KAPAT"  );
            int secenek=int.Parse(Console.ReadLine());

            switch (secenek)
            {
                    case 1:
                            DIKDORTGEN dkgen =new DIKDORTGEN();
                            dkgen.RUN();
                    goto AGAIN;
                    break;
                    
                    case 2:
                           DAIRE daire = new DAIRE();
                            daire.RUN();
                    goto AGAIN;
                    break;
                    
                    case 3:
                            UCGEN ucgen = new UCGEN();
                            ucgen.RUN();
                    goto AGAIN;
                    break;
                    
                    case 4:

                            KARE kare = new KARE();
                            kare.RUN();
                    goto AGAIN;
                    break;
                    case 5:
                    Console.WriteLine("KAPATMAK ICIN ENTER TUSUNA BASIN ");
                    break;
                    
                    default:
                    Console.WriteLine("TEKRAR TERCIH YAPINIZ !!! ");
                    goto AGAIN;

                    break;

            }


         }


    }
}
