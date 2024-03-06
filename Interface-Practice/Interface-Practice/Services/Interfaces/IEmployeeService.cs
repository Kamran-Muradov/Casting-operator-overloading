using Interface_Practice.Helpers.Responses;
using Interface_Practice.Models;

namespace Interface_Practice.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetById(Employee[] employees, int? id);
        Employee[] Search(Employee[] employees, string searchText);
    }
}
