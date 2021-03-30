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
        /// <summary>
        /// reading input from user
        /// </summary>
        public void ReadInput()
        {
            //given string template
            string template = "Hello <<UserName>>, How are you?";
            // giving message to user
            Console.WriteLine("Please Enter your Name");
            // Reading input from user
            string userInput=Console.ReadLine();
            //calling replace() method
            ReplaceWord(template, userInput);
        }
        /// <summary>
        /// Created replace() method to perform replacement
        /// </summary>
        /// <param name="template"></param>
        /// <param name="userInput"></param>
        private static void ReplaceWord(string template,string userInput)
        {
            //using predefined string Replace() method to perform replace operation
            string result=template.Replace("<<userName>>", userInput);
            //finally displaying updated template/statement
            Console.WriteLine("After done Replace " + result);
        }
    }
}
