using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> map = new Dictionary<char,char>();

            CreateMap(map);
            var result = DecodeMessage(new char[] { '1', '2' }, map);
            Console.Read();
        }

        private static List<string> DecodeMessage(char[] data, Dictionary<char, char> map)
        {
            var result = new List<string>();
            char[] message = new char[data.Length];
            int index = 0;
            // First individual characters
            foreach (char ch in data)
            {
                result.Add(map[ch].ToString());
                message[index] = ch;
            }

            

            return new List<string>();
        }

        private static void CreateMap(Dictionary<char, char> map)
        {
            int startIndex = 49;

            for(int charAscii = 97; charAscii <= 122; charAscii++)
            {
                map.Add((char)startIndex, (char)charAscii);
                startIndex++;
            }
        }
    }
}
