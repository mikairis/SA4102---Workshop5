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
            Console.WriteLine("****************************Workshop 5 Task 3********************************");
            Console.WriteLine("**This programme matches 2 sets of data from 2 strings and returns a boolean**");

            string[] s1 = { "The brown fox", "The brown fox", "The brown fox", "T", "The bras basah complex" };
            string[] s2 = { "O", "FOX", "bRO", "bRO", "bRO" };

            for (int i = 0; i < s1.Length; i++)
            {
                string str1 = s1[i];
                string str2 = s2[i];

                string lowStr1 = str1.ToLower();
                string lowStr2 = str2.ToLower();

                bool boolCheck = InString(lowStr1, lowStr2);
                Console.WriteLine(str1 + "\t\t\t" + str2 + "\t\t\t" + boolCheck);
            }
            Console.ReadKey();
        }
        static Boolean InString(string s1, string s2)
        {
            bool boolChecker = s1.Contains(s2);
            return boolChecker;
        }
    }
}
