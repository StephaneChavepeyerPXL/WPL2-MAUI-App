using SteCvp.Application.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteCvp.Domain;
using SteCvp.Application.Interfaces;

namespace SteCvp.Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        //public SelectResult<Student> GetStudents()
        //{
        //    SelectResult<Student> selectResult = new SelectResult<Student>();
        //    try
        //    {
        //        selectResult.Rows = _repository.GetAll();
        //    }

        //    catch (Exception ex)
        //    {
        //        selectResult.Errors.Add(ex.Message);
        //    }

        //    return selectResult;
        //}

        //public InsertResult AddStudent(string firstName, string lastName)
        //{
        //    InsertResult insertResult = new InsertResult();
        //    try
        //    {
        //        Student student = new Student(firstName, lastName);
        //        _repository.Add(student);
        //    }
        //    catch (Exception ex)
        //    {   
        //        insertResult.Errors.Add(ex.Message);
        //    }
        //    return insertResult;
        //}
    }
}
