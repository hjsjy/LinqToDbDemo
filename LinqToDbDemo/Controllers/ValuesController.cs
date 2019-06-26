using System.Collections.Generic;
using DatabaseDemo.repository;
using Microsoft.AspNetCore.Mvc;

namespace LinqToDbDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmployeesRepository _employeesRepository;

        public ValuesController(EmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public void Get(string id)
        {
            _employeesRepository.GetEmployees(id);
        }
    }
}