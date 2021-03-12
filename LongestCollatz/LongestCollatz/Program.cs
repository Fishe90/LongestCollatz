using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = 1000;
            int indexChain = 0;
            int nextList = 0;
            List<int> topTen = new List<int>();
            List<int> number = new List<int>();
            //List<KeyValuePair<int, int>> pairs = new List<KeyValuePair<int, int>>();
            //KeyValuePair<int, int> pair = new KeyValuePair<int, int>();
            //Dictionary<int, int> valuePair = new Dictionary<int, int>();
            while (startNum > 1)
            {
                int currectNum = startNum;
                number.Add(currectNum);
                while (startNum > 1)
                {
                    if (startNum % 2 == 0)
                    {
                        startNum /= 2;
                    }
                    else
                    {
                        startNum = (3 * startNum) + 1;
                    }
                    indexChain += 1;
                }
                //pair.Key = startNum;
                //pairs.Add(startNum, indexChain);
                //valuePair.Add(startNum, indexChain);
                nextList += 1;
                startNum += (1000 - nextList);
                topTen.Add(indexChain);
                //Console.WriteLine(indexChain);
                topTen.Add(indexChain);
                indexChain -= indexChain;
            }
            topTen.Sort();
            Console.WriteLine(topTen[topTen.Count-1]);
            Console.WriteLine();
            //foreach (KeyValuePair<int, int> item in valuePair)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}
        }
    }
}
