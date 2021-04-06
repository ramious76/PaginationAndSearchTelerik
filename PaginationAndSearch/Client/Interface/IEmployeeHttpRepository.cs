using PaginationAndSearch.Client.Services;
using PaginationAndSearch.Shared.Models;
using PaginationAndSearch.Shared.ServiceModels;
using System.Threading.Tasks;

namespace PaginationAndSearch.Client.Interface
{
    public interface IEmployeeHttpRepository
    {
        Task<PagingResponse<Employee>> GetEmployees(EmployeeParameters employeeParameters);
    }
}