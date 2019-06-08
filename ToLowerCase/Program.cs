using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ToLowerCase("Hello World");
            Console.WriteLine(result);
            Console.Read();
        }

        private static string ToLowerCase(string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            char[] lowerCaseString = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    lowerCaseString[i] = (char)(str[i] + 32);
            }

            return new string(lowerCaseString);
        }
    }
}
