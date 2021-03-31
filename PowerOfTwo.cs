using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBasicProgram
{
    class PowerOfTwo
    {
        public void ReadInput()
        {

            Console.WriteLine("Enter as 2^Number :- ");
            //Reading input from user
            string VNumber = Console.ReadLine();
            int number = Convert.ToInt32(VNumber);
            //convert from string into integer value
            int num = 1;
            int i = 1;
            // count from 0 to N
            int LimitPowerTwo = 30;
            // repeat until i equals n

            if (number > LimitPowerTwo)
            {
                Console.WriteLine($"You Enter of 2^ exceeds the value limit 30  ");
                // condition not equal to show message
            }
            else
            {

                for (i = 1; i <= number; i++)

                //to Check a number 
                {
                    num = (num * 2);
                    // multiply number by 2
                    Console.WriteLine(num);
                }
            }

        }
    }
}
