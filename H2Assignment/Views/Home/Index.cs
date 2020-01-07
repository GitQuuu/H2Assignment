using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2Assignment.Controllers;

namespace H2Assignment.Views.Home
{
    class Index
    {
        public enum HomeMenu
        {
            Create = 1, Read = 2, Update = 3, Delete = 4,
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Student Tracker");
        }

        public static void Menu()
        {
            Console.WriteLine("\n1.Add student \n2.Get a list of students \n3.Update a student \n4.Delete a student\n");
            bool loopState = true;

            while (loopState)
            {
                switch (Int32.TryParse(Console.ReadLine(), out int value) ? value : 0)
                {
                    case (int)HomeMenu.Create:
                        Console.WriteLine("Create");
                        StudentsController.Create();
                        loopState = false;
                        break;
                    case (int)HomeMenu.Read:
                        Console.WriteLine("Read");
                        loopState = false;
                        break;
                    case (int)HomeMenu.Update:
                        Console.WriteLine("Update");
                        loopState = false;
                        break;
                    case (int)HomeMenu.Delete:
                        Console.WriteLine("Delete");
                        loopState = false;
                        break;
                    default:
                        Console.WriteLine("Please choose between 1-4 again");
                        break;
                }
           
            }
        }

    }
}
