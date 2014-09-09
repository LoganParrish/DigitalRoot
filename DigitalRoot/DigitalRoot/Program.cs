using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("31337");
            DigitalRoot("45734");
            Console.ReadKey();
        }
        static void DigitalRoot(string rootThis)
        {
            int trueRoot = int.Parse(rootThis);
            int answer = 0;
            if(trueRoot > 0)
            {
                int total = trueRoot % 10;
                trueRoot /= 10;
                answer = answer + total;

            }
            else if (answer <= 9)
            {
                
            }
            Console.WriteLine(answer + 1);
        }    
    }
}
