using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyString
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Multiply("123", "456");
            Console.Write(result);
            Console.Read();
        }

        private static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            int carryForward = 0;
            int charIndex;
            List<char[]> results = new List<char[]>();
            int extensionCount = 0;

            for (int indexN1 = num1.Length - 1; indexN1 >= 0; indexN1--)
            {
                char[] result = new char[num1.Length + num2.Length];
                charIndex = result.Length - 1;

                if (extensionCount > 0)
                {
                    for (int i = 0; i < extensionCount; i++)
                    {
                        result[charIndex] = IntToChar(0);
                        charIndex--;
                    }                  
                }

                for (int indexN2 = num2.Length - 1; indexN2 >= 0; indexN2--)
                {
                    result[charIndex] = MultiplyDigits(CharToInt(num1[indexN1]), CharToInt(num2[indexN2]), ref carryForward);
                    charIndex--;
                }

                // handling last carry forward
                if (carryForward > 0)
                {
                    result[charIndex] = IntToChar(carryForward);
                    charIndex--;
                }

                AddLeadingZeros(ref result, charIndex);

                carryForward = 0;
                extensionCount++;
                results.Add(result);
            }

            char[] multiplicationResult = ComputeAddition(results);
            string resultString = new string(multiplicationResult).TrimStart(new [] { '0' });
            return resultString;
        }

        private static char[] ComputeAddition(List<char[]> results)
        {
            if (results.Count == 1) return results[0];
            
            char[] additionResult = new char[results[results.Count -1].Length + 1 + results.Count - 1];
            int digitIndex = additionResult.Length - 1;
            int carryForward = 0;
            int sum = 0;
            int i = 0;

            for (int index = results[0].Length - 1; index >= 0; index--)
            {
                for (int listIndex = 0; listIndex < results.Count; listIndex++)
                {
                    sum = sum + CharToInt(results[listIndex][index]);
                }
                
                carryForward = sum / 10;
                additionResult[digitIndex] = IntToChar(sum % 10);
                sum = carryForward;
                digitIndex--;
            }

            if (carryForward > 0)
            {
                additionResult[digitIndex] = IntToChar(carryForward);
                digitIndex--;
            }

            AddLeadingZeros(ref additionResult, digitIndex);

            return additionResult;
        }

        private static void AddLeadingZeros(ref char[] inCharArray, int digitIndex)
        {
            while (digitIndex >= 0)
            {
                inCharArray[digitIndex] = '0';
                digitIndex--;
            }
        }

        private static char MultiplyDigits(int n1, int n2, ref int carryForward)
        {
            int result = (n1 * n2) + carryForward;

            if (result > 9)
            {
                carryForward = result / 10;
                return IntToChar(result % 10);
            }
            else
            {
                carryForward = 0;
                return IntToChar(result);
            }
        }

        private static int CharToInt(char inChar)
        {
            return inChar - 48;
        }

        private static char IntToChar(int inDigit)
        {
            return (char)(inDigit + 48);
        }
    }
}
