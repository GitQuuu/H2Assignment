using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;
using H2Assignment.Models;

namespace H2Assignment.Controllers
{
    class StudentsController
    {
        static readonly List<Student> students = new List<Student>();

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
                            choiceLoopState = false;
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

        public static void Read()
        {
            Console.WriteLine("Select a student by Student ID number\n");

            if (students.Count == 0 )
            {
                Console.WriteLine("LIST IS EMPTY");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine($"Student ID:{student.Id} NAME:{student.FirstName} {student.LastName} PHONE NUMBER:{student.PhoneNumber}");
                }
            }
           
        }

        public static void Update(int id)
        {
            foreach (Student inList in students)
            {
                if (id != inList.Id)
                {
                    Console.WriteLine("ID doesnt match anything in the list");
                }
                else
                {
                    inList.FirstName = Utility.Ask("Student first name");
                    inList.LastName = Utility.Ask("Student last name");
                    inList.PhoneNumber = int.Parse(Utility.Ask("Student phone number"));
                }
            }
        }

        public static void Delete(int id) 
        {
            foreach (Student inList in students.ToArray())
            {
                if (id == inList.Id)
                {
                    students.Remove(inList);
                    Console.WriteLine("STUDENT IS DELETED");
                }
                else
                {
                    Console.WriteLine("ID doesnt match anything in the list");
                }
            }
        }
    }
}
