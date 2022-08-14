using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;
            List<int> CT = new List<int>();
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                
                CT.Add(Convert.ToInt32(word));
            }

            
            

            while (CT[1]>0)
            {
                int P;
                P = Convert.ToInt32(Console.ReadLine());

                T += P;
                CT[1]--;
            }

            if (T == CT[0])
            {
               Console.WriteLine("Project will finish within 1 day.");
            }
            else
            {
                int D = CT[0] / T;
                int R = CT[0] % T;
                if (R == 0)
                {
                    Console.Write("Project will finish within ");
                    Console.Write(D);
                    Console.WriteLine("days.");
                }
                else
                {
                    Console.Write("Project will finish within ");
                    Console.Write(D+1);
                    Console.WriteLine(" days.");
                }
                

            }

            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
