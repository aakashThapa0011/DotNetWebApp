using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class StudentController : Controller
    {
        readonly StudentDAL obj = new StudentDAL();

        // GET: api/<controller>
        [HttpGet]
        [Authorize]
        public IEnumerable<Students> Get()
        {
            return obj.GetAllStudents();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [Authorize]
        public Students Get(int id)
        {
            return obj.GetStudentData(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize]
        public object Post([FromBody] Students student)
        {
            return obj.CreateStudent(student);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize]
        public object Put([FromBody] Students student)
        {
            return obj.UpdateStudent(student);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize]
        public int Delete(int id)
        {
            return obj.DeleteStudent(id);
        }
    }
}
