using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherService.Service
{
    public interface ITeacherRepository
    {
        List<Model.Teacher> GetAll();
        Model.Teacher Get(int id);
    }
}