using System;
using System.Collections.Generic;

namespace CharacterCountStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            string verse = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis " +
                "augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit " +
                "amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus " +
                "ac suscipit vel, volutpat eget massa. Donec nec velit non ligula " +
                "efficitur luctus.";

            //string[] arr = verse.ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            //for (int i=0; i<verse.Length; i++)
            foreach (char c in verse.ToCharArray())
            {
                //string selection = arr[i];

                if (charCount.ContainsKey(c))
                {
                    charCount[c] ++;
                }
                else
                {
                    charCount.Add(c, 1);
                    
                }
                
            }

            foreach (KeyValuePair<char, int> item in charCount)
            {
                Console.WriteLine(item.Key + ": " + item.Value );

            }
        }
    }
}
