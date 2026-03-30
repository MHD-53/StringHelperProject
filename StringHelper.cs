using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RA22
{
    internal class StringHelper
    {
        public static int CountLower(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >='a' && str[i] <='z')
                    count ++;
            }
            return count;
        }

        public static int CountUpper(string str)
        {
            int count = 0;
            for(int i = 0; i < str.Length;i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    count++;
            }
            return count;
        }

        public static string Upper(string str)
        {
            int num = 0;
            string newstr = ("");
            for (int i = 0;i < str.Length;i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    num = str[i];
                    num = num - 32;
                    newstr += (char)num;
                }
                else
                    newstr += str[i];
            }
            return newstr;
        }


        public static int First(string str,Char target)
        {
            for (int i = 0; i<str.Length ; i++)
            {
                if (str[i] == target)
                    return i+1;
            }
            return -1;
        }

        public static string Lower(string str)
        {
            int num = 0;
            string newstr = ("");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    num = str[i];
                    num += 32;
                    newstr += (char)num;
                }
                else
                    newstr += str[i];
            }
            return newstr;
        }

        public static int AllFound(string str, char target)
        {
            int place;
            Console.WriteLine("Positions :");
            bool fo = false;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == target)
                {
                    place = i + 1;
                    Console.Write(place);
                    Console.Write("...");
                    fo = true;
                    return place;
                }
                int r = 0;
                return r;

        }

        public static int CountVowels(string txt)
        {
            int NumOfVowels = 0;
            foreach (char Vo in txt) //بتصير ب "فور" بس هيك احسن وانضف
            {
                if (Vo == 'a' || Vo == 'e' || Vo == 'i' || Vo == 'u' || Vo == 'o' || Vo == 'A' ||
                    Vo == 'O' || Vo == 'U' || Vo == 'I' || Vo =='E')
                    NumOfVowels++;
            }
                return NumOfVowels;
        }

        public static void Radar(string txt)
        {
            string Reversed = "";
            for (int i = txt.Length - 1; i >= 0; i--)
                Reversed += txt[i];

            if (txt == Reversed)
                Console.WriteLine("--RESULT : Its Palindrome");
            else Console.WriteLine("--RESULT : Not Palindrome");

        }
    }   
}
