using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class StudentController : Controller
    {
        StudentDAL obj = new StudentDAL();

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Students> Get()
        {
            return obj.GetAllStudents();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Students Get(int id)
        {
            return obj.GetStudentData(id);
        }

        // POST api/<controller>
        [HttpPost]
        public int Post(Students student)
        {
            Console.WriteLine(student);
            return obj.CreateStudent(student);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public int Put(Students student)
        {
            return obj.UpdateStudent(student);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return obj.DeleteStudent(id);
        }
    }
}
