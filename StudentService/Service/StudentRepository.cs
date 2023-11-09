using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentService.Model;
using System.Reflection;

namespace StudentService.Service
{
    public class StudentRepository: IStudentRepository
    {
        private readonly static List<Model.Student> _students = StudentSeed();

        private static List<Student> StudentSeed()
        {
            var result = new List<Model.Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "John Doe",
                    School = "University of somewhere"
                },
                new Student
                {
                    Id = 2,
                    Name = "Jane Doe",
                    School = "University of Elsewhere"
                },
                new Student
                {
                    Id = 3,
                    Name = "John Lee",
                    School = "Where College"
                },
            };
            return result;
        } 

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student Get(int id)
        {
            return _students[id];
        }

    }
}