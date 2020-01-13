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
                Console.Clear();
                Student newStudent = new Student
                {
                    Id = int.Parse(Utility.Ask("Student ID",Student.DefaultValueId)),
                    FirstName = Utility.Ask("Student first name"),
                    LastName = Utility.Ask("Student last name"),
                    PhoneNumber = int.Parse(Utility.Ask("Student phone number", Student.DefaultValueId)),
                };

                students.Add(newStudent);

                bool choiceLoopState = true;
                while (choiceLoopState)
                {
                    switch (Utility.Ask("add a student y/n?"))
                    {
                        case "y":
                            choiceLoopState = false;
                            break;
                        case "n":
                            Console.Clear();
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

            if (students.Count == 0 )
            {
                Console.WriteLine("LIST IS EMPTY\n");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine($"Student ID:{student.Id} NAME:{student.FirstName} {student.LastName} PHONE NUMBER:{student.PhoneNumber}\n");
                }
                
            }
           
        }

        public static void Update(int id)
        {
            if (students.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("List does not contain any students\n");
                return;
            }
            

            foreach (Student inList in students)
            {
                if (id == inList.Id)
                {
                    inList.FirstName = Utility.Ask("Student first name");
                    inList.LastName = Utility.Ask("Student last name");
                    inList.PhoneNumber = int.Parse(Utility.Ask("Student phone number", Student.DefaultValueId));
                    Console.Clear();
                    Console.WriteLine($"Student ID {id} now updated\n");
                    return;
                }
                                     
            }

            Console.Clear();
            Console.WriteLine($"Id:{id} does not exist in list\n");
        }

        public static void Delete(int id) 
        {
            if (students.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("List does not contain any students\n");
                return;
            }

            foreach (Student inList in students)
            {
                if (id == inList.Id)
                {
                    students.Remove(inList);
                    Console.Clear();
                    Console.WriteLine($"STUDENT {id} IS DELETED\n");
                    return;
                }
            }

            Console.Clear();
            Console.WriteLine($"ID:{id} does not match anything in the list\n");
        }
    }
}
