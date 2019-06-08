using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = NumJewelsInStones("aA", "aAAbbbb");
            Console.WriteLine(result);
            Console.Read();
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            var grouppedCharacters = S.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });

            Dictionary<char, int> charCountMapping = new Dictionary<char, int>();

            foreach (var group in grouppedCharacters)
            {
                charCountMapping.Add(group.Char, group.Count);
            }
 
            foreach (var jwel in J)
            {
                if (charCountMapping.ContainsKey(jwel))
                    count += charCountMapping[jwel];
            }

            return count;
        }
    }
}
