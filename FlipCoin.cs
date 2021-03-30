using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBasicProgram
{
    /// <summary>
    /// Finding out percentage for head and tail while fliping coin
    /// </summary>
    class FlipCoin
    {
        public void ReadInput()
        {
            Console.WriteLine("Please enter number of times yoy want to flip coin");
            string input = Console.ReadLine();
            //convert from string into intwith the help convert.ToInt32()
            int numbOfTimes = Convert.ToInt32(Console.ReadLine());
            //calling Flip() method to find percentage
            Flip(numbOfTimes);
        }
        private static void Flip(int numbOfTimes)
        {
            // Initialization of local variables
            int tail = 0;int head = 0;
            //Object creation for predifined Random class
            Random random = new Random();
            //Using for loop to iterate till condition fails
            for(int i=1;i<=numbOfTimes; i++)
            {
                //using random function called NextDouble() tyo get random value
                if (random.NextDouble() < 0.5)
                {
                    //increamenting tail count by 1
                    tail++;
                    Console.WriteLine("Tail");
                }
                else
                    //incrementing head count by 1
                    head++;
            }
            //Applying formula to find percentage
            double tailPercentage = (double)tail / numbOfTimes * 100;
            double headPercentage = (double)head / numbOfTimes * 100;
            //finally printing count and also percentage for head and tail
            Console.WriteLine("Tail count "+"="+tail+"\tPercentage "+ tailPercentage);
            Console.WriteLine("Head count "+"="+head+"\tPercentage "+ headPercentage);
        }
    }
}
