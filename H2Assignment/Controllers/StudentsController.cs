using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;
using H2Assignment.Models;

namespace H2Assignment.Controllers
{
    class StudentsController
    {
        static List<Student> students = new List<Student>();

        public static void Create()
        {
            bool loopState = true;
            do
            {
                Student newStudent = new Student
                {
                    Id = int.Parse(Utility.Ask("Give student Id")),
                    FirstName = Utility.Ask("Student first name"),
                    LastName = Utility.Ask("Student last name"),
                    PhoneNumber = int.Parse(Utility.Ask("Student phone number")),
                };

                students.Add(newStudent);

                bool choiceLoopState = true;
                while (choiceLoopState)
                {
                    switch (Utility.Ask("add student y/n?"))
                    {
                        case "y":
                            break;
                        case "n":
                            choiceLoopState = false;
                            loopState = false;
                            break;
                        default:
                            Console.WriteLine("Choice either y or n ");
                            break;
                    }
                }
             
            } while (loopState);
            

           
        }

        public void Save()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
