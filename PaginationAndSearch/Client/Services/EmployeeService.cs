using Microsoft.AspNetCore.Components;
using PaginationAndSearch.Client.Interface;
using PaginationAndSearch.Shared.Models;
using PaginationAndSearch.Shared.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;
using Telerik.DataSource;
using Telerik.DataSource.Extensions;

namespace PaginationAndSearch.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        [Inject]
        private HttpClient http { get; set; }


        public EmployeeService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<DataEnvelope<Employee>> GetEmployeesListAsync(DataSourceRequest gridRequest)
        {
            HttpResponseMessage response = await http.PostAsJsonAsync("api/employee", gridRequest);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadFromJsonAsync<DataEnvelope<Employee>>();
            }

            throw new Exception($"The service returned with status {response.StatusCode}");
        }
    }
}
