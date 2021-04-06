using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaginationAndSearch.Server.Interface;
using PaginationAndSearch.Server.Services;
using PaginationAndSearch.Shared.Models;
using PaginationAndSearch.Shared.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.DataSource;
using Telerik.DataSource.Extensions;

namespace PaginationAndSearch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepositoryServer employeeRepository;
        private readonly AdventureWorksContext context;

        public EmployeeController(IEmployeeRepositoryServer employeeRepository
                                    , AdventureWorksContext context)
        {
            this.employeeRepository = employeeRepository;
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] EmployeeParameters employeeParameters)
        {
            var employees = await employeeRepository.GetEmployees(employeeParameters);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(employees.PagedMetadata));

            return Ok(employees);
        }

        [HttpPost]
        public async Task<DataEnvelope<Employee>> Post([FromBody] DataSourceRequest gridRequest)
        {
            IQueryable<Employee> queriableData = context.Employees.AsQueryable();

            DataSourceResult processedData = await queriableData.ToDataSourceResultAsync(gridRequest);

            DataEnvelope<Employee> dataToReturn;

            if(gridRequest.Groups.Count > 0)
            {
                dataToReturn = new DataEnvelope<Employee>
                {
                    GroupedData = processedData.Data.Cast<AggregateFunctionsGroup>().ToList(),
                    TotalItemCount = processedData.Total
                };
            }
            else
            {
                dataToReturn = new DataEnvelope<Employee>
                {
                    CurrentPageData = processedData.Data.Cast<Employee>().ToList(),
                    TotalItemCount = processedData.Total
                };
            }

            return dataToReturn;
        }


    }
}
