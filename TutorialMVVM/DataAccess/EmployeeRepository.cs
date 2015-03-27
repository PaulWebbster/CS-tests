using System.Collections.Generic;
using TutorialMVVM.Model;

namespace TutorialMVVM.DataAccess
{
    public class EmployeeRepository
    {
        readonly List<Employee> _employees;

        public EmployeeRepository()
        {
            if (_employees == null)
            {
                _employees = new List<Employee>();
            }

            _employees.Add(Employee.CreateEmployee("Pawel", "Weber"));
            _employees.Add(Employee.CreateEmployee("Mateusz", "Bochynski"));
            _employees.Add(Employee.CreateEmployee("Krzysztof", "Berezowski"));
        }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>(_employees);
        }
    }
}
