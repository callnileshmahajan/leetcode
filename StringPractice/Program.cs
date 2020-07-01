using System;
using System.Collections.Generic;
using System.Text;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
           var result =  LongestCommonPrefix(strs);
            Console.WriteLine(result);
            Console.Read();
        }

        #region Longest Common Prefix
        public static string LongestCommonPrefix(string[] strs)
        {
            int length = int.MaxValue;
           
            foreach (var item in strs)
            {
                if (length > item.Length)
                    length = item.Length;
            }

            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < length; i++)
            {
                char currentChar = '0';
                for (int k = 0; k < strs.Length; k++)
                {
                    if (currentChar == '0')
                        currentChar = strs[k][i];

                    if (currentChar != strs[k][i])
                    {
                        currentChar = '0';
                        break;
                    }
                }

                if (currentChar != '0')
                {
                    result.Append(currentChar);
                }
                else
                {
                    break;
                }
            }

            return result.ToString() ;
        }
        #endregion

        #region CountAndSay 
        public static string CountAndSay(int n)
        {
            if (n == 1) return "1";
            string result = string.Empty;

            if(n > 1)
                result = CountAndSay(n - 1);

            int counter = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if ((i + 1) < result.Length && result[i] == result[i + 1])
                    counter++;
                else
                {
                    if (counter > 1)
                    {
                        sb.Append(counter.ToString());
                        sb.Append(result[i]);
                    }
                    else
                    {
                        sb.Append("1");
                        sb.Append(result[i]);                       
                    }
                    counter = 1;
                }
            }

            return sb.ToString();
        }

        #endregion

        #region anagram
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            char[] sc = s.ToCharArray();
            char[] tc = t.ToCharArray();

            Array.Sort(sc);
            Array.Sort(tc);

            for (int i = 0; i < sc.Length; i++)
            {
                if (sc[i] != tc[i])
                    return false;
            }

            return true;
        }

        #endregion

        #region First Unique

        /// <summary>
        /// Iterate each charcter in the remaning string to find it is repeated. check boundary condition for last character.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FirstUniqChar(string s)
        {
            if (s.Length == 1) return 0;

            char temp;
            bool isFound;
            List<char> processed = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                temp = s[i];

                if (processed.Contains(temp))
                    continue;
                else
                    processed.Add(temp);

                isFound = false;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (temp == s[j])
                        break; // Not unique. 

                    if (j == s.Length - 1)
                        isFound = true;
                }

                if (isFound || i == s.Length - 1)
                    return i;
            }

            return -1;
        }
        #endregion

        #region Reverse Integer
        /// <summary>
        /// Negative number, Max and Min values of integer, better solution Could be done with converting integer to string.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            int result = 0;
            bool negative = x < 0;
            if (x == int.MaxValue || x == int.MinValue)
                return 0;

            x = Math.Abs(x);
            while (x > 0)
            {
                int d = x % 10;
                x = x / 10;

                if (result == 0)
                    result = d;
                else
                {
                    try
                    {
                        result = checked(result * 10 + d);
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }

            if (negative)
                result = result * -1;

            return result;
        }

        #endregion

        #region string reverse

        public static void ReverseString(char[] s)
        {
            if (s.Length < 1) return;

            int i = 0, j = s.Length - 1;
            char temp;
            while (i < j)
            {
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++;
                j--;
            }
        }

        #endregion

    }
}
