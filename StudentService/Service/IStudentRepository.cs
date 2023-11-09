using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StudentService.Service
{
    public interface IStudentRepository
    {
        List<Model.Student> GetAll();
        Model.Student Get(int id);
    } 
}