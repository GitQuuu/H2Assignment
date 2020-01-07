using System;
using System.Collections.Generic;
using System.Dynamic;
using H2Assignment.Models;

namespace H2Assignment.Controllers
{
    class StudentsController
    {
        static List<Student> students = new List<Student>();

        public static void Create()
        {
            Student newStudent = new Student
            {
                Id = int.Parse(Utility.Ask("Give student Id")),
                FirstName = Utility.Ask("Student first name"),
                LastName = Utility.Ask("Student last name"),
                PhoneNumber = int.Parse(Utility.Ask("Student phone number")),
            };

            students.Add(newStudent);
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
