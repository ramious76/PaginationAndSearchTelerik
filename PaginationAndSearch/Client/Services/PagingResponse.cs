using PaginationAndSearch.Shared.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginationAndSearch.Client.Services
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public PageMetadata PageMetadata { get; set; }
    }
}
