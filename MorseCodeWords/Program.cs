using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "gin", "zen", "gig", "msg" };
            var result = UniqueMorseRepresentations(words);
            Console.WriteLine(result);

            Console.Read();
        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            if (words == null || !words.Any()) return 0;

            Dictionary<string, int> codeMapping = new Dictionary<string, int>();
            Dictionary<char, string> map = CreateMap();

            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Clear();
                foreach (var ch in word)
                {
                    if (map.ContainsKey(ch))
                    {
                        sb.Append(map[ch]);
                    }                    
                }

                string code = sb.ToString();
                if (codeMapping.ContainsKey(code))
                {
                    codeMapping[code] = codeMapping[code] + 1;
                }
                else
                {
                    codeMapping.Add(code, 1);
                }
            }

            return codeMapping.Count;
        }

        private static Dictionary<char, string> CreateMap()
        {
            var mapping = new Dictionary<char, string>
            {
                { 'a', ".-" },
                { 'b', "-..." },
                { 'c', "-.-." },
                { 'd', "-.." },
                { 'e', "." },
                { 'f', "..-." },
                { 'g', "--." },
                { 'h', "...." },
                { 'i', ".." },
                { 'j', ".---" },
                { 'k', "-.-" },
                { 'l', ".-.." },
                { 'm', "--" },
                { 'n', "-." },
                { 'o', "---" },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-." },
                { 's', "..." },
                { 't', "-" },
                { 'u', "..-" },
                { 'v', "...-" },
                { 'w', ".--" },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." }
            };

            return mapping;
        }
    }
}
