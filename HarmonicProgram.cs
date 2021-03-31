using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBasicProgram
{
    class HarmonicProgram
            {

            public void ReadInput()
            {
            Console.Write("Enter a Number:- ");
            string nthNumber = Console.ReadLine();
            int nthnumber = Convert.ToInt32(nthNumber);
            Harmonic(nthnumber);
            //Console.WriteLine("sum of all harmonic list "+result);
        }

            private static void Harmonic(int lastNumber)
            {
                double sum = 0;
                // 1/1 + 1/2 + 1/3 ..... +1/5 (or sum value)
                for (int i = 1; i <= lastNumber; i++)
                {
                    Console.Write("1/{0} + ", i);
                    sum += 1 / (float)i;
                }
                //Console.WriteLine(sum + "+");
                Console.Write("\nSum of Series upto {0} terms : {1} \n", lastNumber, sum);

            }
        }
    }


