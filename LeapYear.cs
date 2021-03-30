using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBasicProgram
{  /// <summary>
 /// Find the given year is leap Year or Not
 /// </summary>
    class LeapYear
    { //Created a Class
            public void ReadInput()
            {    //Reading input from user
                Console.Write("Enter a Year  :- ");
                string leapyear = Console.ReadLine();
                int year = Convert.ToInt32(leapyear);
                //converted string into integer value
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) 
                //Enter Year such as 1900 2100 2000 ...
                    Console.WriteLine($"It is a Leap Year");
                else
                    Console.WriteLine($"It is Not a Leap Year");


            }
        }
    }

