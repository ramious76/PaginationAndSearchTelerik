using PaginationAndSearch.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaginationAndSearch.Shared.Models;
using Microsoft.EntityFrameworkCore;
using PaginationAndSearch.Server.Interface;
using PaginationAndSearch.Shared.ServiceModels;

namespace PaginationAndSearch.Server.Repository
{
    public class EmployeeRepositoryServer : IEmployeeRepositoryServer
    {
        private readonly AdventureWorksContext context;

        public EmployeeRepositoryServer(AdventureWorksContext context)
        {
            this.context = context;
        }
        public async Task<PagedList<Employee>> GetEmployees(EmployeeParameters employeeParameters)
        {
            var employees = await context.Employees
                .Search(employeeParameters.SearchTerm)
                .Sort(employeeParameters.OrderBy)
                .ToListAsync();

            return PagedList<Employee>
                .ToPagedList(employees, employeeParameters.PageNumber, employeeParameters.PageSize);
        }
    }
}
