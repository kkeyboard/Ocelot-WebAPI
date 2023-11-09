using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherService.Model;

namespace TeacherService.Service
{
    public class TeacherRepository: ITeacherRepository
    {
        
        private static readonly List<Teacher> _teachers = SeedTeachers();
        private static List<Teacher> SeedTeachers()
        {
            var result = new List<Model.Teacher>()
            {
                new Teacher
                {
                    Id = 1,
                    Name = "Great Teacher",
                    School = "Tokyo High"
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Walter White",
                    School = "New Mexico High"
                },
                new Teacher
                {
                    Id = 3,
                    Name = "John Keating",
                    School = "Dead Poet High"
                },
            };
            return result;
        }

        public List<Teacher> GetAll()
        {
            return _teachers.ToList();
        }

        public Teacher Get(int id)
        {
            return _teachers[id];
        }
    }
}