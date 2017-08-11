using System;

namespace Workshop5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("*****************************Workshop 5 Task 3********************************");
            Console.WriteLine("**This programme matches 2 sets of data from 2 strings and returns a boolean**");
            string[] s1 = { "The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex" };
            string[] s2 = { "O", "FOX", "bRO", "bRO", "bRO" };
            for (int i = 0; i < s1.Length; i++)
            {
                string str1 = s1[i];
                string str2 = s2[i];
                bool boolCheck = InString(str1, str2);
                Console.WriteLine(str1 + "\t\t\t" + str2 + "\t\t\t" + boolCheck);
            }
            Console.ReadKey();

            Console.WriteLine("******************************Workshop 5 Task 6******************************");
            Console.WriteLine("**This programme will find specific occurance in string and substitute them**");
            Console.WriteLine("*****************************************************************************");
            Start:
            Console.Write("Enter a word or phrase: ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a character that you would like to search from string: ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter another character that you would like use to substitute into the previous character from string: ");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            string newS = Substitute(s, c1, c2);
            Console.WriteLine("The substituted version is " + "\"" + newS + "\"");
            Console.ReadKey();
            Console.WriteLine();
            goto Start;

        }
        static string Substitute(string s, char c1, char c2)
        {
            char[] charS = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (charS[i] == c1)
                {
                    charS[i] = c2;
                }
            }
            string newS = new string(charS);
            return newS;*/

            Console.WriteLine("****************************************Workshop 5 Task 4***************************************");
            Console.WriteLine("**This programme matches 2 sets of data from 2 strings and returns an integer for the position**");

            string[] s1 = { "The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex" };
            string[] s2 = { "O", "FOX", "bRO", "bRO", "bRO" };

            for (int i = 0; i < s1.Length; i++)
            {
                string str1 = s1[i];
                string str2 = s2[i];
                bool boolCheck = InString(str1, str2);
                if (boolCheck == true)
                {
                    int position = FindWord(str1, str2);
                    Console.WriteLine(position);
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            Console.ReadKey();
        }
        static Boolean InString(string s1, string s2)
        {
            string str1 = s1.ToLower();
            string str2 = s2.ToLower();
            bool boolChecker = str1.Contains(str2);
            return boolChecker;
        }
        static int FindWord(string s1, string s2)
        {
            string str1 = s1.ToLower();
            string str2 = s2.ToLower();
            int index = str1.IndexOf(str2);
            return index;
        }
    }
}
