using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBasicProgram
{
    class FlipCoin
    {
        public void ReadInput()
        {
            Console.WriteLine("Please enter number of times yoy want to flip coin");
            int numbOfTimes = Convert.ToInt32(Console.ReadLine());
            Flip(numbOfTimes);
        }
        private static void Flip(int numbOfTimes)
        {
            int tail = 0;int head = 0;
            Random random = new Random();
            for(int i=1;i<=numbOfTimes; i++)
            {
                if (random.NextDouble() < 0.5)
                    tail++;
                else
                    head++;
            }
            double tailPercentage = (double)tail / numbOfTimes * 100;
            double headPercentage = (double)head / numbOfTimes * 100;
            Console.WriteLine("Tail count "+"="+tail+"\tPercentage "+ tailPercentage);
            Console.WriteLine("Head count "+"="+head+"\tPercentage "+ headPercentage);
        }
    }
}
