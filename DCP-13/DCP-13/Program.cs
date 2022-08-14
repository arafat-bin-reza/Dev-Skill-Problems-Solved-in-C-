using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            T = Convert.ToInt32(Console.ReadLine());
            
            while (T > 0)
            {
                List<int> s1 = new List<int>();
                int w = 0;
                
                string phrase1 = Console.ReadLine();
                string[] words1 = phrase1.Split(' ');

                foreach (var word1 in words1)
                {
                    s1.Add(Convert.ToInt32(word1));
                }

                if (s1[0] + s1[1] > s1[2] + s1[3])
                {
                    w++;
                }
                

                List<int> s2 = new List<int>();

                string phrase2 = Console.ReadLine();
                string[] words2 = phrase2.Split(' ');

                foreach (var word2 in words2)
                {
                    s2.Add(Convert.ToInt32(word2));
                }
                if (s2[0] + s2[1] > s2[2] + s2[3])
                {
                    w++;
                }

                if (w == 2)
                {
                    Console.WriteLine("Banglawash");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
                T--;
            }
        }
    }
}
