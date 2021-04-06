using PaginationAndSearch.Server.Services;
using PaginationAndSearch.Shared.Models;
using PaginationAndSearch.Shared.ServiceModels;
using System.Threading.Tasks;

namespace PaginationAndSearch.Server.Interface

{
    public interface IEmployeeRepositoryServer
    {
        Task<PagedList<Employee>> GetEmployees(EmployeeParameters employeeParameters);
    }
}