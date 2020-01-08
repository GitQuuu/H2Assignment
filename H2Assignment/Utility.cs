using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace H2Assignment
{
    class Utility
    {
        /// <summary>
        /// A simple method for WriteLine and ReadLine
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        /// <summary>
        /// Preventing format errors - input must be integer
        /// </summary>
        /// <param name="question"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string Ask(string question,int id)
        {
            Console.WriteLine(question);

            string result = "";
            bool loopState = true;

            do
            {
                if (int.TryParse(Console.ReadLine(), out int output))
                {
                    result = output.ToString();
                    loopState = false;

                }
                else
                {
                    Console.WriteLine("Value must be a number, please try again");

                }

            } while (loopState);

            return result;
        }
    }
}
