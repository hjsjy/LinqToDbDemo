using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseDemo.model;

namespace DatabaseDemo.repository
{
    public class EmployeesRepository
    {
        private readonly PostgreDB _context;

        public EmployeesRepository(PostgreDB context)
        {
            _context = context;
        }

        public IEnumerable<Employees> GetEmployees(string id)
        {
            try
            {
                return _context.Employeeses.Where(x => x.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}