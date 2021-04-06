using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PaginationAndSearch.Shared.ServiceModels
{
    public static class JsonExtensions
    {
        public static object Deserialize<T>(this JsonElement element, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize(element.GetRawText(), typeof(T), options);
        }
    }
}
