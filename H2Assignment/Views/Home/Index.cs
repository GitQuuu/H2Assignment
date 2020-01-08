using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2Assignment.Controllers;
using H2Assignment.Models;

namespace H2Assignment.Views.Home
{
    class Index
    {
        public enum HomeMenu
        {
            Create = 1, Read = 2, Update = 3, Delete = 4, Exit = 5,
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Student Tracker");
        }

        public static void Menu()
        {
            Console.WriteLine("\nSelect following options \n");

            bool terminate = true;
            do
            {
                Console.WriteLine("1.Add student \n2.Get a list of students \n3.Update a student \n4.Delete a student \n5.Exit program");   
                bool loopState = true;
                while (loopState)
                {
                    switch (int.TryParse(Console.ReadLine(), out int value) ? value : 0)
                    {
                        case (int)HomeMenu.Create:
                            StudentsController.Create();
                            loopState = false;
                            break;
                        case (int)HomeMenu.Read:
                            Console.Clear();
                            Console.WriteLine("List of students\n");
                            StudentsController.Read();
                            loopState = false;
                            break;
                        case (int)HomeMenu.Update:
                            StudentsController.Update(int.Parse(Utility.Ask("Select student by ID", Student.DefaultValueId)));
                            loopState = false;
                            break;
                        case (int)HomeMenu.Delete:
                            StudentsController.Delete(int.Parse(Utility.Ask("Select a student to delete by Student ID", Student.DefaultValueId)));
                            loopState = false;
                            break;
                        case (int)HomeMenu.Exit:
                            loopState = false;
                            terminate = false;
                            break;
                        default:
                            Console.WriteLine("Please choose between 1-5 again");
                            break;
                    }

                }
            } while (terminate);
           

        }

    }
}
