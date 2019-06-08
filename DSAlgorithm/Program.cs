using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //712. Minimum ASCII Delete Sum for Two Strings

            //            "bpiqrmtp"
            //"alfjfobwdtbie"
            string s1 = "bpiqrmtp";
            string s2 = "alfjfobwdtbie";

            int result = MinimumDeleteSum(s1, s2);
            Console.WriteLine(result);

            Console.Read();
        }

        private static int MinimumDeleteSum(string s1, string s2)
        {
            int extraCost = FindExtraCost(ref s1, s2);
            extraCost += FindExtraCost(ref s2, s1);

            if (s1.Equals(s2))
                return extraCost;

            var dicStringMinCost1 = new Dictionary<string, int>();
           var dicStringMinCost2 = new Dictionary<string, int>();

            dicStringMinCost1.Add(s1, 0);
            CalculateCost(s1, 0, dicStringMinCost1);
            dicStringMinCost2.Add(s2, 0);
            CalculateCost(s2, 0, dicStringMinCost2);

            int totalCost = FindTotalCost(dicStringMinCost1, dicStringMinCost2, extraCost);

            return totalCost;
        }

        private static int FindTotalCost(Dictionary<string, int> str1Costs, Dictionary<string, int> str2Costs, int extraCost)
        {
            int totalCost = extraCost;

            int minimumCost = int.MaxValue;

            foreach (var cost1 in str1Costs)
            {
                foreach (var cost2 in str2Costs)
                {
                   if(cost1.Key.Equals(cost2.Key))
                    {
                        if (cost1.Value + cost2.Value < minimumCost)
                            minimumCost = cost1.Value + cost2.Value;
                    }
                }
            }

            if (minimumCost != int.MaxValue)
                totalCost = totalCost + minimumCost;

            return totalCost;
        }

        private static int FindExtraCost(ref string s1, string s2)
        {
            int extraCost = 0;
            int count = 0;
            List<char> toBeRemoved = new List<char>();
            //Find  and remove missing characters.
            foreach (var ascii1 in s1)
            {
                foreach (var ascii2 in s2)
                {
                    if (ascii1 == ascii2)
                    {
                        break;
                    }
                    count++;
                }
                if (count == s2.Length)
                {
                    extraCost += ascii1;
                    toBeRemoved.Add(ascii1);
                }

                count = 0;
            }

            if (toBeRemoved.Any())
            {
                foreach (var ch in toBeRemoved)
                    s1 = s1.Remove(s1.IndexOf(ch), 1);
            }

            return extraCost;
        }

        private static void CalculateCost(string inputString, int existingCost, Dictionary<string, int> stringCosts)
        {
            if (string.IsNullOrEmpty(inputString) ||  inputString.Length == 1) return;

            int skipCharacterIndex = 0;

            while (skipCharacterIndex < inputString.Length)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (skipCharacterIndex + 1 > inputString.Length) break;

                    var str = inputString.Remove(skipCharacterIndex, 1);
                    AddToCostDictionary(stringCosts, str, GetStringCost(inputString.Substring(skipCharacterIndex, 1)) + existingCost);
                    skipCharacterIndex++;
                }
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                CalculateCost(inputString.Remove(i, 1), inputString.First() + existingCost, stringCosts); 
            }
        }

        private static void AddToCostDictionary(Dictionary<string, int> dicStringCosts, string str, int cost)
        {
            if (dicStringCosts.ContainsKey(str))
            {
                if (dicStringCosts[str] > cost)
                    dicStringCosts[str] = cost;
            }
            else
                dicStringCosts.Add(str, cost);
        }
           
        private static int GetStringCost(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return 0;
            int sum = 0;
            foreach (var ch in inputString)
            {
                sum += sum + ch;
            }

            return sum;
        }
    }
}
