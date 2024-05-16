using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ODEV_2
{
    internal class Program
    {
       

        public static int asal_asalDegil_listeleme(ArrayList array)
        {
 
            ArrayList  prime= new ArrayList();

            ArrayList nonPrime = new ArrayList();

            int sum1= 0;
            int sum2=0;
           

            int kontrol=0;

            for (int i = 0;i<array.Count;i++)
            {
                for(int k = 2; k < (int)array[i]; k++)  // ARRAYDAKİ HER BIR SAYIYA ERISTIKTEN SONRA 2 DEN BASLAYARAK O SAYIYA KADAR BUTUN SAYILARA BOLUMUNDEN KALAN 0SA ASALDIR DIYIP BREAK YAPIYORUZ
                {
                    if ((int)array[i] % k == 0)
                    {
                        //non
                        kontrol++;
                            if(kontrol != 0)
                            {
                                nonPrime.Add((int)array[i]);
                                array.Remove((int)array[i]);
                                
                            }


                             break;      
                    }
                }
            }
           
            

            Console.WriteLine("*************************************************");
            Console.WriteLine(" asal (PRIME) ");
            array.Sort();
            foreach (int i in array)
            {
                Console.Write(i + "-");
            }

            for (int i = 0; i < prime.Count; i++)
            {
                sum1 += (int)prime[i];
            }
            Console.WriteLine("average of member of array: " + sum1 / prime.Count + " count of member: " + prime.Count);




            Console.WriteLine("*************************************************");
            Console.WriteLine(" asal OLMAYAN (NONPRIME)  " );
            nonPrime.Sort();
            foreach (int i in nonPrime)
            {
                Console.Write(i + "-");
            }
           
           for(int i = 0;i<nonPrime.Count;i++)
            {
                sum2 += (int)nonPrime[i];
            }
            Console.WriteLine("average of member of array: " + sum2 /nonPrime.Count +" count of member : "+ nonPrime.Count);



            return 0;
        }

        static void Main(string[] args)
        {

            
            ArrayList numbers = new ArrayList();

            Console.WriteLine("Enter 20 numbers that is bigger than zero (0)");
            try
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter number {i + 1}. : ");
                    int num = int.Parse(Console.ReadLine());
                    if (num < 0)
                    {
                        throw new Exception("please enter a number greater than to zero (0) ");
                    }
                    numbers.Add(num);
                }
            } catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                
            }
           
            asal_asalDegil_listeleme(numbers);

  
            Console.ReadLine();
       
        }
    }
}
