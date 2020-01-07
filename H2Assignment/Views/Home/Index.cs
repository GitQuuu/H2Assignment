using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Assignment.Views.Home
{
    class Index
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Student Tracker");
        }

        public void Menu()
        {
            Console.WriteLine("1.Add student \n2.Get a list of students \n3.Update a student \n4.Delete a student");
        }

    }
}
