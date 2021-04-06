using Microsoft.AspNetCore.WebUtilities;
using PaginationAndSearch.Client.Interface;
using PaginationAndSearch.Client.Services;
using PaginationAndSearch.Shared.Models;
using PaginationAndSearch.Shared.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PaginationAndSearch.Client.Repository
{
    public class EmployeeHttpRepository : IEmployeeHttpRepository
    {
        private readonly HttpClient httpClient;
        private string url = "api/Employee";

        public EmployeeHttpRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<PagingResponse<Employee>> GetEmployees(EmployeeParameters employeeParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = employeeParameters.PageNumber.ToString(),
                ["searchTerm"] = employeeParameters.SearchTerm == null ? "" : employeeParameters.SearchTerm,
                ["orderBy"] = employeeParameters.OrderBy
            };

            var response = await httpClient.GetAsync(QueryHelpers.AddQueryString(url, queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var pagingResponse = new PagingResponse<Employee>
            {
                Items = JsonSerializer.Deserialize<List<Employee>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }),
                PageMetadata = JsonSerializer.Deserialize<PageMetadata>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            };

            return pagingResponse;

        }
    }
}
