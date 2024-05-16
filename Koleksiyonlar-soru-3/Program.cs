using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a sentence: ");
            string sentence = Console.ReadLine();
            string trimmedSentence  = sentence.Replace(" ", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("!", "").Replace("?", "");
            trimmedSentence=trimmedSentence.ToLower();

            List<string> words = new List<string>();
            

            Console.WriteLine("Orjinal sentence: " + sentence);
            Console.WriteLine("Sentence with spaces removed: " + trimmedSentence);

            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] =='a' || sentence[i] =='e' || sentence[i]=='i' || sentence[i] =='ı' || sentence[i] =='o' || sentence[i] == 'ö' || sentence[i] =='u' || sentence[i] =='ü')
                {
                    words.Add(sentence[i].ToString());
                }
            }
            

            words.ForEach(word => Console.WriteLine(word));

            Console.ReadLine();

        }
    }
}
