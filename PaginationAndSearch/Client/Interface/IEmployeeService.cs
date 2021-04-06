using PaginationAndSearch.Shared.Models;
using PaginationAndSearch.Shared.ServiceModels;
using System.Threading.Tasks;
using Telerik.DataSource;

namespace PaginationAndSearch.Client.Interface
{
    public interface IEmployeeService
    {
        Task<DataEnvelope<Employee>> GetEmployeesListAsync(DataSourceRequest gridRequest);
    }
}