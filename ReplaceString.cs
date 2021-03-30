using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBasicProgram
{
    /// <summary>
    /// Reading input from user & Replacing username with template
    /// </summary>
    class ReplaceString
    {
        public static void ReadInput()
        {
            string template = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Please Enter your Name");
            string userInput = Console.ReadLine();
            ReplaceWord(template, userInput);
        }
        private static void ReplaceWord(string template, string userInput)
        {
            string result=template.Replace("<<userName>>", userInput);
            Console.WriteLine("After done Replace " + result);
        }
    }
}
