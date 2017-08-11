using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.ReadKey();*/

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
        static int FindWord(string str1, string str2)
        {
            int count = 0;
            int index = 0;
            int j = 0;
            string s1 = str1.ToLower();
            string s2 = str2.ToLower();
            char[] c = s1.ToCharArray();
            char[] ch = s2.ToCharArray();

            for (int i = 0; i < s1.Length; i++)
            {
                
            }
            return index;
        }
    }
}
