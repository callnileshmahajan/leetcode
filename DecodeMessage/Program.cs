using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = num_ways("12345");
            Console.WriteLine(sum);
            Console.Read();
        }

        private static int num_ways(string data)
        {
            int sum = 0;
            // Base condition.
            if (string.IsNullOrWhiteSpace(data)) return 0;
            if (data.StartsWith("0")) return 0;

            if (data.Length == 1) return 1;
            if (data.Length == 2 && data[0] <= '2' && data[1] <= '6')
            {
                sum = 1 + num_ways(data[0].ToString()) + num_ways(data[1].ToString());
                return sum;
            }

            if (data[0] <= '2' && data[1] <= '6')
            {
                sum = num_ways(data[0].ToString()) + num_ways(data.Substring(1));
                return sum;
            }
            else
            {
                sum = num_ways(data.Substring(1));
                return sum;
            }
        }

        //if(data.Length == 2 && (data[0] <= '2' && data[1] <= '6'))
        //{
        //    count++;
        //    num_ways(new char[] { data[0] }, ref count);
        //    num_ways(new char[] { data[1] }, ref count);
        //}

        //for (int i = 0; i < data.Length - 2; i++)
        //{
        //    if (data[i] <= '2' && data[i + 1] <= '6')
        //    {
        //        char[] tempArray = new char[2] { data[i], data[i + 1] };
        //        num_ways(tempArray, ref count);
        //    }
        //}
    }
}
