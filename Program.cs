using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();
            Console.WriteLine(" # Choose 1 to 9 :\n 1.Exit\n 2.Change text\n 3.Count vowels\n 4.Count upper letters\n 5.Count lower letters\n 6.Transform to upper\n 7.Transform to lower\n 8.Enter a letter to find the first occurience\n 9..... all of the ...\n 10.Radar level");
            int q = Convert.ToInt32(Console.ReadLine());

            if (q == 1)
                Console.WriteLine("#--#--# END #--#--#");

            else if (q==2)
            {
                Console.WriteLine(" #Enter ur new text");
                string NewText = Console.ReadLine(); 
            }

            else if (q==3)
            {
                int Counter_Vowels = StringHelper.CountVowels(text);
                Console.WriteLine("--RESULT : "+Counter_Vowels);
            }

            else if (q==4)
            {
                int CounterUpp = StringHelper.CountUpper(text);
                Console.WriteLine("--RESULT : "+CounterUpp);
            }

            else if (q == 5)
            {
                int Countlow = StringHelper.CountLower(text);
                Console.WriteLine("-- RESULT : " + Countlow);
            }

            else if (q == 6)
            {
                string upp;
                upp = StringHelper.Upper(text);
                Console.WriteLine("-- RESULT : " + upp);
            }

            else if (q == 7)
            {
                string low;
                low= StringHelper.Lower(text);
                Console.WriteLine("-- RESULT : "+low);
            }

            else if (q == 8)
            {
                Console.WriteLine(" #Gimme ur letter sir...");
                char letter = Convert.ToChar(Console.ReadLine());
                int FirstOcc = StringHelper.First(text, letter);
                Console.WriteLine("-- RESULT : " + FirstOcc);
            }

            else if (q == 9)
            {
                char letter = Convert.ToChar(Console.ReadLine());
                int x = StringHelper.AllFound(text, letter);
                Console.WriteLine("-- RESULT : "+x);
            }
            

        }
    }
}
