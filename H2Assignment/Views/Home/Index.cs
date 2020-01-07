﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("\n1.Add student \n2.Get a list of students \n3.Update a student \n4.Delete a student");

            switch (Int32.TryParse(Console.ReadLine(), out int value) ? value : 0)
            {
                case (int)HomeMenu.Create:
                    Console.WriteLine("Create");
                    break;
                case (int)HomeMenu.Read:
                    Console.WriteLine("Read");
                    break;
                case (int)HomeMenu.Update:
                    Console.WriteLine("Update");
                    break;
                case (int)HomeMenu.Delete:
                    Console.WriteLine("Delete");
                    break;
            }
        }

    }
}
