using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            T = Convert.ToInt32(Console.ReadLine());

            while (T > 0)
            {
                List<double> s = new List<double>();
                

                string phrase = Console.ReadLine();
                string[] words = phrase.Split(' ');

                foreach (var word in words)
                {
                    s.Add(Convert.ToDouble(word));
                }

                double AC = Math.Sqrt(Math.Pow(s[0], 2) + Math.Pow(s[1], 2));
                double AD = Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(s[2], 2));

                var Result = Convert.ToDouble(String.Format("{0:0.00}", AD));

                Console.WriteLine(Result);

                T--;
            }
        }
    }
}
