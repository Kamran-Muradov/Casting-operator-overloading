using Interface_Practice.Services.Interfaces;
using Interface_Practice.Services;
using Interface_Practice.Models;
using Interface_Practice.Helpers.Constans;

namespace Interface_Practice.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
            var employees = _employeeService.GetAll();

            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Age} {employee.Address} {employee.Email} {employee.Birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }
        }

        public void GetById()
        {
            int? id = 100;

            var response = _employeeService.GetById(_employeeService.GetAll(), id);

            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Age} {response.Employee.Address} {response.Employee.Email} {response.Employee.Birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }

        public void Search()
        {
            Console.WriteLine("Add search text: ");
            string searchText = Console.ReadLine();

            var response = _employeeService.Search(_employeeService.GetAll(), searchText);

            if (response.Length==0)
            {
                Console.WriteLine(EmployeeResponseMessages.Notfound);
            }
            else
            {
                foreach (var employee in response)
                {
                    string result = $"{employee.Name} {employee.Surname} {employee.Age} {employee.Address} {employee.Email} {employee.Birthday.ToString("MM/dd/yyyy")}";
                    Console.WriteLine(result);
                }
            }

        }
    }
}
