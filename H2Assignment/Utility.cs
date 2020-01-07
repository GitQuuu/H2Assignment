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
        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
